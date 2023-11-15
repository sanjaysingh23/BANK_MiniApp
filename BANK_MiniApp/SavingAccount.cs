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
                Console.WriteLine("Insufficient balance");
            }
            finally
            {
                try
                {
                    StreamWriter sw = new StreamWriter("D:\\C-DAC\\DotNet\\ADO.Net_Asp.net\\Day3\\Bank file\\CustumerDetail.txt");
                    sw.WriteLine("{0} Withdraw amount {1}", Name, amt);
                    sw.Flush();
                    sw.Close();
                }
                catch (FileNotFoundException fe)
                {
                    Console.WriteLine($"Exception: {fe.Message}");
                }
            }
            return Balance;
        }
    }
}
