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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            new CustomerRestaurantList().Show();
            this.Close();
        }

        private void buttonViewOrder_Click(object sender, EventArgs e)
        {
            new CustomerViewOrder().Show();
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.SignOut();
            new Login().Show();
            this.Hide();
        }
    }
}
