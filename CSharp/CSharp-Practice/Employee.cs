using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    public abstract class Employee
    {
        protected Employee()
        {
            Console.WriteLine(GetMonthlySalary());
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public abstract double GetMonthlySalary();

        public override string ToString()
        {
            return $"Employee Info: {GetFullName()}, Salary per month: {GetMonthlySalary()}";
        }
    }

    public class FullTimeEmployee : Employee
    {
        public double YearlySalary { get; set; }

        public override double GetMonthlySalary()
        {
            Console.WriteLine("Salary is invoded for FullTimeEmployee");
            return YearlySalary / 12;
        }
    }

    public class PartTimeEmployee : Employee
    {
        public int HourlyPay { get; set; }
        public float TotalHour { get; set; }

        public override double GetMonthlySalary()
        {
            Console.WriteLine("Salary is invoded for PartTimeEmployee");
            return HourlyPay * TotalHour;
        }
    }
}
