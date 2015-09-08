using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChemSharp.BasicStructures;
using ChemSharp.Reactions;


namespace ChemSharp.Tests
{
    [TestClass]
    public class SynthesisTests
    {
        [TestMethod]
        public void GoodSynthesis()
        {
            Cation sodiumIon = new Cation("Sodium", +1);
            Anion chlorideIon = new Anion("Chloride", -1);

            Assert.AreEqual(true, Synthesis.IsFormedNeutralMolecule(sodiumIon, chlorideIon));
        }

        [TestMethod]
        public void BadSynthesis()
        {
            Cation sodiumIon = new Cation("Sodium", +2);
            Anion chlorideIon = new Anion("Chloride", -1);

            Assert.AreEqual(false, Synthesis.IsFormedNeutralMolecule(sodiumIon, chlorideIon));
        }
    }
}
