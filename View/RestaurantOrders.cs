using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Delivery_System.Controllers;
using Food_Delivery_System.Models;

namespace Food_Delivery_System.View
{
    public partial class RestaurantOrders : Form
    {
        private int _restId => Session.CurrentUser?.ID ?? 0;

        public RestaurantOrders()
        {
            InitializeComponent();
            Load += RestaurantOrders_Load;
        }
        private void RestaurantOrders_Load(object sender, EventArgs e)
        {
            if (_restId == 0) { MessageBox.Show("Not logged in."); Close(); return; }

            DataTable dt = OrderController.GetOrdersByRestaurant(_restId);
            dataGridViewOrders.DataSource = dt;   // dgvOrders is the gray DataGridView in your screenshot
            dataGridViewOrders.ClearSelection();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            new RestaurantDashboard(_restId).Show();
            this.Close();
        }
    }
}
