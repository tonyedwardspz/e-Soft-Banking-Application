using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_SoftBankingApplication
{
    class Account
    {
        private string accountName;
        private int sortcode;
        private int accountNumber;
        private string accountCreationDate;
        private double accountBalance;
        private double overdraftLimit;
        

        //Class constructors
        //Data order - Nickname, Sortcode, ACC No, opening date, current Balance, overdraft.
        public Account(string theAccountNickname, string theSortcode, string theAccountNumber, string theOpeningDate,
                       string theAccountBalance, string theOverDraftLimit)
        {
            accountName = theAccountNickname;
            setAccountSortcode(theSortcode);
            setAccountNumber(theAccountNumber);
            accountCreationDate = theOpeningDate;
            setAccountBalance(theAccountBalance);
            setAccountOverdraft(theOverDraftLimit);
        }

        //Getters
        public string getAccountName()
        {
            return accountName;
        }
        public int getAccountSortcode()
        {
            return sortcode;
        }
        public int getAccountNumber()
        {
            return accountNumber;
        }
        public string getAccountCreationDate()
        {
            return accountCreationDate;
        }
        public double getAccountBalance()
        {
            return accountBalance;
        }
        public double getOverDraftLimit()
        {
            return overdraftLimit;
        }



        //Setters
        public void setAccountName(string inName)
        {
            accountName = inName;
        }
        public void setAccountSortcode(string inAccSort)
        {
            try
            {
                sortcode = Convert.ToInt32(inAccSort);
            }
            catch (FormatException e)
            {
                MessageBox.Show(inAccSort + "Error: Invalid Sortcode" + e.Message);
            }
        }
        public void setAccountNumber(string inAccountNo)
        {
            try
            {

                accountNumber = Convert.ToInt32(inAccountNo);
            }
            catch (FormatException e)
            {
                MessageBox.Show(inAccountNo + "Error: Invalid Account Number " + e.Message);
            }
        }
        public void setAccountCreationDate(string inAccountCreationDate)
        {
            accountCreationDate = inAccountCreationDate;
        }
        public void setAccountBalance(string inAccountBalance)
        {
            try
            {
                accountBalance = Convert.ToDouble(inAccountBalance);
            }
            catch (FormatException e)
            {
                MessageBox.Show(inAccountBalance + "Error: Invalid Account Balance " + e.Message);
            }
        }
        public void setAccountOverdraft(string inOverdraft)
        {
            try
            {

                overdraftLimit = Convert.ToDouble(inOverdraft);
            }
            catch (FormatException e)
            {
                MessageBox.Show(inOverdraft + "Error: Invalid Overdraft" + e.Message);
            }
        }
    }
}
