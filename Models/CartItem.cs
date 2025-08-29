using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery_System.Models
{
    internal class CartItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal
        {
            get { return Qty * UnitPrice; }
        }

        public CartItem()
        {
            Name = "";
        }
    }
}
