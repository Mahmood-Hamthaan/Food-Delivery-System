using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery_System.Models
{
    internal class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int RestaurantID { get; set; }
        public int? RiderID { get; set; }         // null until assigned
        public string Items { get; set; } = "";   // CSV/JSON
        public string DeliveryAddress { get; set; } = "";
        public string Status { get; set; } = "Pending"; // Pending/Accepted/Preparing/OutForDelivery/Completed/Cancelled
        public decimal TotalCost { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
