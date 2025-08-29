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
    public partial class RestaurantDashboard : Form
    {
        private int restaurantUserId;
        public RestaurantDashboard(int userID)
        {
            InitializeComponent();
            restaurantUserId = userID;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            new RestaurantManageProfile(restaurantUserId).Show();
            this.Hide();
        }

        private void buttonViewOrder_Click(object sender, EventArgs e)
        {
            new RestaurantManageMenu().Show();
            this.Hide();
        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            new RestaurantOrders().Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.SignOut();
            Hide(); new Login().Show();
        }
    }
}
