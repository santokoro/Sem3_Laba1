using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba1.Tests
{
    [TestClass]
    public class Switch_CreatingTests
    {
        [TestMethod]
        [DataRow("Undefined", "Undefined", "red", 100.2, 5, true)]
        public void Switch_ShouldCreating(string brand, string model, string color, double price, int numPorts, bool managed)
        {

            Assert.IsNotNull(new Switch(brand, model, color, price, numPorts, managed));

        }

        [TestMethod]
        [DataRow("Undefined", "Undefined", "red", 100.2, -5, false)]
        public void Switch_NotShouldCreating(string brand, string model, string color, double price, int numPorts, bool managed)
        {
            Assert.ThrowsException<ArgumentException>(() => new Switch(brand, model, color, price, numPorts, managed));

        }
    }
}
