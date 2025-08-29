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
    public partial class CustomerViewOrder : Form
    {
        public CustomerViewOrder()
        {
            InitializeComponent();
            Load += CustomerViewOrder_Load;
        }

        private void CustomerViewOrder_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn) { MessageBox.Show("Please login."); Close(); return; }
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            int customerId = (Session.CurrentUser != null) ? Session.CurrentUser.ID : 0;
            DataTable dt = OrderController.GetOrdersByCustomer(customerId);
            dataGridViewOrders.DataSource = dt;
            dataGridViewOrders.ClearSelection();
        }

        private int? SelectedOrderId()
        {
            if (dataGridViewOrders.CurrentRow == null) return null;
            var val = dataGridViewOrders.CurrentRow.Cells["ID"].Value;
            return val == null ? (int?)null : Convert.ToInt32(val);
        }

        private string SelectedOrderStatus()
        {
            return Convert.ToString(dataGridViewOrders.CurrentRow?.Cells["Status"]?.Value) ?? "";
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            int? id = SelectedOrderId();
            if (id == null)
            {
                MessageBox.Show("Select an order.");
                return;
            }

            string status = SelectedOrderStatus();
            if (status == "Completed" || status == "Cancelled")
            {
                MessageBox.Show("This order cannot be cancelled.");
                return;
            }

            if (OrderController.CancelOrder(id.Value))
            {
                MessageBox.Show("Order cancelled.");
                RefreshGrid();
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            new CustomerDashboard().Show();
            this.Close();
        }
    }
}
