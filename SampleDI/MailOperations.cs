using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MailOperations
    {
        public void SendMail(IMailService mailService)
        {
            mailService.SendMail();
        }

    }
}
