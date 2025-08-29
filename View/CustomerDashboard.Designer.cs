namespace Food_Delivery_System.View
{
    partial class CustomerDashboard
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
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.labelCustomerDashboard = new System.Windows.Forms.Label();
            this.buttonViewOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonLogout.Location = new System.Drawing.Point(101, 272);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(220, 32);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonPlaceOrder.Location = new System.Drawing.Point(101, 137);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(220, 32);
            this.buttonPlaceOrder.TabIndex = 9;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // labelCustomerDashboard
            // 
            this.labelCustomerDashboard.AutoSize = true;
            this.labelCustomerDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelCustomerDashboard.Location = new System.Drawing.Point(64, 59);
            this.labelCustomerDashboard.Name = "labelCustomerDashboard";
            this.labelCustomerDashboard.Size = new System.Drawing.Size(300, 32);
            this.labelCustomerDashboard.TabIndex = 6;
            this.labelCustomerDashboard.Text = "Customer Dashboard";
            // 
            // buttonViewOrder
            // 
            this.buttonViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonViewOrder.Location = new System.Drawing.Point(101, 181);
            this.buttonViewOrder.Name = "buttonViewOrder";
            this.buttonViewOrder.Size = new System.Drawing.Size(220, 32);
            this.buttonViewOrder.TabIndex = 10;
            this.buttonViewOrder.Text = "View Order";
            this.buttonViewOrder.UseVisualStyleBackColor = true;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 363);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonViewOrder);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.labelCustomerDashboard);
            this.Name = "CustomerDashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Label labelCustomerDashboard;
        private System.Windows.Forms.Button buttonViewOrder;
    }
}