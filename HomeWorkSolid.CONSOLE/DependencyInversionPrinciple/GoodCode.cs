using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSolid.CONSOLE.DependencyInversionPrinciple
{
    public class EmailSender2 : IEmailSender
    {
        public void Send(string email, string content)
        {
            Console.WriteLine($"Sending email to {email}");
        }
    }

    // High level module

    // Abstraction
    public interface IEmailSender
    {
        void Send(string email, string content);
    }

    public class OrderService2
    {
        private readonly IEmailSender _emailSender;

        public OrderService2(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void CreateOrder()
        {
            Console.WriteLine("Creating order");

            //Sending order details
            _emailSender.Send("tanvirarjel2@gmail.com", "This is order detail.");
        }
    }

    // We have inverted the dependencies. Now both high level and low level modules are dependent on the abstraction (IEmailSender).

}
