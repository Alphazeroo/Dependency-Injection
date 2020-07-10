using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MailOperations mailOperations = new MailOperations();
            Console.WriteLine("mail yollamak ister misinz ?");
            Console.Write("1.Evet\n2.Hayır\n");
            int s1 = Convert.ToInt16(Console.ReadLine());
            ServiceProvider serviceProvider = new ServiceCollection()
                                           .AddTransient<IMailService, GmailService>()
                                           .BuildServiceProvider();
            if (s1 == 1)
            {
                mailOperations.SendMail(serviceProvider.GetService<IMailService>());
            }
            else if (s1 == 2)
            {
                Console.WriteLine("işlem iptal edildi.");
            }
            
            
            






        }
    }
}
