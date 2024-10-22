using Laba_1_Sem3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba1
{
    public class Switch : NetworkDevice
    {
        private int numPorts; // Количество портов
        public int NumPorts {
            get
            {
                return numPorts;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Wrong argument!");
                numPorts = value;
            }
        }
        public bool Managed { get; set; }  // Управляемый или нет


        public Switch(string brand = "", string model = "", string color = "", double price = 0.0, int numPorts = 0, bool managed = false)
            : base(brand, model, color, price)
        {
            NumPorts = numPorts;
            Managed = managed;
        }
        public override string getInfo()
        {
            return base.getInfo() + $"Number of Ports: {NumPorts}\n" +
                $"Managed: {Managed}\n"; 
        }
        
    }
}