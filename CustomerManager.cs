using CustomerTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.MailAdress + " ; "+" Email address of the named person has been added to our bank's mailing list.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.MailAdress + " ; "+"Email address of the named person has been removed from our bank's mailing list");
        }

        public void List(Customer customer)
        {
            Console.WriteLine(customer.MailAdress + " ; "+"Mail addresses are in our bank's mailing list.");
        }

        internal void Add(Customer customer1, Customer customer2, Customer customer3)
        {
            throw new NotImplementedException();
        }
    }
}
