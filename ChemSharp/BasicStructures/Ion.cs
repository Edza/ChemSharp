using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemSharp.BasicStructures
{
    public class Ion
    {
        public Ion(string element, int charge)
        {
            this.Element = element;
            this.Charge = charge;
        }

        public string Element {get; private set;}
        public int Charge { get; private set; }
    }

    public class Cation : Ion
    {
        public Cation(string element, int charge)
            : base(element, charge)
        {
            if (charge <= 0)
                throw new ArgumentException();
        }
    }

    public class Anion : Ion
    {
        public Anion(string element, int charge)
            : base(element, charge)
        {
            if (charge <= 0)
                throw new ArgumentException();
        }
    }
}
