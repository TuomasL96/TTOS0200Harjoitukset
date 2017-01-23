using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3;

namespace T3
{
    public class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss(string name, string profession, int salary, string car, int bonus)
            :base(name, profession, salary)
        {
            this.Car = car;
            this.Bonus = bonus;
        }
        public override string ToString()
        {
            return base.ToString() + " Car:" + Car + " Bonus:" + Bonus;
        }
    }
}
