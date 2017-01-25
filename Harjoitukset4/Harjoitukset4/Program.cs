using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kulkuneuvo porsche = new Kulkuneuvo("Porsche", "911", 4);
            Kulkuneuvo ducati = new Kulkuneuvo("Ducati", "Diavel", 2);
            Console.WriteLine("Created a new vehicle {0} model {1}", porsche.Nimi, porsche.Malli);

            for (int i = 0; i < porsche.RengasMaara; i++)
            {
                porsche.AddRengas("Nokia", "Hakkapeliitta", "205R16");
                
            }

            Console.WriteLine(porsche.ToString() + "\nTyres:");

            for (int i = 0; i < porsche.RengasMaara; i++)
            {
                Console.WriteLine("-Name " + porsche.Renkaat[i].Malli + " Model: " + porsche.Renkaat[i].Malli + " Tyre Size: " + porsche.Renkaat[i].Koko);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Created a new vehicle {0} model {1}", ducati.Nimi, ducati.Malli);

            for (int i = 0; i < ducati.RengasMaara; i++)
            {
                ducati.AddRengas("MIC", "Pilot", "160R17");
            }

            Console.WriteLine(ducati.ToString() + "\nTyres:");
            for (int i = 0; i < ducati.RengasMaara; i++)
            {
                Console.WriteLine("-Name " + ducati.Renkaat[i].Malli + " Model: " + ducati.Renkaat[i].Malli + " Tyre Size: " + ducati.Renkaat[i].Koko);
            }  
        }
    }
}
