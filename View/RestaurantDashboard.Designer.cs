namespace Food_Delivery_System.View
{
    partial class RestaurantDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonViewOrder = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.labelRestaurantDashboard = new System.Windows.Forms.Label();
            this.buttonViewOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonLogout.Location = new System.Drawing.Point(104, 292);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(220, 32);
            this.buttonLogout.TabIndex = 15;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonViewOrder
            // 
            this.buttonViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonViewOrder.Location = new System.Drawing.Point(104, 174);
            this.buttonViewOrder.Name = "buttonViewOrder";
            this.buttonViewOrder.Size = new System.Drawing.Size(220, 32);
            this.buttonViewOrder.TabIndex = 14;
            this.buttonViewOrder.Text = "Menu";
            this.buttonViewOrder.UseVisualStyleBackColor = true;
            this.buttonViewOrder.Click += new System.EventHandler(this.buttonViewOrder_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonProfile.Location = new System.Drawing.Point(104, 130);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(220, 32);
            this.buttonProfile.TabIndex = 13;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // labelRestaurantDashboard
            // 
            this.labelRestaurantDashboard.AutoSize = true;
            this.labelRestaurantDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelRestaurantDashboard.Location = new System.Drawing.Point(57, 52);
            this.labelRestaurantDashboard.Name = "labelRestaurantDashboard";
            this.labelRestaurantDashboard.Size = new System.Drawing.Size(319, 32);
            this.labelRestaurantDashboard.TabIndex = 12;
            this.labelRestaurantDashboard.Text = "Restaurant Dashboard";
            // 
            // buttonViewOrders
            // 
            this.buttonViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonViewOrders.Location = new System.Drawing.Point(104, 218);
            this.buttonViewOrders.Name = "buttonViewOrders";
            this.buttonViewOrders.Size = new System.Drawing.Size(220, 32);
            this.buttonViewOrders.TabIndex = 16;
            this.buttonViewOrders.Text = "View Orders";
            this.buttonViewOrders.UseVisualStyleBackColor = true;
            this.buttonViewOrders.Click += new System.EventHandler(this.buttonViewOrders_Click);
            // 
            // RestaurantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 380);
            this.Controls.Add(this.buttonViewOrders);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonViewOrder);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.labelRestaurantDashboard);
            this.Name = "RestaurantDashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonViewOrder;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Label labelRestaurantDashboard;
        private System.Windows.Forms.Button buttonViewOrders;
    }
}