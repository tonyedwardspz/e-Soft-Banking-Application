using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_SoftBankingApplication
{
    class Customer
    {
        private string custID;
        private string firstName;
        private string lastName;
        private string houseNameNumber;
        private string streetName;
        private string cityOrTown;
        private string postcode;
        private string password;
        private int numAccounts;
        ArrayList custAllAccount;

        //Class constructor - Customer with account
        // ID - First - Last - HouseNo - Street - City - PostCode - Password - NumAcc

        public Customer(string inCustID, string inCustFirstName, string inCustLastName,
                        string inCustHouseNo, string inCustStreet, string inCustCityTown,
                        string inCustPostcode, string inCustPassword, int inCustNumAccounts)
        {
            custID = inCustID;
            firstName = inCustFirstName;
            lastName = inCustLastName;
            houseNameNumber = inCustHouseNo;
            streetName = inCustStreet;
            cityOrTown = inCustCityTown;
            postcode = inCustPostcode;
            password = inCustPassword;
            numAccounts = inCustNumAccounts;
            custAllAccount = new ArrayList();
        }

        //Class constructor - Customer without account (new customer)
        // ID - First - Last - HouseNo - Street - City - PostCode - Password - NumAcc

        public Customer(string inCustID, string inCustFirstName, string inCustLastName,
                        string inCustHouseNo, string inCustStreet, string inCustCityTown,
                        string inCustPostcode, string inCustPassword)
        {
            custID = inCustID;
            firstName = inCustFirstName;
            lastName = inCustLastName;
            houseNameNumber = inCustHouseNo;
            streetName = inCustStreet;
            cityOrTown = inCustCityTown;
            postcode = inCustPostcode;
            password = inCustPassword;
            numAccounts = 0; //For new customer
            custAllAccount = new ArrayList();
        }

        //Add account to customer
        public ArrayList addAccountToCustomer(ArrayList theAccountSoFar, Account theNewAccount)
        {
            theAccountSoFar.Add(theNewAccount);
            numAccounts = theAccountSoFar.Count;
            return theAccountSoFar;
        }

        //Setters
        // ID - First - Last - HouseNo - Street - City - PostCode - Password - NumAcc
        public void setCustID(string inCustID)
        {
            custID = inCustID;
        }
        public void setFirstName(string inCustFirstName)
        {
            firstName = inCustFirstName;
        }
        public void setLastName(string inCustLastName)
        {
            lastName = inCustLastName;
        }
        public void setHouseName(string inCustHouseNo)
        {
            houseNameNumber = inCustHouseNo;
        }
        public void setStreetName(string inCustStreet)
        {
            streetName = inCustStreet;
        }
        public void setCityTown(string inCustCityTown)
        {
            cityOrTown = inCustCityTown;
        }
        public void setPostcode(string inCustPostcode)
        {
            postcode = inCustPostcode.ToUpper();
        }
        public void setPassword(string inCustPassword)
        {
            password = inCustPassword;
        }
        public void setNumberAccounts(int inCustNumAccounts)
        {
            numAccounts = inCustNumAccounts;
        }
        public void setCustAllAccounts(ArrayList tempCustAccounts)
        {
            custAllAccount = tempCustAccounts;
        }

        //Getters
        // ID - First - Last - HouseNo - Street - City - PostCode - Password - NumAcc

        public string getCustID()
        {
            return custID;
        }
        public string getCustFirstName()
        {
            return firstName;
        }
        public string getCustLastName()
        {
            return lastName;
        }
        public string getCustHouseNameNumber()
        {
            return houseNameNumber;
        }
        public string getCustStreet()
        {
            return streetName;
        }
        public string getCustCityTown()
        {
            return cityOrTown;
        }
        public string getCustPostCode()
        {
            return postcode;
        }
        public string getPassword()
        {
            return password;
        }
        public int getNumberAccounts()
        {
            return numAccounts;
        }
        public string getFullName()
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
        public string getCustomerDetails()
        {
            string customerDetails = firstName + " " + lastName + ".   ADDRESS: " + houseNameNumber + " " + streetName 
                                     + " " + cityOrTown + " " + postcode;
            return customerDetails;
        }
        public ArrayList getCustAllAccounts()
        {
            return custAllAccount;
        }
        public string getCustomerAddress()
        {
            string address = houseNameNumber + " " + streetName + ", " + cityOrTown + ", " + postcode + ".";
            return address;
        }
    }
}
