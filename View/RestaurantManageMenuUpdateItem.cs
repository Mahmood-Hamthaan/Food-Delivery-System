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
using System.Xml.Linq;

namespace Food_Delivery_System.View
{
    public partial class RestaurantManageMenuUpdateItem : Form
    {
        private readonly int _itemId;

        public RestaurantManageMenuUpdateItem(int itemId)
        {
            InitializeComponent();
            _itemId = itemId;

            if (comboBoxAvailability.Items.Count == 0)
            {
                comboBoxAvailability.Items.AddRange(new[] { "Available", "Not Available" });
            }

            Load += RestaurantManageMenuUpdateItem_Load;
        }
        private void RestaurantManageMenuUpdateItem_Load(object sender, EventArgs e)
        {
            var m = MenuItemController.GetById(_itemId);
            if (m == null) { MessageBox.Show("Item not found."); Close(); return; }

            textBoxName.Text = m.Name;
            textBoxDiscription.Text = m.Description;
            textBoxPrice.Text = m.Price.ToString("0.00");
            comboBoxAvailability.Text = m.Available ? "Available" : "Not Available";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxPrice.Text.Trim(), out var price))
            { MessageBox.Show("Invalid price."); return; }

            var m = new Food_Delivery_System.Models.MenuItem
            {
                Name = textBoxName.Text.Trim(),
                Description = textBoxDiscription.Text.Trim(),
                Price = price,
                Available = comboBoxAvailability.Text == "Available"
            };

            if (MenuItemController.Edit(_itemId, m))
            {
                MessageBox.Show("Item updated.");
                Close();
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            new RestaurantManageMenu().Show();
            this.Close();
        }
    }
}
