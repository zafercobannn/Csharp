using ClassMetotDemo;
using System;

namespace CustomerTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer1 = new Customer();
            customer1.Name = "Zafer";
            customer1.LastName = "ÇOBAN";
            customer1.TelephoneNumber = 232323232;
            customer1.MailAdress = "zafercoban@gmail.com";



            Customer customer2 = new Customer();
            customer2.Name = "Engin";
            customer2.LastName = "Demiroğ";
            customer2.TelephoneNumber = 543434343;
            customer2.MailAdress = "engindemirog@gmail.com";



            Customer customer3 = new Customer();
            customer3.Name = "Aygül";
            customer3.LastName = "Mahleç";
            customer3.TelephoneNumber = 121212121;
            customer3.MailAdress = "aygulmahlec@gmail.com";



            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.TelephoneNumber);
                Console.WriteLine(customer.MailAdress);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("-----------------------------------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("-----------------------------------------");


            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);

            Console.WriteLine("-----------------------------------------");

            customerManager.List(customer1);
            customerManager.List(customer2);
            customerManager.List(customer3);



        }
    }
}
