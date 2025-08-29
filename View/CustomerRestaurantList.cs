using Food_Delivery_System.Controllers;
using Food_Delivery_System.Models;
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
    public partial class CustomerRestaurantList : Form
    {
        public CustomerRestaurantList()
        {
            InitializeComponent();
            Load += CustomerRestaurantList_Load;
        }

        private void CustomerRestaurantList_Load(object sender, EventArgs e)
        {
            var list = RestaurantController.GetAll();
            dataGridViewRestaurantsList.DataSource = list;
            dataGridViewRestaurantsList.ClearSelection();
            if (dataGridViewRestaurantsList.Columns["Password"] != null) dataGridViewRestaurantsList.Columns["Password"].Visible = false;
            if (dataGridViewRestaurantsList.Columns["Role"] != null) dataGridViewRestaurantsList.Columns["Role"].Visible = false;
            if (dataGridViewRestaurantsList.Columns["CreatedAt"] != null) dataGridViewRestaurantsList.Columns["CreatedAt"].Visible = false;
            if (dataGridViewRestaurantsList.Columns["Username"] != null) dataGridViewRestaurantsList.Columns["Username"].Visible = false;
            if (dataGridViewRestaurantsList.Columns["ID"] != null) dataGridViewRestaurantsList.Columns["ID"].HeaderText = "RestaurantID";
        }

        private int? SelectedRestaurantId()
        {
            if (dataGridViewRestaurantsList.CurrentRow == null) return null;
            // bound to Restaurant object:
            if (dataGridViewRestaurantsList.CurrentRow.DataBoundItem is Restaurant r) return r.ID;
            // or by column:
            return dataGridViewRestaurantsList.CurrentRow.Cells["ID"]?.Value as int?;
        }

        private string SelectedRestaurantName()
        {
            if (dataGridViewRestaurantsList.CurrentRow?.DataBoundItem is Restaurant r) return r.Name;
            return Convert.ToString(dataGridViewRestaurantsList.CurrentRow?.Cells["Name"]?.Value) ?? "";
        }

        private void buttonViewMenu_Click(object sender, EventArgs e)
        {
            var restId = SelectedRestaurantId();
            if (restId == null) { MessageBox.Show("Please select a restaurant."); return; }
            new CustomerPlaceOrder(restId.Value, SelectedRestaurantName()).Show();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            new CustomerDashboard().Show();
            this.Close();
        }
    }
}
