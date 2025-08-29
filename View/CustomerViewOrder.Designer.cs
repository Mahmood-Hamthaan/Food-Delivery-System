namespace Food_Delivery_System.View
{
    partial class CustomerViewOrder
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.labelOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(628, 124);
            this.dataGridViewOrders.TabIndex = 27;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonGoBack.Location = new System.Drawing.Point(345, 238);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(132, 32);
            this.buttonGoBack.TabIndex = 26;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonCancelOrder.Location = new System.Drawing.Point(153, 238);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(132, 32);
            this.buttonCancelOrder.TabIndex = 25;
            this.buttonCancelOrder.Text = "Cancel Order";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelOrders.Location = new System.Drawing.Point(271, 33);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(106, 32);
            this.labelOrders.TabIndex = 24;
            this.labelOrders.Text = "Orders";
            // 
            // CustomerViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 290);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.labelOrders);
            this.Name = "CustomerViewOrder";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Label labelOrders;
    }
}