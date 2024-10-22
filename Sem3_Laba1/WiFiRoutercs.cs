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
        public int MaxSpeed { get; set; }
        public int Range { get; set; }

        public WiFiRouter(string brand = "", string model = "", 
            string color = "", double price = 0.0, int maxSpeed = 0, int range = 0)
        : base(brand, model, color, price)
        {
            MaxSpeed = maxSpeed;
            Range = range;
        }
        public override string getInfo()
        {
            return base.getInfo() + 
                $"Max Speed: {MaxSpeed}\n" +
                $"Range: {Range}\n";
        }
    }
}