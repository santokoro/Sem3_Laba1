using Laba_1_Sem3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba1
{
    public class WiFiRouter : NetworkDevice
    {
        private int maxSpeed;
        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Wrong argument!");
                maxSpeed = value;
            }
        }
        private int range;
        public int Range
        {
            get
            {
                return range;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Wrong argument!");
                range = value;
            }
        }

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