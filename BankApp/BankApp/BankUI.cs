using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class BankUI : Form
    {
        private Customer aCustomer;

        public BankUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Account anAccount = new Account(accountNumberEntryTextBox.Text, openingEntryTextBox.Text);
            aCustomer = new Customer();

            aCustomer.CustomerName = customerNameEntryTextBox.Text;
            aCustomer.Email = emailEntryTextBox.Text;
            aCustomer.AnAccount = anAccount;
            MessageBox.Show("Account has been created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            aCustomer.AnAccount.Deposit(amount);
            MessageBox.Show("Deposited");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            aCustomer.AnAccount.Withdraw(amount);
            MessageBox.Show("Withdrawn");
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            accountNumberDisplayTextBox.Text = aCustomer.AnAccount.Number;
            customerNameDisplayTextBox.Text = aCustomer.CustomerName;
            emailDisplayTextBox.Text = aCustomer.Email;
            balanceTextBox.Text = aCustomer.AnAccount.Balance.ToString();
            openingDateDisplayTextBox.Text = aCustomer.AnAccount.OpeningDate;
        }
    }
}
