using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KT5;

namespace KT5
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaOpiskelijat();
        }
        static void TestaaOpiskelijat()
        {
            Opiskelija[] oppilaat = new Opiskelija[5];
            oppilaat[0] = new Opiskelija("Tuomas","Luukinen","K2679","TTV16S3", 20);
            oppilaat[1] = new Opiskelija("Miikka", "Luukkonen", "K3000", "TTV13S5", 22);
            oppilaat[2] = new Opiskelija("Teemu", "Kumlin", "K6754", "TTV15S1", 18);
            oppilaat[3] = new Opiskelija("Antti", "Koponen", "K8777", "TTV14S5", 20);
            oppilaat[4] = new Opiskelija("Matti", "Meikäläinen", "K0101", "TTV16S3", 50);
            foreach (Opiskelija Opiskelija in oppilaat)
            {
                Opiskelija.PrintData();
            }
        }
    }
}
