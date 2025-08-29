namespace Food_Delivery_System.View
{
    partial class DeliveryRiderDashboard
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
            this.labelAssiginedOrder = new System.Windows.Forms.Label();
            this.dataGridViewAssiginedOrder = new System.Windows.Forms.DataGridView();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssiginedOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAssiginedOrder
            // 
            this.labelAssiginedOrder.AutoSize = true;
            this.labelAssiginedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelAssiginedOrder.Location = new System.Drawing.Point(186, 42);
            this.labelAssiginedOrder.Name = "labelAssiginedOrder";
            this.labelAssiginedOrder.Size = new System.Drawing.Size(233, 32);
            this.labelAssiginedOrder.TabIndex = 7;
            this.labelAssiginedOrder.Text = "Assigined Order";
            // 
            // dataGridViewAssiginedOrder
            // 
            this.dataGridViewAssiginedOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssiginedOrder.Location = new System.Drawing.Point(42, 98);
            this.dataGridViewAssiginedOrder.Name = "dataGridViewAssiginedOrder";
            this.dataGridViewAssiginedOrder.RowHeadersWidth = 51;
            this.dataGridViewAssiginedOrder.RowTemplate.Height = 24;
            this.dataGridViewAssiginedOrder.Size = new System.Drawing.Size(570, 153);
            this.dataGridViewAssiginedOrder.TabIndex = 8;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonLogout.Location = new System.Drawing.Point(347, 272);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(220, 32);
            this.buttonLogout.TabIndex = 16;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonDone.Location = new System.Drawing.Point(94, 272);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(220, 32);
            this.buttonDone.TabIndex = 17;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            // 
            // DeliveryRiderDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 315);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.dataGridViewAssiginedOrder);
            this.Controls.Add(this.labelAssiginedOrder);
            this.Name = "DeliveryRiderDashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssiginedOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAssiginedOrder;
        private System.Windows.Forms.DataGridView dataGridViewAssiginedOrder;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonDone;
    }
}