using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_Sem3
{
    public class NetworkDevice
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public string Color { get; set; }

        private double price;

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Wrong arguments");
                price = value;
            }
        }
        public NetworkDevice(string brand, string model, string color, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Price = price;
        }
        public virtual string getInfo()
        {
            return $"Brand: {Brand}" +
                $"\nModel: {Model}" +
                $"\nColor: {Color}" +
                $"\nPrice: {Price}\n";

        }
    };
}