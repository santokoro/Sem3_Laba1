using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba1.Tests
{
    [TestClass]
    public class WiFiRouter_CreatingTests
    {
        [TestMethod]
        [DataRow("Undefined", "Undefined", "red", 100.2, 500, 10)]
        public void WiFiRouter_ShouldCreating(string brand, string model, string color, double price, int maxSpeed, int range)
        {

            Assert.IsNotNull(new WiFiRouter(brand, model, color, price, maxSpeed, range));

        }

        [TestMethod]
        [DataRow("Undefined", "Undefined", "red", 100.2, -500, 10)]
        [DataRow("Undefined", "Undefined", "red", 100.2, 500, -10)]
        [DataRow("Undefined", "Undefined", "red", 100.2, -500, -10)]
        public void WiFiRouter_NotShouldCreating(string brand, string model, string color, double price, int maxSpeed, int range)
        {
            Assert.ThrowsException<ArgumentException>(() => new WiFiRouter(brand, model, color, price, maxSpeed, range));
        }
    }
}
