using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    public class IndexerEmp
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class IndexerClass
    {
        private List<IndexerEmp> _employees;
        public IndexerClass()
        {
            _employees = new List<IndexerEmp>();
            _employees.Add(new IndexerEmp() { Id = 1, Name = "Rajib" });
            _employees.Add(new IndexerEmp() { Id = 2, Name = "Sajib" });
            _employees.Add(new IndexerEmp() { Id = 3, Name = "Raju" });
            _employees.Add(new IndexerEmp() { Id = 4, Name = "Diman" });
            _employees.Add(new IndexerEmp() { Id = 5, Name = "Roy" });
            _employees.Add(new IndexerEmp() { Id = 6, Name = "Json" });
            _employees.Add(new IndexerEmp() { Id = 7, Name = "Bob" });
        }

        public string this[int id]
        {
            get
            {
                return _employees.FirstOrDefault(c => c.Id == id)?.Name;
            }
            set
            {
                _employees.FirstOrDefault(c => c.Id == id).Name = value;
            }
        }

        public int this[string value]
        {
            get
            {
                var emps = _employees.Where(c => c.Name.Contains(value)).ToList();
                return emps.Count;
            }
        }
    }
}
