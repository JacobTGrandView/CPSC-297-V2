using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer newBankAccount;

        // Button event handler for creating account
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text;
            double balance;
            int number;

            // Account name has to be a string. return message if not
            if (!accountName.All(char.IsLetter))  
            {
                MessageBox.Show("Enter your full name");
                return;
            }

            // Account number has to be numeric. return message if not
            if (!int.TryParse(txtNumber.Text, out number))
            {
                MessageBox.Show("Account number must be numeric");
                return;
            }

            // Account balance has to be numeric. return message if not
            if (!double.TryParse(txtBalance.Text, out balance))
            {
                MessageBox.Show("Account balance must be numeric");
                return;
            }

            // New Customer object representing the account
            newBankAccount = new Customer(accountName, number, balance);
            MessageBox.Show("Account created successfully");
            btnUpdateAccount.Enabled = true;
        }

        // Update button for withdraw and deposit
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            double amount;
            if (!double.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Amount must be a numeric value");
                return;
            }

            // If deposit box is selected
            if (rbDeposit.Checked)
            {
                newBankAccount.Deposit(amount);
            }

            // If withdraw box is selected
            else
            {
                newBankAccount.Withdraw(amount);
            }

            // The balance label is updated with new amount
            txtBalance.Text = newBankAccount.Balance.ToString();

            // Display the new balance after updating
            newBankAccount.DisplayCurrentBalance();
        }
    }
}


// Customer class
public class Customer
{
    private string accountName;
    private int number;
    private double balance;

    // Access account details
    public string AccountName
    {
        get { return accountName; }
        set { accountName = value; }
    }

    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    // Initialize account details
    public Customer(string accountName, int number, double balance)
    {
        this.accountName = accountName;
        this.number = number;
        this.balance = balance;
    }

    // Deposit method
    public void Deposit(double amount)
    {
        balance += amount;
        MessageBox.Show("Succesfully deposited to account number: " + number.ToString());
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            MessageBox.Show("Successfully withdrew from account number: " + number.ToString());
        }
    }

    // Display the balance after depositing or withdrawing
    public void DisplayCurrentBalance()
    {
        // "C" stands for currency
        MessageBox.Show("Current balance of account number " + number.ToString() + " is: " + balance.ToString("C"));
    }
}