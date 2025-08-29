namespace Food_Delivery_System.View
{
    partial class CustomerPlaceOrder
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
            this.labelRestaurantMenu = new System.Windows.Forms.Label();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dataGridViewFoodMenu = new System.Windows.Forms.DataGridView();
            this.lableFoodList = new System.Windows.Forms.Label();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.labelCart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRestaurantMenu
            // 
            this.labelRestaurantMenu.AutoSize = true;
            this.labelRestaurantMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelRestaurantMenu.Location = new System.Drawing.Point(189, 30);
            this.labelRestaurantMenu.Name = "labelRestaurantMenu";
            this.labelRestaurantMenu.Size = new System.Drawing.Size(246, 32);
            this.labelRestaurantMenu.TabIndex = 18;
            this.labelRestaurantMenu.Text = "Restaurant Menu";
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonAddToCart.Location = new System.Drawing.Point(509, 320);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(132, 32);
            this.buttonAddToCart.TabIndex = 17;
            this.buttonAddToCart.Text = "Add To Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonRemove.Location = new System.Drawing.Point(509, 511);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(132, 32);
            this.buttonRemove.TabIndex = 16;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // dataGridViewFoodMenu
            // 
            this.dataGridViewFoodMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoodMenu.Location = new System.Drawing.Point(13, 103);
            this.dataGridViewFoodMenu.Name = "dataGridViewFoodMenu";
            this.dataGridViewFoodMenu.RowHeadersWidth = 51;
            this.dataGridViewFoodMenu.RowTemplate.Height = 24;
            this.dataGridViewFoodMenu.Size = new System.Drawing.Size(628, 211);
            this.dataGridViewFoodMenu.TabIndex = 15;
            // 
            // lableFoodList
            // 
            this.lableFoodList.AutoSize = true;
            this.lableFoodList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableFoodList.Location = new System.Drawing.Point(13, 80);
            this.lableFoodList.Name = "lableFoodList";
            this.lableFoodList.Size = new System.Drawing.Size(88, 20);
            this.lableFoodList.TabIndex = 19;
            this.lableFoodList.Text = "Food List";
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonPlaceOrder.Location = new System.Drawing.Point(141, 564);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(132, 32);
            this.buttonPlaceOrder.TabIndex = 20;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonGoBack.Location = new System.Drawing.Point(361, 564);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(132, 32);
            this.buttonGoBack.TabIndex = 21;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(13, 381);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowTemplate.Height = 24;
            this.dataGridViewCart.Size = new System.Drawing.Size(628, 124);
            this.dataGridViewCart.TabIndex = 22;
            // 
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCart.Location = new System.Drawing.Point(13, 358);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(45, 20);
            this.labelCart.TabIndex = 23;
            this.labelCart.Text = "Cart";
            // 
            // CustomerPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 627);
            this.Controls.Add(this.labelCart);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.lableFoodList);
            this.Controls.Add(this.labelRestaurantMenu);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dataGridViewFoodMenu);
            this.Name = "CustomerPlaceOrder";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.CustomerPlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRestaurantMenu;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridView dataGridViewFoodMenu;
        private System.Windows.Forms.Label lableFoodList;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Label labelCart;
    }
}