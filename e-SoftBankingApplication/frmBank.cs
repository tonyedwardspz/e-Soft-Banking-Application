using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace e_SoftBankingApplication
{
    public partial class frmBank : Form
    {

        public static frmBank keepBank = null;
        public static ArrayList customers = new ArrayList();
        public static string inputCustFile = @"G:\e-SOFTies.txt";
        public static int numCustItems = 9;
        public static int numAccItems = 6;
        public static int custSelected = -1;
        public static ListBox mainPadeSearchBox = null;


        public frmBank()
        {
            InitializeComponent();
            keepBank = this;
            mainPadeSearchBox = this.lstSearchCustResults;
        }

        private void frmBank_Load(object sender, EventArgs e)
        {
            Utilities.readDataFile(inputCustFile, customers);
            Utilities.showListOfCustomers(lstSearchCustResults);
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer tempNewCust = new frmNewCustomer();
            tempNewCust.Show();
            keepBank.Hide();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            custSelected = lstSearchCustResults.SelectedIndex;
            
            if (custSelected != -1)
            {
                frmViewCustAccounts tempViewCustomer = new frmViewCustAccounts();
                tempViewCustomer.Show();
                keepBank.Hide();
            }
            else
            {
                MessageBox.Show("Please select an account");
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string searchString = txtSearchBox.Text.ToUpper();
            int numberOfMatches = 0;

            for (int i = lstSearchCustResults.Items.Count - 1; i >= 0; i--)
            {

                if (lstSearchCustResults.Items[i].ToString().ToUpper().Contains(searchString))
                {
                    numberOfMatches++;

                    lstSearchCustResults.SetSelected(i, true);
                }
            }
            if (numberOfMatches > 1)
            {
                MessageBox.Show("Multiple matches found. \n\nPlease verify the customers full address from those highlighted."+
                                 "\n\nDe-select the customers that DO NOT match and view customer.");
            }
            else if (numberOfMatches == 0)
            {
                MessageBox.Show("No matches found. Please try again");
                txtSearchBox.Text = "";
                txtSearchBox.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
