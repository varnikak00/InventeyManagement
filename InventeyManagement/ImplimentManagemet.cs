using System;
using System.Collections.Generic;
using System.Text;

namespace InventeyManagement
{
    class ImplimentManagemet
    {
        public Inventory inventoryName { get; set; }
    }
    public class Inventory
    {
        public List<Details> Rice { get; set; }
        public List<Details> Wheat { get; set; }
        public List<Details> Pulses { get; set; }
    }

    public class Details
    {
        public string name;
        public int stock;
        public int pricePerKg;
    }

}

    
