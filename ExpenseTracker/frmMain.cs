using System.ComponentModel;
using System.Text.Json;

namespace ExpenseTracker
{
    public partial class frmMain : Form
    {
        private readonly BindingList<Expense> expenses = new();
        private string? currentFile = null;
        private bool isDirty = false;


        public frmMain()
        {
            InitializeComponent();
        }


        private bool SaveFile()
        {
            if (currentFile == null) return SaveFileAs();   // no file yet -> behaves like Save As
            return WriteToFile(currentFile);
        }

        private bool SaveFileAs()
        {
            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            dialog.FileName = "expenses.json";

            if (dialog.ShowDialog() != DialogResult.OK) return false;   // user cancelled
            return WriteToFile(dialog.FileName);
        }

        private bool WriteToFile(string path)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(expenses.ToList(), options);
                File.WriteAllText(path, json);

                currentFile = path;
                isDirty = false;
                UpdateTitle();
                lblStatus.Text = "File saved.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the file.\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // true = it's OK to continue, false = the user wants to stay
        private bool ConfirmDiscardChanges()
        {
            if (!isDirty) return true;

            DialogResult answer = MessageBox.Show(
                "You have unsaved changes. Save first?", "Unsaved Changes",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (answer == DialogResult.Cancel) return false;
            if (answer == DialogResult.Yes) return SaveFile();
            return true;    // No = discard the changes
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscardChanges()) return;

            expenses.Clear();
            currentFile = null;
            isDirty = false;
            UpdateTitle();
            ApplyFilter();
            lblStatus.Text = "New file started.";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscardChanges()) return;

            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                string json = File.ReadAllText(dialog.FileName);
                List<Expense>? loaded = JsonSerializer.Deserialize<List<Expense>>(json);

                expenses.Clear();
                if (loaded != null)
                {
                    foreach (Expense item in loaded) expenses.Add(item);
                }

                currentFile = dialog.FileName;
                isDirty = false;
                UpdateTitle();
                ApplyFilter();
                lblStatus.Text = "File opened.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the file.\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void UpdateTitle()
        {
            string name = currentFile == null ? "Untitled" : Path.GetFileName(currentFile);
            Text = $"Expense Tracker - {name}{(isDirty ? "*" : "")}";
        }

        private void MarkDirty()
        {
            isDirty = true;
            UpdateTitle();
        }


        private void ApplyFilter()
        {
            IEnumerable<Expense> query = expenses;

            if (cboFilterCategory.SelectedIndex > 0)
                query = query.Where(x => x.Category == cboFilterCategory.Text);

            string keyword = txtSearch.Text.Trim();
            if (keyword != "")
                query = query.Where(x => x.Description.Contains(keyword,
                                          StringComparison.OrdinalIgnoreCase));

            if (chkDateRange.Checked)
                query = query.Where(x => x.Date.Date >= dtpFrom.Value.Date &&
                                         x.Date.Date <= dtpTo.Value.Date);

            List<Expense> result = query.OrderByDescending(x => x.Date).ToList();
            dgvExpenses.DataSource = result;

            lblRecords.Text = $"Records: {result.Count}";
            lblTotal.Text = $"Total: PHP {result.Sum(x => x.Amount):N2}";
            lblRecordCount.Text = $"Records: {result.Count}";

            UpdateRemaining();
        }

        private void dgvExpenses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvExpenses.Columns["Id"].Visible = false;
            dgvExpenses.Columns["Notes"].Visible = false;
            dgvExpenses.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dgvExpenses.Columns["Date"].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cboFilterCategory.Items.AddRange(new string[]
                { "All", "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            cboFilterCategory.SelectedIndex = 0;


            ApplyFilter();
            UpdateTitle();
            ShowTime();


        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }


        private void AddExpense_Click(object sender, EventArgs e)
        {
            using frmExpense form = new frmExpense();
            if (form.ShowDialog(this) != DialogResult.OK) return;

            Expense item = form.GetExpense();
            item.Id = expenses.Count == 0 ? 1 : expenses.Max(x => x.Id) + 1;

            expenses.Add(item);
            MarkDirty();
            ApplyFilter();
            lblStatus.Text = "Expense added.";
        }


        private void EditExpense_Click(object sender, EventArgs e)
        {
            Expense? selected = dgvExpenses.CurrentRow?.DataBoundItem as Expense;
            if (selected == null)
            {
                MessageBox.Show("Select an expense to edit.");
                return;
            }

            using frmExpense form = new frmExpense(selected);
            if (form.ShowDialog(this) != DialogResult.OK) return;

            MarkDirty();
            ApplyFilter();
            lblStatus.Text = "Expense updated.";
        }


        private void DeleteExpense_Click(object sender, EventArgs e)
        {
            Expense? selected = dgvExpenses.CurrentRow?.DataBoundItem as Expense;
            if (selected == null)
            {
                MessageBox.Show("Select an expense to delete.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                $"Delete \"{selected.Description}\"?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer != DialogResult.Yes) return;

            expenses.Remove(selected);
            MarkDirty();
            ApplyFilter();
            lblStatus.Text = "Expense deleted.";
        }


        private void UpdateRemaining()
        {
            decimal spent = expenses
                .Where(x => x.Date.Year == DateTime.Today.Year &&
                            x.Date.Month == DateTime.Today.Month)
                .Sum(x => x.Amount);

            decimal remaining = nudBudget.Value - spent;

            lblRemaining.Text = $"Remaining: PHP {remaining:N2}";
            lblRemaining.ForeColor = remaining < 0 ? Color.Red : Color.Black;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkDateRange_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = chkDateRange.Checked;
            dtpTo.Enabled = chkDateRange.Checked;
            ApplyFilter();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) EditExpense_Click(sender, e);
        }

        private void nudBudget_ValueChanged(object sender, EventArgs e)
        {
            UpdateRemaining();
        }

        private void ShowTime()
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            ShowTime();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmDiscardChanges()) e.Cancel = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Personal Expense Tracker\nVersion 1.0\nDeveloper: Your Name",
    "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {

        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }
    }
}
