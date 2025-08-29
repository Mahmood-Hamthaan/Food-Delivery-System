using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery_System
{
    internal class SessionUser
    {
        public int ID { get; set; }
        public string Username { get; set; } = "";
        public string Role { get; set; } = "Customer"; // Customer | Restaurant | Rider | Admin
    }
}
