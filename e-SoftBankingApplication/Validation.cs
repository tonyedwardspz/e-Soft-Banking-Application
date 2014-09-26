using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace e_SoftBankingApplication
{
    class Validation
    {
        public static bool notNullTextBox(TextBox txtCurrent, String userFeedback)
        {
            if (txtCurrent.Text == "")
            {
                MessageBox.Show("Error - The input for " + userFeedback + " cannot be empty!. Please input again ... ");
                txtCurrent.Focus();
                return false;
            }
            else
                return true;
        }

        public static bool testForInt(TextBox txtCurrent, String userFeedback)
        {
            string testValue = txtCurrent.Text;

            try
            {
                Convert.ToInt32(testValue);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Please enter a numerical value for the " + userFeedback +". \n" + e.Message);
                return false;
            }
        }

        //NOT WORKING - alternative used
        //Validate the account Number
        public static bool testLengthIs8(TextBox txtCurrent)
        {
            int testNumber = txtCurrent.Text.Length;

            if (testNumber == 8)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error: Account number must be 8 characters long");
                txtCurrent.Focus();
                return false;
            }
        }

        //NOT WORKING - alternative used
        //Validate the sortcode
        public static bool testLengthIs6(TextBox txtCurrent)
        {
            int testNumber = txtCurrent.Text.Length;

            if (testNumber == 6)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error: Account number must be 6 characters long");
                txtCurrent.Focus();
                return false;
            }
        }
    }
}
