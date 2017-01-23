using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4;

namespace T4
{
    class Kulkuneuvo
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Kulkuneuvo(string name, string model, int year, string color)
        {
            this.Name = name;
            this.Model = model;
            this.Color = color;
            this.Year = year;
        }

        public override string ToString()
        {
            return "- Name:" + Name + " Model:" +  Model + " ModelYear:" + Year + " Color:" + Color;
        }
    }
}

