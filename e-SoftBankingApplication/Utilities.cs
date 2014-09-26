using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace e_SoftBankingApplication
{
    class Utilities
    {
        //Read the data file into the application line by line
        public static void readDataFile(string theFile, ArrayList allCustomers)
        {
            StreamReader inCust = null;
            bool anyMoreCust = false;
            string[] custData = new string[frmBank.numCustItems];
            string[] accData = new string[frmBank.numAccItems];
            int numCustomerAccounts;
            Account tempAccount;
            Customer tempCustomer;

            if (fileOpensForReadIn(theFile, ref inCust))
            {
                //load the first customer
                anyMoreCust = getNextCust(frmBank.numCustItems, inCust, custData);

                while (anyMoreCust == true)
                {
                    //Create new customer
                    numCustomerAccounts = Convert.ToInt32(custData[8]);
                    tempCustomer = new Customer(custData[0], custData[1], custData[2], custData[3], custData[4],
                                    custData[5], custData[6], custData[7], numCustomerAccounts);

                    //Read Accounts into Array
                    for (int i = 0; i < numCustomerAccounts; i++)
                    {
                        //Get the next customer
                        getNextCust(frmBank.numAccItems, inCust, accData);

                        //Create new account and add it to the customer
                        //Nickname, Sortcode, ACC No, opening date, current Balance, overdraft.
                        tempAccount = new Account(accData[0], accData[1], accData[2], accData[3], accData[4], accData[5]);
                        tempCustomer.addAccountToCustomer(tempCustomer.getCustAllAccounts(), tempAccount);
                    }

                    //Add the customer to main array
                    allCustomers.Add(tempCustomer);
                    anyMoreCust = getNextCust(frmBank.numCustItems, inCust, custData);
                }
                //Once there is no more data, close the Streamreader
                if (inCust != null)
                {
                    inCust.Close();
                }
            }
        }

        //Update customer details
        public static void saveCustomerDetails(Customer currentCustomer, string ID, string firstName, string lastName, string houseNumberName, 
                                               string street, string city, string postCode, string password)
        {
            try
            {
                //ID, firstName, lastName, houseNumberName, street, city, postCode, password
                currentCustomer.setCityTown(city);
                currentCustomer.setCustID(ID);
                currentCustomer.setFirstName(firstName);
                currentCustomer.setHouseName(houseNumberName);
                currentCustomer.setLastName(lastName);
                currentCustomer.setPassword(password);
                currentCustomer.setPostcode(postCode);
                currentCustomer.setStreetName(street);

                writeDataOut(frmBank.inputCustFile, frmBank.customers);
                MessageBox.Show("Customer successfully edited");
                frmViewCustAccounts.keepCustAccount.disableCustomerEdits();
            }
            catch (FormatException e2)
            {
                MessageBox.Show("Error: Customer details are invalid \n" + e2.Message);
            }
        }

        public static void writeDataOut(string theFile, ArrayList allCustomers)
        {
            StreamWriter outputCustomers = null;

            if (fileOpenForWriteOut(theFile, ref outputCustomers))
            {
                //loop for each customer
                foreach (Customer currentCustomer in allCustomers)
                {
                    writeCustomer(outputCustomers, currentCustomer);
                    foreach (Account currentAccount in currentCustomer.getCustAllAccounts())
                    {
                        writeAccount(outputCustomers, currentAccount);
                    }
                }
                //If data has been written
                if (outputCustomers != null)
                {
                    outputCustomers.Close();
                }
            }
        }

        //Write customer to file
        // ID - First - Last - HouseNo - Street - City - PostCode - Password - NumAcc
        public static void writeCustomer(StreamWriter writingOutCustomer, Customer thisCust)
        {
            writingOutCustomer.WriteLine(thisCust.getCustID());
            writingOutCustomer.WriteLine(thisCust.getCustFirstName());
            writingOutCustomer.WriteLine(thisCust.getCustLastName());
            writingOutCustomer.WriteLine(thisCust.getCustHouseNameNumber());
            writingOutCustomer.WriteLine(thisCust.getCustStreet());
            writingOutCustomer.WriteLine(thisCust.getCustCityTown());
            writingOutCustomer.WriteLine(thisCust.getCustPostCode());
            writingOutCustomer.WriteLine(thisCust.getPassword());
            writingOutCustomer.WriteLine(thisCust.getNumberAccounts());
        }

        //Write account to file
        //Data order - Nickname, Sortcode, ACC No, opening date, current Balance, overdraft.
        public static void writeAccount(StreamWriter writingOutAccount, Account thisAccount)
        {
            writingOutAccount.WriteLine(thisAccount.getAccountName());
            writingOutAccount.WriteLine(thisAccount.getAccountSortcode());
            writingOutAccount.WriteLine(thisAccount.getAccountNumber());
            writingOutAccount.WriteLine(thisAccount.getAccountCreationDate());
            writingOutAccount.WriteLine(thisAccount.getAccountBalance());
            writingOutAccount.WriteLine(thisAccount.getOverDraftLimit());
        }

        public static bool fileOpensForReadIn(string readFile, ref StreamReader fileIn)
        {
            //open file - check for errors            
            try
            {
                fileIn = new StreamReader(readFile);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Opening File when reading data in. \n"
                                 + e.Message);
                return false;
            }
        }

        public static void showListOfCustomers(ListBox lstOutput)
        {
            string output;

            lstOutput.Items.Clear();

            //Load data and output to listbox
            foreach (Customer c in frmBank.customers)
            {
                output = "Customer " + c.getFullName() + " has " + c.getNumberAccounts() + " acounts.               \tAddress: " + c.getCustomerAddress();
                lstOutput.Items.Add(output);

            }
        }

        public static bool fileOpenForWriteOut(string writeFile, ref StreamWriter dataOut)
        {
            //open file - check for errors            
            try
            {
                dataOut = new StreamWriter(writeFile);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Opening File when writing data out" +
                                "\n" + e.Message);
                return false;
            }
        }

        public static bool getNextCust(int numberOfItems, StreamReader inNext, string[] nextCustData)
        {
            string nextLine;
            int numDataItems = numberOfItems;

            for (int i = 0; i < numberOfItems; i++)
            {
                //Try to read in a customer
                try
                {
                    nextLine = inNext.ReadLine();

                    //If theres data, store it.
                    if (nextLine != null)
                    {
                        nextCustData[i] = nextLine;
                    }
                    //No data, no more nustomers
                    else
                    {
                        return false;
                    }
                }
                //File could not be read
                catch (Exception e) 
                {
                    MessageBox.Show("Error: Corrupted file.\n" +
                                                          e.Message);
                    return false;
                }          
            }
            //Data sucessfully read
            return true;
        }

        //Delete customer
        public static void deleteCustomer(int selectedCust)
        {
            try
            {
                //Delete the account from the array and update the .txt file.
                frmBank.customers.RemoveAt(selectedCust);
                writeDataOut(frmBank.inputCustFile, frmBank.customers);
                MessageBox.Show("Customer deleted");
            }
            catch
            {
                MessageBox.Show("Error deleting account.");
            }
        }

        //
        public static int addNewAccountToCustomer(Customer whichCustomer, string tempAccName, string tempAccSortCode, string tempAccNumber, 
                                                  string tempAccCreationDate, string tempAccBalance, string tempAccOverdraftLimit)
        {
            int testBalance = 0;
            testBalance = Convert.ToInt32(tempAccBalance);

            //Update the number of customer accounts
            int numAccounts = whichCustomer.getNumberAccounts();
            numAccounts++;
            whichCustomer.setNumberAccounts(numAccounts);

            //Create new Account and update file
            //Data order - Nickname, Sortcode, ACC No, opening date, current Balance, overdraft.
            Account temp = new Account(tempAccName, tempAccSortCode, tempAccNumber, tempAccCreationDate, tempAccBalance, tempAccOverdraftLimit);
            whichCustomer.addAccountToCustomer(whichCustomer.getCustAllAccounts(), temp);
            Utilities.writeDataOut(frmBank.inputCustFile, frmBank.customers);

            MessageBox.Show("The Account: " + tempAccName + " has been successfully created");
            return testBalance;
        }

        public static string generateCustomerNumber()
        {
            string customerNumber = "";

            //generate the first charachter
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random randomPosition = new Random();

            int position = randomPosition.Next(0,25);
            char c = chars[position];

            customerNumber = c.ToString();

            for (int i = 0; i <= 5; i++)
            {
                int randNum = randomPosition.Next(0, 9);
                customerNumber += randNum.ToString();
            }
           
            return customerNumber;
        }

        public static string generateAccountNumber()
        {
            string customerNumber = "";
            Random number = new Random();

            for (int i = 0; i <= 7; i++)
            {
                int randNum = number.Next(0, 9);
                customerNumber += randNum.ToString();
            }

            return customerNumber;
        }
    }
}
