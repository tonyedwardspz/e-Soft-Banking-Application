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
    public partial class frmNewCustomer : Form
    {
        public static frmNewCustomer keepNewCustomer = null;

        public frmNewCustomer()
        {
            InitializeComponent();
            keepNewCustomer = this;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBank.keepBank.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnSaveNewCust_Click(object sender, EventArgs e)
        {
            bool allInputOK = false;

            //get the inputs
            string ID = txtCustID.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string houseNumberName = txtHouseNameNumber.Text;
            string street = txtStreetName.Text;
            string city = txtCityOrTown.Text;
            string postCode = txtPostcode.Text;
            string password = txtPassword.Text;

            //Check inputs are valid
            allInputOK = (Validation.notNullTextBox(txtCustID, "CustomerID") && Validation.notNullTextBox(txtFirstName, "First Name") && Validation.notNullTextBox(txtLastName, "Last Name") &&
                          Validation.notNullTextBox(txtHouseNameNumber, "House Name / Number") && Validation.notNullTextBox(txtStreetName, "Street Name") &&
                          Validation.notNullTextBox(txtCityOrTown, "City") && Validation.notNullTextBox(txtPostcode, "Postcode") && Validation.notNullTextBox(txtPassword, "Password"));

            //Create New Customer
            // ID - First - Last - HouseNo - Street - City - PostCode - Password - NumAcc
            if (allInputOK)
            {
                try
                {
                    Customer tempCustomer = new Customer(ID, firstName, lastName, houseNumberName, street, city, postCode, password);
                    frmBank.customers.Add(tempCustomer);
                    Utilities.writeDataOut(frmBank.inputCustFile, frmBank.customers);

                    MessageBox.Show("Customer successfully created");
                    updateSelectedCustomer();
                    openNewAccount();
                }
                catch (FormatException e2)
                {
                    MessageBox.Show("Error: Customer details are invalid \n" + e2.Message);
                }
            }

            
        }

        private static void openNewAccount()
        {
            //Open the new account form
            frmAddNewAccount tempNewAccount = new frmAddNewAccount();
            tempNewAccount.Show();
            keepNewCustomer.Hide();
        }

        private static void updateSelectedCustomer()
        {
            //Update the selected customer
            Utilities.readDataFile(frmBank.inputCustFile, frmBank.customers);

            //Navigate to the selected customer
            ArrayList allCustomers = frmBank.customers;

            frmBank.custSelected = allCustomers.Count - 1;
            Customer currentCustomer = (Customer)allCustomers[frmBank.custSelected];
        }
        private void resetForm()
        {
            txtCityOrTown.Text = "";
            txtCustID.Text = "";
            txtFirstName.Text = "";
            txtHouseNameNumber.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtPostcode.Text = "";
            txtStreetName.Text = "";
            txtCustID.Focus();
        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            txtCustID.Text=Utilities.generateCustomerNumber();
            txtFirstName.Focus();
        }
    }
}
