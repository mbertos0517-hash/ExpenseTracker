using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class frmExpense : Form
    {
        private readonly Expense expense;
        public frmExpense(Expense? existing = null)
        {
            InitializeComponent();

            cboCategory.Items.AddRange(new string[]
            { "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            dtpDate.MaxDate = DateTime.Today;

            if (existing == null)
            {
                expense = new Expense();
                Text = "Add Expense";
                cboCategory.SelectedIndex = 0;
            }
            else
            {
                expense = existing;
                Text = "Edit Expense";
                dtpDate.Value = existing.Date;
                txtDescription.Text = existing.Description;
                cboCategory.SelectedItem = existing.Category;
                nudAmount.Value = existing.Amount;
                rdoCash.Checked = existing.PaymentMethod == "Cash";
                rdoGCash.Checked = existing.PaymentMethod == "GCash";
                rdoCard.Checked = existing.PaymentMethod == "Card";
                chkRecurring.Checked = existing.IsRecurring;
                txtNotes.Text = existing.Notes;
            }

        }

        public Expense GetExpense() => expense;


        private bool ValidateInputs()
        {
            bool ok = true;
            errProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errProvider.SetError(txtDescription, "Description is required.");
                ok = false;
            }
            if (cboCategory.SelectedIndex == -1)
            {
                errProvider.SetError(cboCategory, "Choose a category.");
                ok = false;
            }
            if (nudAmount.Value <= 0)
            {
                errProvider.SetError(nudAmount, "Amount must be greater than 0.");
                ok = false;
            }
            return ok;
        }


        private void frmExpense_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chkRecurring_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            expense.Date = dtpDate.Value.Date;
            expense.Description = txtDescription.Text.Trim();
            expense.Category = cboCategory.Text;
            expense.Amount = nudAmount.Value;
            expense.PaymentMethod = rdoGCash.Checked ? "GCash"
                                  : rdoCard.Checked ? "Card" : "Cash";
            expense.IsRecurring = chkRecurring.Checked;
            expense.Notes = txtNotes.Text.Trim();

            DialogResult = DialogResult.OK;
        }
    }
}
