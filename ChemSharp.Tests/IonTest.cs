using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChemSharp.BasicStructures;

namespace ChemSharp.Tests
{
    [TestClass]
    public class IonTest
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BadCation()
        {
            var cation = new Cation("Sodium", +1);
        }
    }
}
