using System;
using System.Collections.Generic;

namespace SWApp
{
    class RootObject
    {
        public List<ListOfOrders> orders { get; set; }
    }

    public class ListOfOrders
    {
        public ListOfOrders order { get { return this; } }
        public DateTime datum { get; set; }
        public float locatie { get; set; }
        public bool status { get; set; }
    }


}
