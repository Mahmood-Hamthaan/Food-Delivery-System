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

namespace Food_Delivery_System.View
{
    public partial class RestaurantManageMenu : Form
    {
        private int _restId => Session.CurrentUser?.ID ?? 0;

        public RestaurantManageMenu()
        {
            InitializeComponent();
            Load += RestaurantManageMenu_Load;
        }
        private void RestaurantManageMenu_Load(object sender, EventArgs e) => RefreshGrid();
        private void RefreshGrid()
        {
            if (_restId == 0) return;
            var list = MenuItemController.GetByRestaurant(_restId);
            dataGridViewManageMenu.DataSource = list;
            dataGridViewManageMenu.ClearSelection();
        }
        private int? SelectedItemId()
        {
            if (dataGridViewManageMenu.CurrentRow == null) return null;
            // Access the ID property via reflection or by using the cell value directly
            return (int?)dataGridViewManageMenu.CurrentRow.Cells["ID"].Value;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new RestaurantManageMenuAddItem().ShowDialog();
            RefreshGrid();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var id = SelectedItemId();
            if (id == null) { MessageBox.Show("Select an item to update."); return; }
            new RestaurantManageMenuUpdateItem(id.Value).ShowDialog();
            RefreshGrid();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var id = SelectedItemId();
            if (id == null) { MessageBox.Show("Select an item to remove."); return; }
            if (MenuItemController.Delete(id.Value)) RefreshGrid();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            new RestaurantDashboard(_restId).Show();
            this.Close();
        }
    }
}