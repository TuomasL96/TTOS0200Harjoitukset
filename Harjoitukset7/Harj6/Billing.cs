using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj6
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Product(string nimi, float hinta)
        {
            Nimi = nimi;
            Price = hinta;
        }
    }

    public class Lasku
    {

        float kokonaishinta = 0f;
        public Dictionary<Product, int> Tuotteet { get; }
        public float Kokonaishinta { get { return kokonaishinta; } }

        public Lasku()
        {
            Tuotteet = new Dictionary<Product, int>();
        }

        public void Bill()
        {
            foreach (KeyValuePair<Product, int> pair in Tuotteet)
            {
                kokonaishinta += pair.Key.Price * pair.Value;
            }
        }

        public override string ToString()
        {
            string apu = "Tilatut tuotteet: \n";

            foreach (KeyValuePair<Product, int> pair in Tuotteet)
            {
                apu += pair.Key.Nimi + " " + pair.Value + " Kappaletta " + "Yksikköhinta: " + pair.Key.Price + "\n";
            }
            apu += "Tuotteiden kokonaishinta: " + Kokonaishinta;
            return apu;
        }
    }
}
