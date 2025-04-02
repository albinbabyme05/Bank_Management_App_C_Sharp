using BankApp;

namespace BankAccountAPP
{
    public partial class Form1 : Form
    {
        //to view the data in the dataGrid - make global to access different class/ mthods events
        List<BankAccount> bankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            // 1.checking the userName exists or not 
            if (string.IsNullOrEmpty(EnterUserNameTxt.Text))
            {
                return;
            }


            //2. if a userName,creating a object
            BankAccount newUser = new BankAccount(EnterUserNameTxt.Text);
            bankAccounts.Add(newUser);
            RefreshGrid();

            //clear the field after the userName entry
            EnterUserNameTxt.Text = string.Empty; //UserNameTxt.Text = "";
        }
        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = bankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            //D1. checking the only one row is selected and amount entered >0
            if (BankAccountsGrid.SelectedRows.Count == 1 && UserEnteredAmount.Value > 0)
            {
                // D2. to get the selected row access
                BankAccount selectedUser = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedUser.ValidateDeposit(UserEnteredAmount.Value);

                RefreshGrid();
                UserEnteredAmount.Value = 0;
                MessageBox.Show(message);

            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            //W1. checking one row is selected and the amount entered > 0
            if (BankAccountsGrid.SelectedRows.Count == 1 && UserEnteredAmount.Value > 0)
            {
                BankAccount selectedUser = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedUser.Validatewithdraw(UserEnteredAmount.Value);

                RefreshGrid();
                UserEnteredAmount.Value = 0;
                MessageBox.Show(message);
            }
        }
    }
}
