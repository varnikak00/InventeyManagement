namespace InventeyManagement
{
    internal class Inventory
    {
        public Inventory()
        {
        }

        public System.Collections.Generic.List<Details> Rice { get; set; }
        public System.Collections.Generic.List<Details> Pulses { get; set; }
        public System.Collections.Generic.List<Details> Wheat { get; set; }
    }
}