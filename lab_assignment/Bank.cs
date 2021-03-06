using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_assignment
{
    class Bank
    {

        private string bankName;
        private SavingAccount[] saving;
        private CheckingAccount[] checking;
        private Account[] myBank;
        

        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.saving = new SavingAccount[size];
            this.checking = new CheckingAccount[size];
            this.myBank = new Account[size];
        }


        public Account[] MyBank
        {
            get { return this.myBank; }
        }


        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

       
        public void AddAccount(SavingAccount account)
        {
            for (int i = 0; i < saving.Length; i++)
            {
                if (saving[i] == null)
                {
                   
                    saving[i] = account;
                    Console.WriteLine("Enter Account Name: ");
                    saving[i].AccountName = Console.ReadLine();

                    Console.WriteLine("------Address------ ");

                    Console.WriteLine("Enter Road No.: ");
                    account.Address.RoadNo = Console.ReadLine();

                    Console.WriteLine("Enter Hourse No.: ");
                    account.Address.HouseNo = Console.ReadLine();

                    Console.WriteLine("Enter City: ");
                    account.Address.City = Console.ReadLine();

                    Console.WriteLine("Enter Country : ");
                    account.Address.Country = Console.ReadLine();


                    Console.WriteLine("Enter Birth Date : ");
                    saving[i].Date = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Birth Month : ");
                    saving[i].Month = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Birth Year : ");
                    saving[i].Year = Convert.ToInt32(Console.ReadLine());

                    saving[i].PrintDOB();

                    int a = saving[i].PrintACN();
                    Console.WriteLine("Welcome " + saving[i].AccountName);
                    Console.WriteLine(a);
                    Console.WriteLine("......Note The Account Number for Future Transaction.....");

                    break;
                }
            }
        }

        public void AddAccount(CheckingAccount account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (checking[i] == null)
                {
                    checking[i] = account;
                    Console.WriteLine("Enter Account Name : \n");
                    checking[i].AccountName = Console.ReadLine();


                    Console.WriteLine("----------- Address----------- \n");

                    Console.WriteLine("Enter Hourse No.: ");
                    account.Address.HouseNo = Console.ReadLine();

                    Console.WriteLine("Enter Road No.: ");
                    account.Address.RoadNo = Console.ReadLine();

                    Console.WriteLine("Enter City : ");
                    account.Address.City = Console.ReadLine();

                    Console.WriteLine("Enter Country: ");
                    account.Address.Country = Console.ReadLine();

                    Console.WriteLine("Enter Birth Date : ");
                    checking[i].Date = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Birth Month : ");
                    checking[i].Month = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Birth Year : ");
                    checking[i].Year = Convert.ToInt32(Console.ReadLine());

                    checking[i].PrintDOB();

                    int x = checking[i].PrintACN();
                    Console.WriteLine("Welcome " + saving[i].AccountName);
                    Console.WriteLine(x);
                    Console.WriteLine("......Note The Account Number for Future Transaction.....");
                    break;
                }
            }
        }

        public void Transaction(int s, params int[] ab)
         {
            Account a2 = new Account();

            if (s == 1)
            {
                Console.WriteLine("Customer Account Number");
                int accountNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Account Type : ");
                Console.WriteLine("1. Saving Account\n2. Checking Account");
                Console.WriteLine("Note : Type saving or checking ");

                string type = Console.ReadLine();
                if (type == "saving")
                {
                    for (int i = 0; i < saving.Length; i++)
                    {
                        if (accountNum == saving[i].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < saving.Length; i++)
                            {
                                if (saving[i] == null)
                                {
                                    continue;
                                }
                                else if (saving[i].AccountNumber == accountNum)
                                {
                                    Console.WriteLine("Enter Deposit Amount : ");
                                    double x = Convert.ToDouble(Console.ReadLine());
                                    saving[i].Deposit(x);
                                    saving[i].count++;
                                    Console.WriteLine("********Amount Deposited Successfully********");
                                    flag = 0;
                                   
                                }

                                else
                                {
                                    Console.WriteLine("Entered Account Not Found");
                                    flag = 1;
                                }

                            }

                        }
                    }
                }

                else if (type == "checking")
                {
                    for (int i = 0; i < checking.Length; i++)
                    {
                        if (accountNum == checking[i].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < checking.Length; i++)
                            {
                                if (checking[i] == null)
                                {
                                    continue;
                                }
                                else if (checking[i].AccountNumber == accountNum)
                                {
                                    Console.WriteLine("Enter Deposit Amount : ");
                                    double x = Convert.ToDouble(Console.ReadLine());
                                    checking[i].Deposit(x);
                                    checking[i].count++;
                                    Console.WriteLine("*******Amount Deposited Successfully******");
                                    flag = 0;
                                    
                                }

                                else
                                {
                                    Console.WriteLine("Entered Account Not Found");
                                    flag = 1;
                                }

                            }

                        }


                    }
                    
                }
            }

            else if (s == 2)  
            {

                Console.WriteLine("Customer Account Number to Withdraw Money");
                int accountNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Account Type : ");
                Console.WriteLine("1. Saving Account\n2. Checking Account");
                Console.WriteLine("Note : Type saving or checking ");

                string type = Console.ReadLine();
                if (type == "saving")
                {
                    for (int i = 0; i <= saving.Length; i++)
                    {
                        if (accountNum == saving[i].AccountNumber)
                        {
                            
                            for (i = 0; i < saving.Length; i++)
                            {
                                if (saving[i] == null)
                                {
                                    continue;
                                }
                                else if (saving[i].AccountNumber == accountNum)
                                {
                                    Console.WriteLine("Enter Amount to Withdraw: ");
                                    double x = Convert.ToDouble(Console.ReadLine());
                                    saving[i].Withdraw(x);
                                    saving[i].count++;
                                    Console.WriteLine("********Amount Withdraw Completed********");
                                    
                                }

                                else
                                {
                                    Console.WriteLine("Entered Account Not Found");
                                      
                                }

                            }

                        }
                    }
                }
                else if (type == "checking")
                {
                    for (int i = 0; i <= checking.Length; i++)
                    {
                        if (accountNum == checking[i].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < checking.Length; i++)
                            {
                                if (checking[i] == null)
                                {
                                    continue;
                                }
                                else if (checking[i].AccountNumber == accountNum)
                                {
                                    Console.WriteLine("Enter Amount to Withdraw: ");
                                    double x = Convert.ToDouble(Console.ReadLine());
                                    checking[i].Withdraw(x);
                                    checking[i].count++;
                                    Console.WriteLine("*******Amount Withdraw Completed*******");
                                    flag = 0;
                                    
                                }

                                else
                                {  
                                    flag = 1;
                                }

                            }

                        }


                    }
                    
                }
            }


           else if (s == 3)
            {

                Console.WriteLine("Your Account Type : ");
                Console.WriteLine("1. Saving Account\n2. Checking Account");
                Console.WriteLine("Note : Type saving or checking ");
                string type = Console.ReadLine();

                Console.WriteLine("Provide The Account Type Where Money will be Transferred : ");
                Console.WriteLine("1. Saving Account\n2. Checking Account");
                Console.WriteLine("Note : Type saving or checking ");
                string typea = Console.ReadLine();

                if (type == "saving" && typea == "saving")
                {
                    for (int i = 0; i < saving.Length; i++)
                    {
                        for (int j = 0; j < saving.Length; j++)
                        {
                            Console.WriteLine("Enter Your Account Number");
                            int accountN = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter The Account Number Where money will be Transferred");
                            int accountNT = Convert.ToInt32(Console.ReadLine());


                            int flag = 0;
                            for (i = 0; i < saving.Length; i++)
                            {
                                for (j = 0; j < saving.Length; j++)
                                    if (saving[i] == null || saving[j] == null)
                                    {
                                        continue;
                                    }

                                    else if (saving[i].AccountNumber == accountN && saving[j].AccountNumber == accountNT)
                                    {
                                        Console.WriteLine("Enter The Amount You want to Deposit: ");

                                        double x = Convert.ToDouble(Console.ReadLine());
                                        saving[i].Withdraw(x);
                                        saving[j].Deposit(x);
                                        saving[i].count++;
                                        Console.WriteLine("Transferred");
                                        flag = 0;
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine("Account not found");
                                        flag = 1;
                                    }

                            }

                          }
                    }

                }

                else if (type == "saving" && typea == "checking")

                {

                    for (int i = 0; i < saving.Length; i++)
                    {
                        for (int j = 0; j < checking.Length; j++)
                        {
                            Console.WriteLine("Enter Your Account Number");
                            int accountNum = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter The Account Number Where you want to Transfer");
                            int accountTNum = Convert.ToInt32(Console.ReadLine());

                            int flag = 0;
                            for (i = 0; i < saving.Length; i++)
                            {
                                for (j = 0; j < checking.Length; j++)
                                    if (saving[i] == null || checking[j] == null)
                                    {
                                        continue;
                                    }

                                    else if (saving[i].AccountNumber == accountNum && checking[j].AccountNumber == accountTNum)
                                    {
                                        Console.WriteLine("Enter Amount : ");

                                        double x = Convert.ToDouble(Console.ReadLine());
                                        saving[i].Withdraw(x);
                                        checking[j].Deposit(x);
                                        saving[i].count++;
                                        checking[j].count++;
                                        Console.WriteLine("*********Amount Transferred*********");
                                        flag = 0;
                                        //break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Account Not Found");
                                        flag = 1;
                                    }

                            }
                        }
                    }



                }


                else if (type == "checking" && typea == "saving")
                {

                    for (int i = 0; i < checking.Length; i++)
                    {
                        for (int j = 0; j < saving.Length; j++)
                        {
                            Console.WriteLine("Enter Your Account Number");
                            int accountNum = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter The Account Number Where you want to Transfer");
                            int accountTNum = Convert.ToInt32(Console.ReadLine());


                            int flag = 0;
                            for (i = 0; i < checking.Length; i++)
                            {
                                for (j = 0; j < saving.Length; j++)
                                    if (checking[i] == null || saving[j] == null)
                                    {
                                        continue;
                                    }

                                    else if (checking[i].AccountNumber == accountNum && saving[j].AccountNumber == accountTNum)
                                    {
                                        Console.WriteLine("Enter The Amount You want to Deposit: ");

                                        double x = Convert.ToDouble(Console.ReadLine());
                                        checking[i].Withdraw(x);
                                        saving[j].Deposit(x);
                                        checking[i].count++;
                                        saving[j].count++;
                                        Console.WriteLine("Balance Transfered...");
                                        flag = 0;
                                     }
                                    else
                                    {
                                        Console.WriteLine("Account Not Found");
                                        flag = 1;
                                    }

                            }
                            if (flag == 1)
                            {
                                Console.WriteLine("Account not found");
                            }
                           
                        }
                    }


                }

                else if (type == "checking" && typea == "checking")
                {
                    for (int i = 0; i < checking.Length; i++)
                    {
                        for (int j = 0; j < checking.Length; j++)
                        {
                            Console.WriteLine("Enter Your Account Number");
                            int accountNum = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter The Account Number Where you want to Transfer");
                            int accountTNum = Convert.ToInt32(Console.ReadLine());


                           
                            int flag = 0;
                            for (i = 0; i < checking.Length; i++)
                            {
                                for (j = 0; j < checking.Length; j++)
                                    if (checking[i] == null || checking[j] == null)
                                    {
                                        continue;
                                    }

                                    else if (checking[i].AccountNumber == accountNum && checking[j].AccountNumber == accountTNum)
                                    {
                                        Console.WriteLine("Enter The Amount You want to Transfer: ");

                                        double x = Convert.ToDouble(Console.ReadLine());
                                        checking[i].Withdraw(x);
                                        Console.WriteLine("Amount Transferred.....!!!");
                                        Console.WriteLine(checking[i].AccountNumber);
                                        checking[j].Deposit(x);
                                        checking[i].count++;
                                        checking[j].count++;
                                        Console.WriteLine("Balance Transfered...");
                                        flag = 0;
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine("Failed to Transfer....try Again");
                                        flag = 1;
                                    }

                            }
                           
                        }
                    }


                }


            }




        }

        public void PrintAllAccount()
        {
            Console.WriteLine("Your Account Type : ");
            Console.WriteLine("1. Saving Account\n2. Checking Account");
            Console.WriteLine("Note : Type saving or checking ");
            string type = Console.ReadLine();
            if (type == "saving")
            {
                for (int i = 0; i < saving.Length; i++)
                {
                    if (saving[i] == null)
                    {
                        continue;
                    }
                    saving[i].ShowAccountInformation();
                    saving[i].PrintACN();
                    Console.WriteLine("Number of Transaction in Your Account : " + saving[i].count);
                }
            }

            else if (type == "checking")
            {

                for (int i = 0; i < checking.Length; i++)
                {
                    if (checking[i] == null)
                    {
                        continue;
                    }
                    checking[i].ShowAccountInformation();
                    checking[i].PrintACN();
                    Console.WriteLine("Number of Transaction in your Account : " + checking[i].count);


                }
            }
        }
        public void IntroTwo()
        {
            Console.WriteLine("Choose Service from the Below Option");
            Console.WriteLine("Make a deposit");
            Console.WriteLine("Make a Withdrawal");
            Console.WriteLine("Make a transfer");
            Console.WriteLine("Show the number of transactions & balance");
            Console.WriteLine("Change User Name");
            Console.WriteLine("Exit the application");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Type 'deposit' to deposit amount, Type 'withdraw' to withdraw amount,Type 'transfer' to transfer amount,Type 'show' to Show the Number of Transaction & Balance,Type change to Change the User Name, Type quit to Exit from the System");


            Console.WriteLine("\n");


        }

        public void Intro()
        {
            Console.WriteLine("Choose Below Option");
            Console.WriteLine("Open A Bank Account");
            Console.WriteLine("Perform Transaction for an Account");
            Console.WriteLine("Exit the application ");
            Console.WriteLine("\n");
            Console.WriteLine("Type open to create an Account, Type account to perform Operation on Account, Type quit to Exit from the System");

            Console.WriteLine("\n");

        }


        public void AddAccount(int a, Account account)
        {
            Console.WriteLine("Your Account Type : ");
            Console.WriteLine("Saving Account\nChecking Account");
            Console.WriteLine("Note : Type saving or checking ");
            string type = Console.ReadLine();
            if (type == "saving")
            {
                for (int i = 0; i < saving.Length; i++)
                {
                    Console.WriteLine("Enter the Account Number you want to Chnage Name");
                    int accountnumber = Convert.ToInt32(Console.ReadLine());

                    if (saving[i].AccountNumber == accountnumber)
                    {
                        Console.WriteLine("User Name    " + saving[i].AccountName);
                        Console.WriteLine("Enter New User Name   ");
                        string changeName = Console.ReadLine();
                        saving[i].AccountName = changeName;

                        if (saving[i].AccountName == changeName)
                        {
                            Console.WriteLine("Account Name Changed ");
                        }
                        else { Console.WriteLine("Try Again"); }


                    }
                    break;
                }
            }

            else if (type == "checking")
            {
                for (int i = 0; i < checking.Length; i++)
                {
                    Console.WriteLine("Enter the Account Number you want to Change Name ");
                    int accountnumber = Convert.ToInt32(Console.ReadLine());

                    if (checking[i].AccountNumber == accountnumber)
                    {
                        Console.WriteLine("User Name  " + checking[i].AccountName);
                        Console.WriteLine("Enter New User Name ");
                        string changeName = Console.ReadLine();
                        checking[i].AccountName = changeName;

                        if (checking[i].AccountName == changeName)
                        {
                            Console.WriteLine("Account Name Changed ");
                        }
                        else { Console.WriteLine("Try Again"); }


                    }
                    break;
                }

            }
        }





        public void IntroThree()
        {
            Console.WriteLine("Choose Below Option");
            Console.WriteLine("Open A Savings Account");
            Console.WriteLine("Open A Checking Account");
            Console.WriteLine("Exit the application ");
            Console.WriteLine("\n");
            Console.WriteLine("Type savings to create a Savings Account, Type checking to create a Checking Account, Type quit to Exit from the System");

            Console.WriteLine("\n");

        }


    }
}
