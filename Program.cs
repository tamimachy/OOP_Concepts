using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // var person = Person.Parse("John");
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Mosh";

            var order = new Order();
            customer.Orders = new List<Order>();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            //person.Introduce("Mosh");
        }
    }
}
