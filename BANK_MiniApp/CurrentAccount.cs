using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_MiniApp
{
    internal class CurrentAccount : Account
    {
        private static int numOfObj;
        private CurrentAccount()
            : base()
        { }
        public CurrentAccount(string name, double balance) 
            : base(name, balance,"Current_Account")
        { }
        public override double withdraw(double amt)
        {
            SendMessage obj = new SendMessage();
            obj.messageReceived += new message(Message.sms);
            obj.messageReceived += new message(Message.email);
            obj.send("Withdrawl amount is "+amt);
            return (Balance - amt);
        }
        
        public static CurrentAccount GetObj()
        {
            if (numOfObj < 5)
            {
                numOfObj++;
                return new CurrentAccount();
            }
            else
            {
                throw new ArgumentOutOfRangeException("Only five Members are allowed");
            }
        }
    }

}
