namespace BankAccountAPP
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateUserBtn = new Button();
            EnterUserNameTxt = new TextBox();
            UserEnteredAmount = new NumericUpDown();
            label3 = new Label();
            UserInterestRate = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserEnteredAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserInterestRate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(-1, 23);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "User Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 384);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(367, 12);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(421, 347);
            BankAccountsGrid.TabIndex = 2;
            // 
            // DepositBtn
            // 
            DepositBtn.Font = new Font("Segoe UI", 12F);
            DepositBtn.Location = new Point(385, 365);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(164, 47);
            DepositBtn.TabIndex = 3;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Font = new Font("Segoe UI", 12F);
            WithdrawBtn.Location = new Point(597, 365);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(164, 47);
            WithdrawBtn.TabIndex = 4;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateUserBtn
            // 
            CreateUserBtn.Font = new Font("Segoe UI", 12F);
            CreateUserBtn.Location = new Point(154, 131);
            CreateUserBtn.Name = "CreateUserBtn";
            CreateUserBtn.Size = new Size(196, 51);
            CreateUserBtn.TabIndex = 5;
            CreateUserBtn.Text = "Create Account";
            CreateUserBtn.UseVisualStyleBackColor = true;
            CreateUserBtn.Click += CreateUserBtn_Click;
            // 
            // EnterUserNameTxt
            // 
            EnterUserNameTxt.Font = new Font("Segoe UI", 16F);
            EnterUserNameTxt.Location = new Point(154, 13);
            EnterUserNameTxt.Name = "EnterUserNameTxt";
            EnterUserNameTxt.Size = new Size(196, 43);
            EnterUserNameTxt.TabIndex = 6;
            // 
            // UserEnteredAmount
            // 
            UserEnteredAmount.Font = new Font("Segoe UI", 16F);
            UserEnteredAmount.Location = new Point(121, 369);
            UserEnteredAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            UserEnteredAmount.Name = "UserEnteredAmount";
            UserEnteredAmount.Size = new Size(196, 43);
            UserEnteredAmount.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(-1, 82);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 8;
            label3.Text = "Interest Rate(%) :";
            // 
            // UserInterestRate
            // 
            UserInterestRate.Font = new Font("Segoe UI", 16F);
            UserInterestRate.Location = new Point(154, 73);
            UserInterestRate.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            UserInterestRate.Name = "UserInterestRate";
            UserInterestRate.Size = new Size(196, 43);
            UserInterestRate.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserInterestRate);
            Controls.Add(label3);
            Controls.Add(UserEnteredAmount);
            Controls.Add(EnterUserNameTxt);
            Controls.Add(CreateUserBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserEnteredAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserInterestRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateUserBtn;
        private TextBox EnterUserNameTxt;
        private NumericUpDown UserEnteredAmount;
        private Label label3;
        private NumericUpDown UserInterestRate;
    }
}
