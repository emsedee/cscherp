using Persons;
using Autos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bestuurder
{
    class Verhuurder : Personen
    {
        public string Carlocation { get; set; }
        public double Kosten { get; set; }
        public double Afschrijvingen { get; set; }
        public bool BetalingFactuurOntvangen { get; set; }
        public double Kostprijs
        {
            get
            { return Kosten - Afschrijvingen; }
        }
    }
}
