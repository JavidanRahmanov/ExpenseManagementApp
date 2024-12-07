namespace ExpenseManagementApp
{
    partial class MainForm
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
            this.cmbExpenseType = new System.Windows.Forms.ComboBox();
            this.btnAddExpenseType = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSaveExpense = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.ExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbExpenseType
            // 
            this.cmbExpenseType.FormattingEnabled = true;
            this.cmbExpenseType.Location = new System.Drawing.Point(12, 166);
            this.cmbExpenseType.Name = "cmbExpenseType";
            this.cmbExpenseType.Size = new System.Drawing.Size(121, 24);
            this.cmbExpenseType.TabIndex = 0;
            // 
            // btnAddExpenseType
            // 
            this.btnAddExpenseType.Location = new System.Drawing.Point(139, 167);
            this.btnAddExpenseType.Name = "btnAddExpenseType";
            this.btnAddExpenseType.Size = new System.Drawing.Size(39, 23);
            this.btnAddExpenseType.TabIndex = 1;
            this.btnAddExpenseType.Text = "...";
            this.btnAddExpenseType.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(12, 227);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // btnSaveExpense
            // 
            this.btnSaveExpense.Location = new System.Drawing.Point(28, 301);
            this.btnSaveExpense.Name = "btnSaveExpense";
            this.btnSaveExpense.Size = new System.Drawing.Size(150, 23);
            this.btnSaveExpense.TabIndex = 3;
            this.btnSaveExpense.Text = "Yadda saxla";
            this.btnSaveExpense.UseVisualStyleBackColor = true;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(495, 131);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowHeadersWidth = 51;
            this.dgvExpenses.RowTemplate.Height = 24;
            this.dgvExpenses.Size = new System.Drawing.Size(240, 150);
            this.dgvExpenses.TabIndex = 4;
            // 
            // ExpenseDate
            // 
            this.ExpenseDate.Location = new System.Drawing.Point(12, 117);
            this.ExpenseDate.Name = "ExpenseDate";
            this.ExpenseDate.Size = new System.Drawing.Size(200, 22);
            this.ExpenseDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xos geldin";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpenseDate);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.btnSaveExpense);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnAddExpenseType);
            this.Controls.Add(this.cmbExpenseType);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbExpenseType;
        private System.Windows.Forms.Button btnAddExpenseType;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSaveExpense;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DateTimePicker ExpenseDate;
        private System.Windows.Forms.Label label1;
    }
}