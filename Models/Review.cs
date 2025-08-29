using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery_System.Models
{
    internal class Review
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int? RestaurantID { get; set; }
        public int? MenuItemID { get; set; }
        public int Rating { get; set; }           // 1..5
        public string Comment { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
