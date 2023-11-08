using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_MiniApp
{
    internal class SavingAccount : Account
    {
        public SavingAccount(string name, double balance) 
        : base(name, balance,"Saving_Account")
        { }

        private static int numOfObj;
        private SavingAccount()
            : base()
        { }
        public static double payInterest(Employee e)
        {
            double interest = 0;
            if (e.balance > 0)
            {
                interest = e.balance * 0.08;
                e.balance = interest + e.balance;
            }
            else
            {
                throw new Exception("There is no interest");
            }
            
            return interest;

        }
        public override double withdraw(double amt)
        {
            double newBalance = Balance-amt;

            try
            {
                if (newBalance > 1000)
                {
                    SendMessage obj = new SendMessage();
                    obj.messageReceived += new message(Message.sms);
                    obj.messageReceived += new message(Message.email);
                    obj.send("Withdrawl amount is " + amt);
                    Balance = Balance - amt;
                }
            }
           
            catch (Exception e)
            { 
                throw new Exception("Insufficient balance");
            }
            finally
            {
                StreamWriter sw = new StreamWriter("D:\\C-DAC\\DotNet\\ADO_DotNet\\Day3\\Bank file\\CustumerDetail.txt");
                sw.WriteLine("{0} Withdraw amount {1}", Name, amt);
                sw.Flush();
                sw.Close();
            }

            return Balance;
        }
        
        public static SavingAccount GetObj()
        {
            if(numOfObj < 5) 
            {
                numOfObj++;
                return new SavingAccount();
            }
            else
            {
                throw new ArgumentOutOfRangeException("Only five Members are allowed");
            }
        }
    }
}
