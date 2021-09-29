using System;

namespace InventeyManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to inventory manger system");
            InventoryManagement im = new InventoryManagement()
            {
                inventoryName = new Inventory()
                {
                    Rice = new List<Details>
                    {
                        new Details
                        {
                            name="Basmati",
                            stock=150,
                            pricePerKg=100
                        },
                        new Details
                        {
                            name="kolam",
                            stock=122,
                            pricePerKg=45
                        }
                    },
                    Pulses = new List<Details>
                    {
                        new Details
                        {
                            name="Moog",
                            stock=80,
                            pricePerKg=70
                        }
                    },
                    Wheat = new List<Details>
                    {
                        new Details
                        {
                            name="Mp",
                            stock=100,
                            pricePerKg=55
                        }
                    }
                }

            };

            String inventory = JsonConvert.SerializeObject(im);
            File.WriteAllText(@"D:\Bridgelabz lecture\Dot net\Inventory Manager\InventoryManager\Inventory.json", inventory);
            Console.WriteLine("Saved to file ");

            string file = File.ReadAllText(@"D:\Bridgelabz lecture\Dot net\Inventory Manager\InventoryManager\Inventory.json");
            var dataJson = JsonConvert.DeserializeObject<InventoryManagement>(file);
            var xyz = dataJson.inventoryName;
            int riceValue = 0;
            for (int i = 0; i < xyz.Rice.Count; i++)
            {
                riceValue = riceValue + (xyz.Rice[i].stock * xyz.Rice[i].pricePerKg);
            }
            int wheatValue = 0;
            for (int i = 0; i < xyz.Wheat.Count; i++)
            {
                wheatValue = wheatValue + (xyz.Wheat[i].stock * xyz.Wheat[i].pricePerKg);
            }
            int pulsesValue = 0;
            for (int i = 0; i < xyz.Pulses.Count; i++)
            {
                pulsesValue = pulsesValue + (xyz.Pulses[i].stock * xyz.Pulses[i].pricePerKg);
            }
            Console.WriteLine("Rice total value is {0}\nWheat total value is {1}\nPulses total value is {2}", riceValue, wheatValue, pulsesValue);
            int total = riceValue + wheatValue + pulsesValue;
            Console.WriteLine("Total inventory value is {0}", total);

        }
    }
}
        }
    }
}
