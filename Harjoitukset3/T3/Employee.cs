using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3;

namespace T3
{
    public class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string profession, int salary)
        {
            this.Name = name;
            this.Profession = profession;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return "- Name:" + Name + " Profession:" + Profession + " Salary:" + Salary;
        }
    }
}