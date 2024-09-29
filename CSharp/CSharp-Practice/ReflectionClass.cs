using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    internal class ReflectionClass
    {
        public int _id;
        public int Id { get; set; }
        public string Name { get; set; }

        public ReflectionClass()
        {
            Id = -1;
            Name = "Default";
        }

        public ReflectionClass(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Id - {Id}, Name - {Name}");
        }
    }
}
