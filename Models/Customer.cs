using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery_System.Models
{
    internal class Customer : User
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
