namespace ExpenseTracker
{
    partial class xpenseTrcker
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
            txtExpenseName = new TextBox();
            txtExpenseCost = new TextBox();
            btnSumit = new Button();
            lblXpenseName = new Label();
            lblXpenseCost = new Label();
            lblTotalExpenses = new Label();
            dgvExpense = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            bttnRemoveExpense = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
            SuspendLayout();
            // 
            // txtExpenseName
            // 
            txtExpenseName.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtExpenseName.Location = new Point(62, 137);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(362, 25);
            txtExpenseName.TabIndex = 0;
            txtExpenseName.TextChanged += txtExpenseName_TextChanged;
            // 
            // txtExpenseCost
            // 
            txtExpenseCost.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Italic);
            txtExpenseCost.Location = new Point(62, 254);
            txtExpenseCost.Name = "txtExpenseCost";
            txtExpenseCost.Size = new Size(362, 25);
            txtExpenseCost.TabIndex = 1;
            txtExpenseCost.TextChanged += txtExpenseCost_TextChanged;
            // 
            // btnSumit
            // 
            btnSumit.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSumit.Location = new Point(109, 349);
            btnSumit.Name = "btnSumit";
            btnSumit.Size = new Size(146, 30);
            btnSumit.TabIndex = 2;
            btnSumit.Text = "Summit Expense";
            btnSumit.UseVisualStyleBackColor = true;
            btnSumit.Click += btnSumit_Click;
            // 
            // lblXpenseName
            // 
            lblXpenseName.AutoSize = true;
            lblXpenseName.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblXpenseName.Location = new Point(158, 80);
            lblXpenseName.Name = "lblXpenseName";
            lblXpenseName.Size = new Size(153, 24);
            lblXpenseName.TabIndex = 4;
            lblXpenseName.Text = "Expense Name ";
            // 
            // lblXpenseCost
            // 
            lblXpenseCost.AutoSize = true;
            lblXpenseCost.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblXpenseCost.Location = new Point(158, 201);
            lblXpenseCost.Name = "lblXpenseCost";
            lblXpenseCost.Size = new Size(137, 24);
            lblXpenseCost.TabIndex = 5;
            lblXpenseCost.Text = "Expense Cost ";
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalExpenses.Location = new Point(568, 83);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(142, 21);
            lblTotalExpenses.TabIndex = 6;
            lblTotalExpenses.Text = "Total Expenses";
            // 
            // dgvExpense
            // 
            dgvExpense.AllowUserToAddRows = false;
            dgvExpense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpense.BackgroundColor = SystemColors.ActiveCaption;
            dgvExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense.Columns.AddRange(new DataGridViewColumn[] { colDate, colDescription, colAmount });
            dgvExpense.Location = new Point(449, 137);
            dgvExpense.Name = "dgvExpense";
            dgvExpense.ReadOnly = true;
            dgvExpense.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpense.Size = new Size(318, 150);
            dgvExpense.TabIndex = 7;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Amount ";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(532, 326);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "label1";
            // 
            // bttnRemoveExpense
            // 
            bttnRemoveExpense.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bttnRemoveExpense.Location = new Point(320, 354);
            bttnRemoveExpense.Name = "bttnRemoveExpense";
            bttnRemoveExpense.Size = new Size(75, 23);
            bttnRemoveExpense.TabIndex = 9;
            bttnRemoveExpense.Text = "Remove Expense";
            bttnRemoveExpense.UseVisualStyleBackColor = true;
            bttnRemoveExpense.Click += bttnRemoveExpense_Click;
            


            // 
            // xpenseTrcker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnRemoveExpense);
            Controls.Add(lblTotal);
            Controls.Add(dgvExpense);
            Controls.Add(lblTotalExpenses);
            Controls.Add(lblXpenseCost);
            Controls.Add(lblXpenseName);
            Controls.Add(btnSumit);
            Controls.Add(txtExpenseCost);
            Controls.Add(txtExpenseName);
            Name = "xpenseTrcker";
            Text = "Expense Tracker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExpenseName;
        private TextBox txtExpenseCost;
        private Button btnSumit;
        private DataGridView dgvExpense;
        private Label lblXpenseName;
        private Label lblXpenseCost;
        private Label lblTotalExpenses;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colAmount;
        private Label lblTotal;
        private Button bttnRemoveExpense;
    }
}
