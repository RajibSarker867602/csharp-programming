using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    /// <summary>
    /// Destructor example
    /// Comments: (.Net Core internally manages destructors by gurbage collector-
    /// and it's internal decision is when to call the the destructor except that .net framework)
    /// </summary>
    public class Customer
    {
        CustomerA? CustomerA { get; set; }
        public Customer()
        {
            CustomerA = new CustomerA();
        }
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        ~Customer()
        {
            Console.WriteLine("Destructure  is called!");
        }
        public string FirstName { get; set; } = "Rajib";
        public string LastName { get; set; } = "Sarker";

        public void ShowFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            CustomerA = null;
        }
    }

    public class CustomerA
    {
        public CustomerA()
        {
            Console.WriteLine("Initializing the CustomerA");
        }

        ~CustomerA()
        {
            Console.WriteLine("Destroyed ClassA");
        }
    }
}
