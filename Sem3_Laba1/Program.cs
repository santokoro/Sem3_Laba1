using System;
using System.Collections.Generic;

namespace Sem3_Laba1
{
    public class ComputerDevice
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
                if (value < 0) throw new ArgumentException("Wrong argument!");
                price = value;
            }
        }

        public ComputerDevice(string brand = "Unknown", string model = "Unknown", string color = "Unknown", double price = 0.0)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Price = price;
        }

        public virtual string Info()
        {
            return $"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Color: {Color}\n" +
                $"Price: {Price}$\n";
        }
    }

    public class Laptop : ComputerDevice
    {
        public double Weight { get; set; }
        public int BatteryLife { get; set; }  // Время автономной работы в часах

        public Laptop(string brand = "Unknown", string model = "Unknown", string color = "Unknown", double price = 0.0, double weight = 0.0, int batteryLife = 0)
            : base(brand, model, color, price)
        {
            Weight = weight;
            BatteryLife = batteryLife;
        }

        public override string Info()
        {
            return base.Info() +
                $"Weight: {Weight} kg\n" +
                $"Battery Life: {BatteryLife} hours\n";
        }
    }

    public class Server : ComputerDevice
    {
        public int NumProcessors { get; set; }  // Количество процессоров
        public int StorageCapacity { get; set; }  // Объем памяти в Гб

        public Server(string brand = "Unknown", string model = "Unknown", string color = "Unknown", double price = 0.0, int numProcessors = 0, int storageCapacity = 0)
            : base(brand, model, color, price)
        {
            NumProcessors = numProcessors;
            StorageCapacity = storageCapacity;
        }

        public override string Info()
        {
            return base.Info() +
                $"Number of Processors: {NumProcessors}\n" +
                $"Storage Capacity: {StorageCapacity} GB\n";
        }
    }
}