using Laba_1_Sem3;
using System;
using System.Collections.Generic;

namespace Sem3_Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static NetworkDevice CreateNetworkDevice()
        {
            string brand, model, color;
            
            double price;
            try
            {
                Console.WriteLine("Enter brand: ");
                brand = Console.ReadLine();
                Console.WriteLine("Enter model: ");
                model = Console.ReadLine();
                Console.WriteLine("Enter color: ");
                color = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter price: ");
                price = Convert.ToInt32(Console.ReadLine());

                return new NetworkDevice(brand, model, color, price);
            }
            catch
            {
                throw new ArgumentException("Wrong argument!");
            }
        }
        public static Switch CreateSwitch()
        {
            int numPorts, flag;
            bool managed;
            NetworkDevice device = CreateNetworkDevice();
            try
            {
                Console.WriteLine("Enter number of ports: ");
                numPorts = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter is managed(1-true, 0-false): ");
                flag = Convert.ToInt32(Console.ReadLine());
                if(flag == 0)
                {
                    managed = false;
                }
                else if(flag == 1)
                {
                    managed = true;
                }
                else
                {
                    throw new ArgumentException("Wrong Argument");
                }

                return new Switch(device.Brand, device.Model, device.Color, device.Price, numPorts, managed);
            }
            catch
            {
                throw new ArgumentException("Wrong argument!");
            }
        }

        public static WiFiRouter CreateWiFiRouter()
        {
            int maxSpeed, range;
            NetworkDevice device = CreateNetworkDevice();
            try
            {
                Console.WriteLine("Enter max speed: ");
                maxSpeed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter range: ");
                range = Convert.ToInt32(Console.ReadLine());

                return new WiFiRouter(device.Brand, device.Model, device.Color, device.Price, maxSpeed, range);
            }
            catch
            {
                throw new ArgumentException("Wrong argument!");
            }

        }
        static void PrintDevices(List<NetworkDevice> devices)
        {
            foreach (var device in devices)
            {
                Console.WriteLine(device.getInfo());
            }
        }

        static void Menu()
        {
            List<NetworkDevice> devices = new List<NetworkDevice>();
            int choice = -1;

            do
            {
                Console.WriteLine("Menu:\n" +
                    "1. Add Switch\n" +
                    "2. Add WiFi Router\n" +
                    "3. Print all devices\n" +
                    "0. Exit\n" +
                    "Enter choice: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            devices.Add(CreateSwitch());
                            Console.Clear();
                            break;
                        case 2:
                            devices.Add(CreateWiFiRouter());
                            Console.Clear();
                            break;
                        case 3:
                            PrintDevices(devices);
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.\n");
                            break;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid data. Try again.\n");
                    continue;
                }

            } while (choice != 0);
        }

        
    }   
}