using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    public class Tyre
    {
        public string TBrand { get; set; }
        public string TModel { get; set; }
        public string TSize { get; set; }  
        public string TyreDetails()
        {
            return string.Format("-Name: {0} model: {1} TyreSize: {2}", TBrand, TModel, TSize);
        }
    }
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int TyreCount { get; set; }
        public List<Tyre> Tyres { get; }
        public Vehicle()
        {
            Tyres = new List<Tyre>(); 
        }
        public Vehicle(string brand, string model, int trcnt)
        {
            Brand = brand;
            Model = model;
            TyreCount = trcnt;
        }
        public void AddTyres(Tyre)
        {
            for (int i = 0; i <= TyreCount; i++)
            {
                Tyres.Add(tyre);
            }
        }
    }
}
