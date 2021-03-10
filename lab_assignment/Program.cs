using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ourBank = new Bank("Developer Bank", 50);
            Console.WriteLine("Welcome to " + ourBank.BankName);

           bool test = true;

            while (test)
            {

                ourBank.Intro();

                string test1 = Console.ReadLine();

                switch (test1)
                {
                    case "open":
                        bool ab = true;
                        while (ab)
                        {
                            ourBank.IntroThree();
                            string bc = Console.ReadLine();

                            switch (bc)
                            {
                                case "savings":
                                    SavingAccount a1 = new SavingAccount(new Address());
                                    ourBank.AddAccount(a1);
                                    break;

                                case "checking":
                                    CheckingAccount a2 = new CheckingAccount(new Address());
                                    ourBank.AddAccount(a2);
                                    break;

                                case "quit":
                                    ab = false;
                                    break;


                            }
                        }
                       break;

                    case "account":

                        bool test3 = true;
                        while (test3)
                        {
                            ourBank.IntroTwo();
                            string test4 = Console.ReadLine();

                           
                            switch (test4)
                            {

                                case "deposit":
                                    {
                                        ourBank.Transaction(1);

                                        break;
                                    }


                                case "withdraw":
                                    {
                                        ourBank.Transaction(2);
                                        break;
                                    }
                                case "transfer":
                                    {
                                        ourBank.Transaction(3);
                                        break;
                                    }

                                case "show":
                                    ourBank.PrintAllAccount();
                                    break;

                                case "change":
                                    {
                                        Account a2 = new Account(new Address());
                                                                              
                                        ourBank.AddAccount(2, a2);
                                        break;
                                    }
                                case "quit":
                                    test3 = false;
                                    break;
                           }

                        }
                        break;
                    case "quit":
                        test = false;
                        break;
                }
            }
        }
    }
}
