using Laba_1_Sem3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba1.Tests
{
    [TestClass]
    public class NetworkDevice_CreatingTests
    {
        [TestMethod]
        [DataRow("Undefined", "Undefined", "red", 100.2)]
        public void NetworkDevice_ShouldCreating(string brand, string model, string color, double price)
        {
            Assert.IsNotNull(new NetworkDevice(brand, model, color, price));

        }

        [TestMethod]
        [DataRow("undefined", "Undefined", "red", -100.1)]
        public void NetworkDevice_NotShouldCreating(string brand, string model, string color, double price)
        {
            Assert.ThrowsException<ArgumentException>(() => new NetworkDevice(brand, model, color, price));
        }
    }
}
