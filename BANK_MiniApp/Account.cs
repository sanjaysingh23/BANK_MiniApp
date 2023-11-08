using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_MiniApp
{

    abstract class Account
    {
        private int id;
        static int setId;
        private String name;
        private Double balance;
        private String accountType;
        public abstract double withdraw(double amt);
        public double deposit(double amt)
        {
            balance = balance+amt;
            return balance;
        }
        public Account() { }
        public int Id
        {
            
            get 
            {
                setId++;
                id = setId;
                return id;
            }
        }
        public string Name
        { 
            get 
            { 
                return name;
            }
            set
            {
                
                    if (value.Length > 2 || value.Length < 15)
                    {
                    name = value;
                    
                    }
                else
                {
                    throw new Exception("value must  meet criteria");
                }
                
               
                
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set 
            {
                balance = value; 
            }
        }
        public String AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public Account(string name, double balance, string accountType)
        {
            this.Name = name; 
            this.Balance = balance;
            this.AccountType = accountType;
        }
        

        

    }
    
}
