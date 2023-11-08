using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_MiniApp
{
    public delegate void message(string msg);
    internal class Message
    {   
        public static void sms(string msg) 
        {
            Console.WriteLine(msg);
        }
        public static void email(string msg) 
        {
            Console.WriteLine(msg);
        }
    }
    class SendMessage
    {
        public event message messageReceived;
        public void send(string msg)
        {
            if (messageReceived != null)
            {
                messageReceived(msg);
            }
        }
    }
}
