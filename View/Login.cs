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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SessionUser user = AuthController.Login(textBoxUsername.Text.Trim(), textBoxPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            // DEBUG: verify ID made it into Session
            MessageBox.Show("Logged in as " + user.Username + " (ID=" + user.ID + ", Role=" + user.Role + ")");

            this.Hide();
            if (user.Role == "Restaurant") new RestaurantDashboard(user.ID).Show();
            else if (user.Role == "Rider") new DeliveryRiderDashboard().Show();
            else new CustomerDashboard().Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Hide();
            new SignUp().Show();
        }
    }
}
