using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
        public void SetItem(string key, string value)
        {

        }
        //public string GetItem(string key)
        //{

        //}
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
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

            //try
            //{
            //    var num = int.Parse("abc");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Coversion failed.");
            //}

            //int number;
            //var result = int.TryParse("abc", out number);
            //if (result)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Conversiona Failed.");
            //}

            //var customer = new Customer(1);
            //customer.Orders.Add(new Order());
            //customer.Orders.Add(new Order());

            //customer.Promote();
            //Console.WriteLine(customer.Orders.Count);

            //var person = new Person1();
            //person.SetBirthdate(new DateTime(1982, 1, 1));
            //Console.WriteLine(person.GetBirtdate());

            var properties = new Properties(new DateTime(2002, 5, 5));
            Console.WriteLine(properties.Age);
            var cookie = new HttpCookie();
            cookie["name"] = "Tamima";
            Console.WriteLine(cookie["name"]);
                        
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
