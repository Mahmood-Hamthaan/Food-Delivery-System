using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery_System.Models
{
    internal class User
    {
        public int ID { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";   // keep simple to match your DB
        public string Role { get; set; } = "Customer"; // Customer | Restaurant | Rider | Admin
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
