namespace ExpenseTracker
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            eToolStripMenuItem = new ToolStripMenuItem();
            expenseToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblRecordCount = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            pnlFilter = new Panel();
            label4 = new Label();
            txtSearch = new TextBox();
            cboFilterCategory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chkDateRange = new CheckBox();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            pnlSummary = new Panel();
            nudBudget = new NumericUpDown();
            lblRemaining = new Label();
            label7 = new Label();
            lblTotal = new Label();
            lblRecords = new Label();
            dgvExpenses = new DataGridView();
            tmrClock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, expenseToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(892, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, toolStripMenuItem1, eToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(181, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(181, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(178, 6);
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(181, 26);
            eToolStripMenuItem.Text = "E&xit";
            eToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // expenseToolStripMenuItem
            // 
            expenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            expenseToolStripMenuItem.Size = new Size(77, 24);
            expenseToolStripMenuItem.Text = "&Expense";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(136, 26);
            addToolStripMenuItem.Text = "&Add";
            addToolStripMenuItem.Click += AddExpense_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(136, 26);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += EditExpense_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(136, 26);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += DeleteExpense_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbDelete });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(892, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(41, 24);
            tsbAdd.Text = "Add";
            tsbAdd.Click += AddExpense_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(39, 24);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += EditExpense_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(57, 24);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += DeleteExpense_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblRecordCount, lblClock });
            statusStrip1.Location = new Point(0, 527);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(892, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblStatus
            // 
            lblStatus.ImageAlign = ContentAlignment.MiddleLeft;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(732, 20);
            lblStatus.Spring = true;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordCount
            // 
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(77, 20);
            lblRecordCount.Text = "Records: 0";
            // 
            // lblClock
            // 
            lblClock.BackColor = SystemColors.ButtonFace;
            lblClock.ImageAlign = ContentAlignment.MiddleLeft;
            lblClock.Margin = new Padding(0, 4, 5, 2);
            lblClock.Name = "lblClock";
            lblClock.Overflow = ToolStripItemOverflow.Never;
            lblClock.Size = new Size(63, 20);
            lblClock.Text = "00:00:00";
            lblClock.TextAlign = ContentAlignment.MiddleLeft;
            lblClock.Click += lblClock_Click;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(label4);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(cboFilterCategory);
            pnlFilter.Controls.Add(label1);
            pnlFilter.Controls.Add(label2);
            pnlFilter.Controls.Add(label3);
            pnlFilter.Controls.Add(chkDateRange);
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 55);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(892, 50);
            pnlFilter.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(718, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 8;
            label4.Text = "To:";
            label4.Click += label4_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(313, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += Filter_Changed;
            // 
            // cboFilterCategory
            // 
            cboFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterCategory.FormattingEnabled = true;
            cboFilterCategory.Location = new Point(94, 10);
            cboFilterCategory.Name = "cboFilterCategory";
            cboFilterCategory.Size = new Size(151, 28);
            cboFilterCategory.TabIndex = 1;
            cboFilterCategory.SelectedIndexChanged += Filter_Changed;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Category: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 14);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(581, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 7;
            label3.Text = "From:";
            label3.Click += label3_Click;
            // 
            // chkDateRange
            // 
            chkDateRange.AutoSize = true;
            chkDateRange.Location = new Point(470, 14);
            chkDateRange.Name = "chkDateRange";
            chkDateRange.Size = new Size(105, 24);
            chkDateRange.TabIndex = 4;
            chkDateRange.Text = "Date range";
            chkDateRange.UseVisualStyleBackColor = true;
            chkDateRange.CheckedChanged += chkDateRange_CheckedChanged;
            // 
            // dtpTo
            // 
            dtpTo.Enabled = false;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(718, 23);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(131, 27);
            dtpTo.TabIndex = 6;
            dtpTo.ValueChanged += Filter_Changed;
            // 
            // dtpFrom
            // 
            dtpFrom.Enabled = false;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(581, 23);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(131, 27);
            dtpFrom.TabIndex = 5;
            dtpFrom.ValueChanged += Filter_Changed;
            // 
            // pnlSummary
            // 
            pnlSummary.Controls.Add(nudBudget);
            pnlSummary.Controls.Add(lblRemaining);
            pnlSummary.Controls.Add(label7);
            pnlSummary.Controls.Add(lblTotal);
            pnlSummary.Controls.Add(lblRecords);
            pnlSummary.Dock = DockStyle.Bottom;
            pnlSummary.Location = new Point(0, 467);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(892, 60);
            pnlSummary.TabIndex = 4;
            // 
            // nudBudget
            // 
            nudBudget.DecimalPlaces = 2;
            nudBudget.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudBudget.Location = new Point(486, 17);
            nudBudget.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBudget.Name = "nudBudget";
            nudBudget.Size = new Size(150, 27);
            nudBudget.TabIndex = 4;
            nudBudget.ThousandsSeparator = true;
            nudBudget.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            nudBudget.ValueChanged += nudBudget_ValueChanged;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemaining.Location = new Point(662, 19);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(156, 20);
            lblRemaining.TabIndex = 3;
            lblRemaining.Text = "Remaining: PHP 0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(362, 19);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 2;
            label7.Text = "Monthly budget:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(187, 19);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(107, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: PHP 0.00";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Location = new Point(12, 19);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(77, 20);
            lblRecords.TabIndex = 0;
            lblRecords.Text = "Records: 0";
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Dock = DockStyle.Fill;
            dgvExpenses.Location = new Point(0, 105);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(892, 362);
            dgvExpenses.TabIndex = 5;
            dgvExpenses.CellContentClick += dgvExpenses_CellContentClick;
            dgvExpenses.CellDoubleClick += dgvExpenses_CellDoubleClick;
            dgvExpenses.DataBindingComplete += dgvExpenses_DataBindingComplete;
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 553);
            Controls.Add(dgvExpenses);
            Controls.Add(pnlSummary);
            Controls.Add(pnlFilter);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 500);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpenseTracker";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            Shown += frmMain_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem expenseToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbDelete;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblRecordCount;
        private Panel pnlFilter;
        private TextBox txtSearch;
        private Label label2;
        private ComboBox cboFilterCategory;
        private Label label1;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private CheckBox chkDateRange;
        private Panel pnlSummary;
        private NumericUpDown nudBudget;
        private Label lblRemaining;
        private Label label7;
        private Label lblTotal;
        private Label lblRecords;
        private DataGridView dgvExpenses;
        private System.Windows.Forms.Timer tmrClock;
        private ToolStripStatusLabel lblClock;
    }
}
