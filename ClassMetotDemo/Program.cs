using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.FirstName = "Aidana";
            customer1.LastName = "Bulut";
            customer1.Balance = 420.500m;

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.FirstName = "Bilal";
            customer2.LastName = "Gokbel";
            customer2.Balance = 344.440m;

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach(var  customer in customers)
            {
                Console.WriteLine(customer.CustomerId);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.Balance);
                Console.WriteLine("--------------------");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);
            Console.WriteLine("-----------------------------");
            customerManager.Add(customer2);
            customerManager.Update(customer2);
            customerManager.Delete(customer2);


            Console.ReadKey();
        }
    }
}
