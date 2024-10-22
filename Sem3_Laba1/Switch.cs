using Laba_1_Sem3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba1
{



    class Switch : NetworkDevice
    {
        public int numPorts { get; set; }  // Количество портов
        public bool managed { get; set; }  // Управляемый или нет


        public Switch(string brand = "", double price = 0.0, string model = "", string color = "", int numPorts = 0, bool managed = false)
            : base(brand, price, model, color)
        {
            this.numPorts = numPorts;
            this.managed = managed;
        }
        public override void Print()  // Переопределенная функция для печати сведений о коммутаторе
        {
            base.Print();
            Console.WriteLine($"Number of Ports: {numPorts}, Managed: {managed}");
        }
    }
}