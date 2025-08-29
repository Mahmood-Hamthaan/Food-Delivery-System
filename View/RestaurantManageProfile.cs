using Food_Delivery_System.Controllers;
using Food_Delivery_System.Models;
using Org.BouncyCastle.Ocsp;
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
    public partial class RestaurantManageProfile : Form
    {
        private int restaurantUserId;
        public RestaurantManageProfile(int userID)
        {
            InitializeComponent();
            restaurantUserId = userID;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var r = new Restaurant
            {
                Name = textBoxName.Text.Trim(),
                Description = textBoxDiscription.Text.Trim(),
                Address = textBoxAddress.Text.Trim(),
                OpenTime = dateTimePickerOpeningTime.Value.TimeOfDay,
                CloseTime = dateTimePickerClosingTime.Value.TimeOfDay
            };

            if (RestaurantController.Edit(restaurantUserId, r))
                MessageBox.Show("Profile updated.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete restaurant? This cannot be undone.", "Confirm",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            if (RestaurantController.Delete(restaurantUserId))
            {
                MessageBox.Show("Restaurant deleted.");
                Session.SignOut();
                Close(); new Login().Show();
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            new RestaurantDashboard(restaurantUserId).Show();
            this.Close();
        }

        private void RestaurantManageProfile_Load_1(object sender, EventArgs e)
        {
            if (restaurantUserId == 0) { MessageBox.Show("Not logged in."); Close(); return; }

            var r = RestaurantController.GetById(restaurantUserId);
            if (r == null) { MessageBox.Show("Profile not found."); return; }

            textBoxName.Text = r.Name;
            textBoxDiscription.Text = r.Description;
            textBoxAddress.Text = r.Address;
            dateTimePickerOpeningTime.Value = DateTime.Today.Add(r.OpenTime);
            dateTimePickerClosingTime.Value = DateTime.Today.Add(r.CloseTime);
        }
    }
}
