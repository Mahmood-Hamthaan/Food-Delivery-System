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
    public partial class CustomerPlaceOrder : Form
    {
        private readonly int _restaurantId;
        private readonly string _restaurantName;
        private BindingList<CartItem> _cart = new BindingList<CartItem>();

        public CustomerPlaceOrder(int restaurantId, string restaurantName)
        {
            InitializeComponent();
            _restaurantId = restaurantId;
            _restaurantName = restaurantName;

            this.Load += CustomerPlaceOrder_Load;
        }
        private Food_Delivery_System.Models.MenuItem SelectedMenuItem()
        {
            if (dataGridViewFoodMenu.CurrentRow == null) return null;
            return dataGridViewFoodMenu.CurrentRow.DataBoundItem as Food_Delivery_System.Models.MenuItem;
        }

        private CartItem SelectedCartRow()
        {
            if (dataGridViewCart.CurrentRow == null) return null;
            return dataGridViewCart.CurrentRow.DataBoundItem as CartItem;
        }
        private void CustomerPlaceOrder_Load(object sender, EventArgs e)
        {
            this.Text = "Menu - " + _restaurantName;
            if (this.Controls.ContainsKey("lblTitle"))
            {
                var lbl = this.Controls["lblTitle"] as Label;
                if (lbl != null) lbl.Text = "Restaurant Menu";
            }

            List<Food_Delivery_System.Models.MenuItem> menu = MenuItemController.GetByRestaurant(_restaurantId);
            dataGridViewFoodMenu.DataSource = menu;
            dataGridViewFoodMenu.ClearSelection();

            dataGridViewCart.AutoGenerateColumns = true;
            dataGridViewCart.DataSource = _cart;
            dataGridViewCart.ClearSelection();
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            Food_Delivery_System.Models.MenuItem mi = SelectedMenuItem();
            if (mi == null) { MessageBox.Show("Pick an item first."); return; }
            if (!mi.Available) { MessageBox.Show("This item is not available."); return; }

            CartItem existing = _cart.FirstOrDefault(c => c.ID == mi.ID);
            if (existing != null) existing.Qty += 1;
            else _cart.Add(new CartItem { ID = mi.ID, Name = mi.Name, Qty = 1, UnitPrice = mi.Price });

            dataGridViewCart.Refresh();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            CartItem selected = SelectedCartRow();
            if (selected == null) return;

            if (selected.Qty > 1) selected.Qty -= 1;
            else _cart.Remove(selected);

            dataGridViewCart.Refresh();
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn || Session.CurrentUser == null)
            {
                MessageBox.Show("Please login again.");
                return;
            }
            if (_cart.Count == 0) { MessageBox.Show("Cart is empty."); return; }

            var me = CustomerController.GetById(Session.CurrentUser.ID);
            if (me == null || string.IsNullOrEmpty(me.Address)) { MessageBox.Show("Customer profile missing."); return; }

            string items = string.Join("|", _cart.Select(c => string.Format("{0}:{1}:{2:0.00}", c.ID, c.Qty, c.UnitPrice)));
            decimal total = _cart.Sum(c => c.Qty * c.UnitPrice);

            Order order = new Order();
            order.CustomerID = Session.CurrentUser.ID;
            order.RestaurantID = _restaurantId;
            order.RiderID = null;
            order.Items = items;
            order.DeliveryAddress = me.Address;
            order.TotalCost = total;
            order.CreatedAt = DateTime.UtcNow;

            if (OrderController.PlaceOrder(order))
            {
                MessageBox.Show("Order placed!");
                _cart.Clear();
                this.Close();
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            new CustomerRestaurantList().Show();
            this.Close();
        }
    }
}
