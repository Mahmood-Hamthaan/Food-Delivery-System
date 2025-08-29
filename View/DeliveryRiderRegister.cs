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

namespace Food_Delivery_System.View
{
    public partial class DeliveryRiderRegister : Form
    {
        public DeliveryRiderRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxConfiromPassword.Text)
            { MessageBox.Show("Passwords do not match."); return; }

            var id = AuthController.RegisterRider(
                textBoxUsername.Text.Trim(),
                textBoxPassword.Text,
                textBoxName.Text.Trim(),
                textBoxDiscription.Text.Trim(),
                address: ""
            );

            if (id > 0)
            {
                MessageBox.Show("Rider registered. You can login now.");
                Hide(); new Login().Show();
            }
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
