using Food_Delivery_System.Controllers;
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
    public partial class DeliveryRiderDashboard : Form
    {
        public DeliveryRiderDashboard()
        {
            InitializeComponent();
        }

        private void DeliveryRiderDashboard_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn) { MessageBox.Show("Please login."); Close(); return; }
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            int riderId = Session.CurrentUser != null ? Session.CurrentUser.ID : 0;
            DataTable dt = OrderController.GetOrdersByRider(riderId);
            dataGridViewAssiginedOrder.DataSource = dt;
        }

        private int? SelectedOrderId()
        {
            if (dataGridViewAssiginedOrder.CurrentRow == null) return null;
            var val = dataGridViewAssiginedOrder.CurrentRow.Cells["ID"].Value;
            return val == null ? (int?)null : Convert.ToInt32(val);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            var id = SelectedOrderId();
            if (id == null) { MessageBox.Show("Select an order."); return; }

            if (DeliveryController.UpdateDeliveryStatus(id.Value, "Delivered"))
            {
                MessageBox.Show("Delivery completed.");
                RefreshGrid();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.SignOut();
            Hide(); new Login().Show();
        }
    }
}
