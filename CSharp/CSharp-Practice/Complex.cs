using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    class Complex
    {

        // Class members, private  
        // by default 
        int real, img;

        // Defining the constructor 
        public Complex()
        {
            real = 0;
            img = 0;
        }

        // SetValue method sets  
        // value of real and img 
        public void SetValue(int r, int i)
        {
            real = r;
            img = i;
        }

        // DisplayValue displays  
        // values of real and img 
        public void DisplayValue()
        {
            Console.WriteLine("Real = " + real);
            Console.WriteLine("Imaginary = " + img);
        }

        // Defining the destructor 
        // for class Complex 
        ~Complex()
        {
            Console.WriteLine("Destructor was called");
        }
    }
}
