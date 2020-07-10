using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ConsoleApp1
{
    public class GmailService : IMailService
    {
        public void SendMail()
        {
            Console.WriteLine("Gmail ile yollandı.");
        }
    }

    


}
