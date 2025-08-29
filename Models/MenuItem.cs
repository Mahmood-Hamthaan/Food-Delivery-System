using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Food_Delivery_System.Models
{
    internal class MenuItem
    {
        public int ID { get; set; }
        public int RestaurantID { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public bool Available { get; set; } = true;
    }
}
