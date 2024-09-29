using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    /// <summary>
    /// struct example
    /// </summary>
    public class Animal
    {
        public Animal()
        {
            
        }
        public Animal(string color, int height, string name)
        {
            Color = color;
            Height = height;
            Name = name;
        }
        public string Color { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public void GetAnimalDetails()
        {
            Console.WriteLine($"Color: {Color}, Height: {Height}, Name: {Name}");
        }
    }

    /// <summary>
    /// By default struct is sealed and can not be inherited
    /// </summary>
    public struct AnimalStruct
    {
        public AnimalStruct()
        {
            
        }
        public AnimalStruct(string color, int height, string name)
        {
            Color = color;
            Height = height;
            Name = name;
        }
        public string Color { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public void GetAnimalDetails()
        {
            Console.WriteLine($"Color: {Color}, Height: {Height}, Name: {Name}");
        }
    }
}
