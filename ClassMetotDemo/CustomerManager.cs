using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"Tebrikler Id'si:{customer.CustomerId} ve İsmi: {customer.FirstName} olan kullanıcı kaydı başarıyla eklendı");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine($"Tebrikler Id'si:{customer.CustomerId} ve İsmi: {customer.FirstName} olan kullanıcı kaydı başarıyle güncellendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine($"Tebrikler Id'si:{customer.CustomerId} ve İsmi: {customer.FirstName} olan kullanıcı kaydı başarıyla silindi");
        }

    }
}
