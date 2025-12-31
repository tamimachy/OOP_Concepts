using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            // var person = Person.Parse("John");
            // var customer = new Customer();
            // customer.Id = 1;
            // customer.Name = "Mosh";
            // var order = new Order();
            // customer.Orders = new List<Order>();
            // customer.Orders.Add(order);

            // Console.WriteLine(customer.Id);
            // Console.WriteLine(customer.Name);
            // person.Introduce("Mosh");

            // var number = int.Parse("abc");
            // int number;
            // var result = int.TryParse("abc", out number);
            // if(result)
            //    Console.WriteLine(number);
            // else
            //    Console.WriteLine("Conversion failed.");
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();
            Console.WriteLine(customer.Orders.Count);

            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Coversion failed.");
            }

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversiona Failed.");
            }
        }
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
            
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred.");
            }
        }
    }
}
