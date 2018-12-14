using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco_Farm_ORM
{
    public class Employee
    {
        //public Employee(string name, int age, string company)
        //{
        //    Name = name;
        //    Age = age;
        //    Company = company;
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}
