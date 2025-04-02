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

        private void CreateAccountBtn_Click(object sender, EventArgs e)
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
    }
}
