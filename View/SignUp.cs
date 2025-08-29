using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery_System.View
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomerRegister().Show();
        }

        private void buttonRider_Click(object sender, EventArgs e)
        {
            Hide();
            new DeliveryRiderRegister().Show();
        }

        private void buttonRestaurant_Click(object sender, EventArgs e)
        {
            Hide();
            new RestaurantRegister().Show();
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }
    }
}
