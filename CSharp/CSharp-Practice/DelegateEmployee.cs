using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    public delegate bool IsPromotedDelegate(DelegateEmployee employee);
    /// <summary>
    /// Using delegate, we've decoupled the logic to print the list of promoted employees
    /// </summary>
    public class DelegateEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        /// <summary>
        /// without delegate
        /// </summary>
        /// <param name="employees"></param>
        public static void PromoteEmployee(List<DelegateEmployee> employees)
        {
            Console.WriteLine("-------------Without delegate----------------");
            foreach (DelegateEmployee employee in employees)
            {
                if (employee.Salary > 10000)
                {
                    Console.WriteLine($"{employee.Name} - promoted");
                }
            }
        }

        /// <summary>
        /// with delegate
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="isPromoted"></param>
        public static void PromoteEmployeesWithDelegate(List<DelegateEmployee> employees, IsPromotedDelegate isPromoted)
        {
            Console.WriteLine("-------------With delegate----------------");
            foreach (DelegateEmployee employee in employees)
            {
                if (isPromoted(employee))
                {
                    Console.WriteLine($"{employee.Name} - promoted.");
                }
            }
        }
    }
}
