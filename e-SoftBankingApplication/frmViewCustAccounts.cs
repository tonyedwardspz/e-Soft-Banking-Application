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
    public partial class frmViewCustAccounts : Form
    {
        public int accountSelected = -1;
        public static frmViewCustAccounts keepCustAccount = null;

        public frmViewCustAccounts()
        {
            InitializeComponent();
            keepCustAccount = this;
        }

        private void frmViewCustAccounts_Load(object sender, EventArgs e)
        {
            getCustDetails();
        }

        private void getCustDetails()
        {
            //Get the reference to the selected customer.
            int selectedCust = frmBank.custSelected;

            //Navigate to the selected customer
            ArrayList allCustomers = frmBank.customers;
            Customer currentCustomer = (Customer)allCustomers[selectedCust];

            //Fill in the customer details
            // ID - First - Last - HouseNo - Street - City - PostCode - Password - NumAcc
            lblOutputCustID.Text = "ID: " + currentCustomer.getCustID();
            txtFirstName.Text = currentCustomer.getCustFirstName();
            txtLastName.Text = currentCustomer.getCustLastName();
            txtHouseNameNumber.Text = currentCustomer.getCustHouseNameNumber();
            txtStreetName.Text = currentCustomer.getCustStreet();
            txtCityOrTown.Text = currentCustomer.getCustCityTown();
            txtPostcode.Text = currentCustomer.getCustPostCode();

            //List the customers accounts
            string output;

            lstListCustomerAccounts.Items.Clear();

            for (int i = 0; i <= currentCustomer.getNumberAccounts(); i++)
            {
                Account currentAccount = (Account)currentCustomer.getCustAllAccounts()[i];

                output = "Account Name: " + currentAccount.getAccountName();
                lstListCustomerAccounts.Items.Add(output);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Utilities.showListOfCustomers(frmBank.mainPadeSearchBox);
            frmBank.keepBank.Show();
            this.Close();
        }

        private void lstListCustomerAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change account selection
            accountSelected = lstListCustomerAccounts.SelectedIndex;

            //Navigate to the selected customer
            ArrayList allCustomers = frmBank.customers;
            Customer currentCustomer = (Customer)allCustomers[frmBank.custSelected];

            //Navigate to the selected account
            Account currentAccount = (Account)currentCustomer.getCustAllAccounts()[accountSelected];

            //display account details
            txtAccountNumber.Text = currentAccount.getAccountNumber().ToString();
            txtBalance.Text = currentAccount.getAccountBalance().ToString("C");
            txtOpeningDate.Text = currentAccount.getAccountCreationDate();
            txtOverdraftLimit.Text = currentAccount.getOverDraftLimit().ToString("C");
            txtSortcode.Text = currentAccount.getAccountSortcode().ToString();
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            frmAddNewAccount tempNewAccount = new frmAddNewAccount();
            tempNewAccount.Show();
            keepCustAccount.Hide();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            int selectedCust = frmBank.custSelected;

            //Navigate to the selected array
            ArrayList allCustomers = frmBank.customers;
            Customer currentCustomer = (Customer)allCustomers[selectedCust];
            
            txtPassword.Text = currentCustomer.getPassword();

            enableCustomerEdits();
        }

        //Save customer edits, checking for null text boxes
        private void btnSaveEdits_Click(object sender, EventArgs e)
        {
            bool allInputOK = false;

            //Navigate to the customer
            ArrayList allCustomers = frmBank.customers;
            Customer currentCustomer = (Customer)allCustomers[frmBank.custSelected];

            string ID = currentCustomer.getCustID();
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string houseNumberName = txtHouseNameNumber.Text;
            string street = txtStreetName.Text;
            string city = txtCityOrTown.Text;
            string postCode = txtPostcode.Text;
            string password = txtPassword.Text;

            allInputOK = (Validation.notNullTextBox(txtCityOrTown, "city / town") && Validation.notNullTextBox(txtFirstName, "first name") && 
                          Validation.notNullTextBox(txtHouseNameNumber, "house name / number") && Validation.notNullTextBox(txtLastName, "last name") && 
                          Validation.notNullTextBox(txtPostcode, "postcode") && Validation.notNullTextBox(txtStreetName, "street name")) && 
                          Validation.notNullTextBox(txtPassword, "password");

            if (allInputOK)
            {
                Utilities.saveCustomerDetails(currentCustomer, ID, firstName, lastName, houseNumberName, street, city, postCode, password);
            }           
        }


        //Delete the account if the balance is zero.
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            double balance = 0;

            //Navigate to the customer.
            ArrayList allCustomers = frmBank.customers;
            Customer currentCustomer = (Customer)allCustomers[frmBank.custSelected];

            //Navigate to the selected account
            ArrayList accountToBeDeleted = currentCustomer.getCustAllAccounts();
            try
            {
                Account currentAccount = (Account)currentCustomer.getCustAllAccounts()[accountSelected];
                balance = currentAccount.getAccountBalance();
            }
            catch (FormatException e2)
            {
                MessageBox.Show("Error: Customer details are invalid \n" + e2.Message);
            }

            //Test the account balance and delete
             

            if (balance == 0)
            {
                deleteAccount(currentCustomer, accountToBeDeleted);

                MessageBox.Show("Account successfully deleted");
            }
            else
            {
                MessageBox.Show("Error: Account balance must be zero to close account");

            }

            accountSelected--;
            updateAccountList(currentCustomer);
        }

        private void deleteAccount(Customer currentCustomer, ArrayList accountToBeDeleted)
        {
            //Update the number of account
            int numAccounts = currentCustomer.getNumberAccounts();
            numAccounts--;
            currentCustomer.setNumberAccounts(numAccounts);

            //Delete the account, save new account list & update .txt file
            accountToBeDeleted.RemoveAt(accountSelected);
            currentCustomer.setCustAllAccounts(accountToBeDeleted);
            Utilities.writeDataOut(frmBank.inputCustFile, frmBank.customers);
        }

        //Refresh the account list
        private void updateAccountList(Customer currentCustomer)
        {
            foreach (Account customerAccounts in currentCustomer.getCustAllAccounts())
            {
                ArrayList accountToBeChecked = currentCustomer.getCustAllAccounts();

                lstListCustomerAccounts.Items.Clear();
                if (accountToBeChecked.Count == 0)
                {
                    lstListCustomerAccounts.Items.Add(customerAccounts.getAccountName());
                }
            }
        }




        public void enableCustomerEdits()
        {
            //Enable text boxes etc
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtCityOrTown.ReadOnly = false;
            txtHouseNameNumber.ReadOnly = false;
            txtStreetName.ReadOnly = false;
            btnSaveEdits.Visible = true;
            btnClearChanges.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;


            //disable other elements
            btnDeleteCustomer.Enabled = false;
            btnAddNewAccount.Enabled = false;
            btnExit.Enabled = false;
            btnDeleteAccount.Enabled = false;
            lstListCustomerAccounts.Enabled = false;
            txtAccountNumber.Enabled = false;
            btnEditCustomer.Enabled = false;
        }

        public void disableCustomerEdits()
        {
            //Enable text boxes etc
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtPostcode.ReadOnly = true;
            txtCityOrTown.ReadOnly = true;
            txtHouseNameNumber.ReadOnly = true;
            txtStreetName.ReadOnly = true;
            btnSaveEdits.Visible = false;
            btnClearChanges.Visible = false;
            lblPassword.Visible = false;
            txtPassword.Visible = false;

            //disable other elements
            btnDeleteCustomer.Enabled = true;
            btnAddNewAccount.Enabled = true;
            btnExit.Enabled = true;
            btnDeleteAccount.Enabled = true;
            lstListCustomerAccounts.Enabled = true;
            btnEditCustomer.Enabled = true;
        }

        private void clearChanges_Click(object sender, EventArgs e)
        {
            //Navigate to the selected customer
            ArrayList allCustomers = frmBank.customers;
            Customer currentCustomer = (Customer)allCustomers[frmBank.custSelected];


            //Fill in the customer details
            // ID - First - Last - HouseNo - Street - City - PostCode - Password - NumAcc
            lblOutputCustID.Text = "ID: " + currentCustomer.getCustID();
            txtFirstName.Text = currentCustomer.getCustFirstName();
            txtLastName.Text = currentCustomer.getCustLastName();
            txtHouseNameNumber.Text = currentCustomer.getCustHouseNameNumber();
            txtStreetName.Text = currentCustomer.getCustStreet();
            txtCityOrTown.Text = currentCustomer.getCustCityTown();
            txtPostcode.Text = currentCustomer.getCustPostCode();

            disableCustomerEdits();
        }

        //Delete the customer if they have no accounts
        private void btnDeleteCoustomer_Click_1(object sender, EventArgs e)
        {
            int selectedCust = frmBank.custSelected;

            //Navigate to the selected customer
            ArrayList allCustomers = frmBank.customers;
            Customer currentCustomer = (Customer)allCustomers[selectedCust];

            //Get the array of accounts
            ArrayList accountToBeChecked = currentCustomer.getCustAllAccounts();

            //If customer has no accounts, delete
            if (accountToBeChecked.Count == 0)
            {
                Utilities.deleteCustomer(selectedCust);
                frmBank.keepBank.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Not all accounts have a balance of zero");
            }
        }
    }
}
