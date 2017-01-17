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
            Opiskelija oppilasA = new Opiskelija("Tuomas","Luukinen","K2679","TTV16S3", 20);
            Opiskelija oppilasB = new Opiskelija("Miikka", "Luukkonen", "K3000", "TTV13S5", 22);
            Opiskelija oppilasC = new Opiskelija("Teemu", "Kumlin", "K6754", "TTV15S1", 18);
            Opiskelija oppilasD = new Opiskelija("Antti", "Koponen", "K8777", "TTV14S5", 20);
            Opiskelija oppilasE = new Opiskelija("Matti", "Meikäläinen", "K0101", "TTV16S3", 50);
            oppilaat[0] = oppilasA;
            oppilaat[1] = oppilasB;
            oppilaat[2] = oppilasC;
            oppilaat[3] = oppilasD;
            oppilaat[4] = oppilasE;
            foreach (Opiskelija Opiskelija in oppilaat)
            {
                Opiskelija.PrintData();
            }
        }
    }
}
