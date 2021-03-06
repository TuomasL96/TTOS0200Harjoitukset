﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T5;

namespace T5
{
    class Radio
    {
        private const int maxÄäni = 9;
        private const int minÄäni = 0;
        private const double maxTaajuus = 26000.0;
        private const double minTaajuus = 2000.0;
        private int ääni;
        private double taajuus;
        private string tulostus;
        public bool Päällä;

        public Radio()
        {
            Päällä = false;
            ääni = minÄäni;
            taajuus = minTaajuus;
        }
        public int Ääni
        {
            get { return ääni; }
            set
            {
                if (Päällä == false)
                {
                    tulostus = "Radio ei ole päällä, äänenvoimakkuutta ei voi säätää!";
                }
                if (Päällä == true && value >= minÄäni && value <= maxÄäni)
                {
                    ääni = value;
                    tulostus = "Äänenvoimakkuus on nyt:" + string.Format((value).ToString("F1"));
                }
                if (Päällä == true && !(value >= minÄäni && value <= maxÄäni))
                {
                    tulostus = "Alle arvoa " + minÄäni + " tai yli " + maxÄäni + " ei voi asettaa";
                }
            }
        }

        public double Taajuus
        {
            get { return taajuus; }
            set
            {
                if (Päällä == false)
                {
                    tulostus = "Radio ei ole päällä, taajuutta ei voi säätää!";
                }
                if (Päällä == true && value >= minTaajuus && value <= maxTaajuus)
                {
                    taajuus = value;
                    tulostus = "Taajuutesi on nyt:" + string.Format((value).ToString("F1"));
                }
                if (Päällä == true && !(value >= minTaajuus && value <= maxTaajuus))
                {
                    tulostus = "Alle arvoa " + minTaajuus + " tai yli " + maxTaajuus + " ei voi asettaa:";
                }
            }
        }

        public string Tulostus
        {
            get { return tulostus; }
        }
    }
}
