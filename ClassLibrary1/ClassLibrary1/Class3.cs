using Persons;
using Autos;
using System;
using System.Collections.Generic;
using System.Text;

namespace huurder
{
    public class Huurder : Personen
    {
        public int GehuurdeDagen { get; set; }
        public double VerbruikteBrandstof { get; set; }
        public double TotaleVerbruik
        {
            get
            {
                return BrandstofPrijsPerL * VerbruikteBrandstof;
            }
        }
        public double TotaalPrijsDagen
        {
            get
            { return HuurPrijsPerDag * GehuurdeDagen; }
        }
        public double TotaalPrijs
        { get { return TotaalPrijsDagen + TotaleVerbruik; } }

    }
}
