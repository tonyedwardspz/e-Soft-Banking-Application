using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_SoftBankingApplication
{
    public partial class frmAddNewAccount : Form
    {
        public frmAddNewAccount()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountCreationDate.Text = "";
            txtAccountNickName.Text = "";
            txtAccountNumber.Text = "";
            txtAccountSortcode.Text = "";
            txtOpeningBalance.Text = "";
            txtOverdraftLimit.Text = "";
            txtAccountNickName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmViewCustAccounts.keepCustAccount.Show();
        }

        private void frmAddNewAccount_Load(object sender, EventArgs e)
        {
            int selectedCust = frmBank.custSelected;

            //Get the Customer array.
            ArrayList allCustomers = frmBank.customers;

            //Navigate to the selected customer
            Customer currentCustomer = (Customer)allCustomers[selectedCust];

            //Auto fill fields
            txtAccountNumber.Text = Utilities.generateAccountNumber();
            txtAccountCreationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtAccountSortcode.Text = "560063";

            //Display customer details
            lblCustId.Text = "Customer ID: " + currentCustomer.getCustID();
            lblCustName.Text = "Customer Name: " + currentCustomer.getFullName();

            txtAccountNickName.Focus();
        }

        private void btnSaveNewAccount_Click(object sender, EventArgs e)
        {
            bool allInputOk = false;
            bool allNumbersOK = false;

            //Navigate to correct Account
            Customer whichCustomer = (Customer)frmBank.customers[frmBank.custSelected];
            ArrayList thisCustomersAccounts = whichCustomer.getCustAllAccounts();

            //Data order - Nickname, Sortcode, ACC No, opening date, current Balance, overdraft.
            string tempAccName = txtAccountNickName.Text;
            string tempAccSortCode = txtAccountSortcode.Text;
            string tempAccNumber = txtAccountNumber.Text;
            string tempAccCreationDate = txtAccountCreationDate.Text;
            string tempAccBalance = txtOpeningBalance.Text;
            string tempAccOverdraftLimit = txtOverdraftLimit.Text;

            Validation.validateFormInput(ref allInputOk, ref allNumbersOK);

            if (allNumbersOK && allInputOk)
            {
                int testBalance = Convert.ToInt32(tempAccBalance);
                if (testBalance >= 100)
                {
                    Utilities.addNewAccountToCustomer(whichCustomer, tempAccName, tempAccSortCode, tempAccNumber, tempAccCreationDate, tempAccBalance, tempAccOverdraftLimit);

                    //Close the form
                    frmViewCustAccounts tempViewCustomer = new frmViewCustAccounts();
                    tempViewCustomer.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: Account balance must be over 100");
                }
            }
            else
            {
                txtAccountNickName.Focus();
            }
        }

        private void validateFormInput(ref bool allInputOk, ref bool allNumbersOK)
        {
            //Validate the input
            allInputOk = Validation.notNullTextBox(txtAccountCreationDate, "Account Creation Date") && Validation.notNullTextBox(txtAccountNickName, "Account Nickname") &&
                         Validation.notNullTextBox(txtAccountNumber, "Account Number") && Validation.notNullTextBox(txtAccountSortcode, "Sort Code") &&
                         Validation.notNullTextBox(txtOpeningBalance, "Opening Balance") && Validation.notNullTextBox(txtOverdraftLimit, "Overdraft Limit");

            //Check the opening balance is over £100 && if inputs are valid
            allNumbersOK = Validation.testForInt(txtAccountNumber, "account number") && Validation.testForInt(txtAccountSortcode, "sortcode") &&
                           Validation.testForInt(txtOpeningBalance, "opening balance") && Validation.testForInt(txtOverdraftLimit, "overdraft");
        }
    }
}
