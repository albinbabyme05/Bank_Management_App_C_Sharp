# BankAccountAPP

echo "Description
BankApp is a simple Windows Forms application that allows users to create bank accounts, deposit money, and withdraw money. This application manages user accounts by maintaining a list of BankAccount objects and provides functionality to interact with these accounts through a GUI. Users can view their balances, make deposits, and withdraw funds within specified limits.

Features
Create Account: Allows the user to create a bank account by providing a username.

Deposit: Enables users to deposit money into their account. There are deposit limits enforced.

Withdraw: Allows users to withdraw money from their account. Withdrawals are also subject to limits.

Data Grid View: Displays the list of all bank accounts, showing the account owner, account number, and balance.

Validation: Enforces rules for deposit and withdrawal amounts, ensuring they are within the allowed limits.

Technologies
.NET Framework: Uses Windows Forms for the GUI.

C#: The application is written in C#.

Microsoft Visual Basic Application Services: For application services in Windows Forms.

Components
Form1 Class
The main form (Form1) handles the user interface and interactions:

CreateAccountBtn_Click: Handles the account creation process by adding a new BankAccount object to the list.

DepositBtn_Click: Handles the deposit logic, ensuring the user selects an account and enters a valid amount.

WithdrawBtn_Click: Handles the withdrawal logic, verifying account selection and available balance.

BankAccount Class
The BankAccount class models a bank account:

Owner: The name of the account owner (user).

AccountNumber: A unique identifier for each account (using GUID).

Balance: The current balance of the account.

Methods for the BankAccount class:

ValidateDeposit: Validates the deposit amount and updates the balance if valid.

Validatewithdraw: Validates the withdrawal amount, ensuring it's within the allowed limit and that there is sufficient balance.

Getting Started
Prerequisites
To run the application, you need the following:

Microsoft Visual Studio with Windows Forms support.

.NET Framework (compatible with the version you're using).

Installation Steps
Clone the repository or download the source files.

Open the solution in Visual Studio.

Build the project by selecting Build > Build Solution.

Run the application by pressing F5 or selecting Debug > Start Debugging.

Usage
Create an Account: Enter a username in the input field and click 'Create Account.'

Deposit Money: Select an account from the grid, enter an amount, and click 'Deposit.' The amount will be added to the balance if it meets the validation rules.

Withdraw Money: Select an account, enter the amount to withdraw, and click 'Withdraw.' The amount will be deducted from the balance if sufficient funds are available and the amount is within the withdrawal limit.

Limitations
Deposit limit: Maximum deposit amount is 20,000 EUR.

Withdrawal limit: Maximum withdrawal amount is 5,000 EUR.

If the balance is insufficient for a withdrawal, an error message will appear.

Contributing
If you'd like to contribute to the development of this application:

Fork the repository.

Create a new branch for your changes.

Commit your changes and push them to your fork.

Open a pull request to merge changes into the main repository.

License
This project is licensed under the MIT License - see the LICENSE file for details." > README.txt
