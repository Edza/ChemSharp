using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChemSharp.BasicStructures;
using ChemSharp.KnowledgeBase;
using ChemSharp.StructureBuilder;

namespace ChemSharp.Tests
{
    [TestClass]
    public class MoleculeBuilderTest
    {

        [TestMethod]
        public void BuildWater()
        {

            string water = MoleculeBuilder.BuildMoleculeString(PeriodicTable.Elements[ElementNames.Hydrogen],
                PeriodicTable.Elements[ElementNames.Oxygen]);

            Assert.AreEqual("H2O1", water);
        }

    }
}
