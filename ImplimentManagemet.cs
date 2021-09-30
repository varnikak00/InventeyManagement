using System;
using System.Collections.Generic;
using System.Text;

namespace InventeyManagement
{
    class ImplimentManagemet
    {
        public class Inventory
        {
            public List<TypesOfRice> TypesOfRice;
            public List<TypesOfPulses> TypesOfPulses;
            public List<TypesOfWheat> TypesOfWheat;
        }

        public class TypesOfRice
        {
            public string name;
            public int weight;
            public int Price;
        }

        public class TypesOfPulses
        {
            public string name;
            public int weight;
            public int Price;
        }
        public class TypesOfWheat
        {
            public string name;
            public int weight;
            public int Price;
        }
    }
}
