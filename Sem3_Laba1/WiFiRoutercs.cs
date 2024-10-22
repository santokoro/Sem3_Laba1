using Laba_1_Sem3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba1
{



    class WiFiRouter : NetworkDevice

    {
        private int maxSpeed;
        private int range;

        public WiFiRouter(string brand = "", double price = 0.0, string model = "", string color = "", int maxSpeed = 0, int range = 0)
        : base(brand, price, model, color)
        {
            this.maxSpeed = maxSpeed;
            this.range = range;
        }
        public override void Print()  // Переопределенная функция для печати сведений о маршрутизаторе
        {
            base.Print();
            Console.WriteLine($"Max Speed: {maxSpeed}, Range: {range}");
        }
    }
}