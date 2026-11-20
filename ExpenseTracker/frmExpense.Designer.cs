namespace ExpenseTracker
{
    partial class frmExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dtpDate = new DateTimePicker();
            txtDescription = new TextBox();
            cboCategory = new ComboBox();
            nudAmount = new NumericUpDown();
            grpPayment = new GroupBox();
            rdoCash = new RadioButton();
            rdoGCash = new RadioButton();
            rdoCard = new RadioButton();
            chkRecurring = new CheckBox();
            txtNotes = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            errProvider = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            grpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(14, 32);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 0;
            dtpDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(14, 85);
            txtDescription.MaxLength = 50;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 34);
            txtDescription.TabIndex = 1;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(14, 145);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(151, 28);
            cboCategory.TabIndex = 2;
            // 
            // nudAmount
            // 
            nudAmount.DecimalPlaces = 2;
            nudAmount.Location = new Point(15, 199);
            nudAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(150, 27);
            nudAmount.TabIndex = 3;
            // 
            // grpPayment
            // 
            grpPayment.Controls.Add(rdoCash);
            grpPayment.Controls.Add(rdoGCash);
            grpPayment.Controls.Add(rdoCard);
            grpPayment.Location = new Point(15, 232);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new Size(250, 125);
            grpPayment.TabIndex = 4;
            grpPayment.TabStop = false;
            grpPayment.Text = "Payment";
            // 
            // rdoCash
            // 
            rdoCash.AutoSize = true;
            rdoCash.Checked = true;
            rdoCash.Location = new Point(10, 26);
            rdoCash.Name = "rdoCash";
            rdoCash.Size = new Size(61, 24);
            rdoCash.TabIndex = 5;
            rdoCash.TabStop = true;
            rdoCash.Text = "Cash";
            rdoCash.UseVisualStyleBackColor = true;
            // 
            // rdoGCash
            // 
            rdoGCash.AutoSize = true;
            rdoGCash.Location = new Point(6, 56);
            rdoGCash.Name = "rdoGCash";
            rdoGCash.Size = new Size(71, 24);
            rdoGCash.TabIndex = 6;
            rdoGCash.Text = "GCash";
            rdoGCash.UseVisualStyleBackColor = true;
            // 
            // rdoCard
            // 
            rdoCard.AutoSize = true;
            rdoCard.Location = new Point(6, 86);
            rdoCard.Name = "rdoCard";
            rdoCard.Size = new Size(61, 24);
            rdoCard.TabIndex = 7;
            rdoCard.Text = "Card";
            rdoCard.UseVisualStyleBackColor = true;
            // 
            // chkRecurring
            // 
            chkRecurring.AutoSize = true;
            chkRecurring.Location = new Point(14, 363);
            chkRecurring.Name = "chkRecurring";
            chkRecurring.Size = new Size(94, 24);
            chkRecurring.TabIndex = 8;
            chkRecurring.Text = "Recurring";
            chkRecurring.UseVisualStyleBackColor = true;
            chkRecurring.CheckedChanged += chkRecurring_CheckedChanged;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(15, 413);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(250, 58);
            txtNotes.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(296, 482);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(196, 482);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 12;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 62);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 13;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 122);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 14;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 176);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 15;
            label4.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 390);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 16;
            label5.Text = "Notes";
            label5.Click += label5_Click;
            // 
            // frmExpense
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(402, 523);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboCategory);
            Controls.Add(label2);
            Controls.Add(nudAmount);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtNotes);
            Controls.Add(chkRecurring);
            Controls.Add(grpPayment);
            Controls.Add(txtDescription);
            Controls.Add(dtpDate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmExpense";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Expense";
            Load += frmExpense_Load;
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private TextBox txtDescription;
        private ComboBox cboCategory;
        private NumericUpDown nudAmount;
        private GroupBox grpPayment;
        private RadioButton rdoCash;
        private RadioButton rdoGCash;
        private RadioButton rdoCard;
        private CheckBox chkRecurring;
        private TextBox txtNotes;
        private Button btnCancel;
        private Button btnSave;
        private ErrorProvider errProvider;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}