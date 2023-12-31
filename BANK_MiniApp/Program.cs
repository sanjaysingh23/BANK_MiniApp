﻿namespace BANK_MiniApp
{
    internal class Program
    {
        static Program()
        {
            Console.WriteLine("Hello! Welocome to MyBank");
        }
        
        static void Main(string[] args)
        {
            Account account1 = null;
            Account account2 = null;
            Account account3 = null;
            Account account4 = null;
            try
            {
                account1 = new SavingAccount("ajay", 500000);
                account2 = new SavingAccount("reetesh", 400000);
                account3 = new CurrentAccount("Atul", 350000);
                account4 = new CurrentAccount("Saurabh", 380000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<Account> list = new List<Account>();
                list.Add(account1);
                list.Add(account2);
                list.Add(account3);
                list.Add(account4);

                foreach (Account account in list)
                {
                    Console.WriteLine("{0} {1} {2} {3} ", account.Name, account.Id, account.AccountType, account.Balance);

                }
                Console.WriteLine("Remain amount of {0} is {1}", account2.Name, account2.withdraw(4500));
                Console.WriteLine("Remain amount of {0} is {1}", account4.Name, account4.withdraw(500000));

                Console.WriteLine("Your interest is {0} ", SavingAccount.payInterest(new Employee { name = "vijay", balance = 480000 }));

                Console.WriteLine("{0}'s udated amount is {1}", account2.Name, account2.deposit(1234));
                Console.WriteLine("{0}'s udated amount is {1}", account3.Name, account3.deposit(9876));

            
            
            Console.ReadLine();
           
        }
    }
}