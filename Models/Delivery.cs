using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery_System.Models
{
    internal class Delivery
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int RiderID { get; set; }
        public string Status { get; set; } = "Assigned"; // Assigned/PickedUp/Delivered/Failed
        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
        public DateTime? CompletedAt { get; set; }
    }
}
