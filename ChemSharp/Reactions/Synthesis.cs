using ChemSharp.BasicStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemSharp.Reactions
{
    public class Synthesis
    {
        public static bool IsFormedNeutralMolecule(Cation cation, Anion anion)
        {
            if (anion.Charge + cation.Charge == 0)
                return true;

            return false;
        }
    }
}
