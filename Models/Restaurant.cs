using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery_System.Models
{
    internal class Restaurant : User
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Address { get; set; } = "";
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
    }
}
