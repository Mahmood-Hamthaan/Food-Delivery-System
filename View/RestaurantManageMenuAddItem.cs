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
using System.Xml.Linq;
using Food_Delivery_System.Models;

namespace Food_Delivery_System.View
{
    public partial class RestaurantManageMenuAddItem : Form
    {
        private int _restId => Session.CurrentUser?.ID ?? 0;

        public RestaurantManageMenuAddItem()
        {
            InitializeComponent();
            // cmbAvailability: set to "Available" / "Not Available" in designer or here:
            if (comboBoxAvailability.Items.Count == 0)
            {
                comboBoxAvailability.Items.AddRange(new[] { "Available", "Not Available" });
                comboBoxAvailability.SelectedIndex = 0;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_restId == 0) { MessageBox.Show("Not logged in."); return; }

            if (!decimal.TryParse(textBoxPrice.Text.Trim(), out var price))
            {
                MessageBox.Show("Invalid price."); return;
            }

            var item = new Food_Delivery_System.Models.MenuItem
            {
                RestaurantID = _restId,
                Name = textBoxName.Text.Trim(),
                Description = textBoxDiscription.Text.Trim(),
                Price = price,
                Available = comboBoxAvailability.Text == "Available"
            };

            if (MenuItemController.Add(item))
            {
                MessageBox.Show("Item added.");
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
