using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    public class Person
    {
        public string FirstName { get; set; } = "Rajib";
        public string LastName { get; set; } = "Sarker";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PersonA : Person
    {
        public override void PrintFullName()
        {
            Console.WriteLine("A Person Full Name is Printing...");
        }
    }

    public class PersonB : Person
    {

    }
}
