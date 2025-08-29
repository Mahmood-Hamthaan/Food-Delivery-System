namespace Food_Delivery_System.View
{
    partial class CustomerRestaurantList
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
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonViewMenu = new System.Windows.Forms.Button();
            this.dataGridViewRestaurantsList = new System.Windows.Forms.DataGridView();
            this.labelRestaurantsList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurantsList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonGoBack.Location = new System.Drawing.Point(401, 340);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(132, 32);
            this.buttonGoBack.TabIndex = 13;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonViewMenu
            // 
            this.buttonViewMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonViewMenu.Location = new System.Drawing.Point(242, 340);
            this.buttonViewMenu.Name = "buttonViewMenu";
            this.buttonViewMenu.Size = new System.Drawing.Size(132, 32);
            this.buttonViewMenu.TabIndex = 12;
            this.buttonViewMenu.Text = "View Menu";
            this.buttonViewMenu.UseVisualStyleBackColor = true;
            this.buttonViewMenu.Click += new System.EventHandler(this.buttonViewMenu_Click);
            // 
            // dataGridViewRestaurantsList
            // 
            this.dataGridViewRestaurantsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaurantsList.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewRestaurantsList.Name = "dataGridViewRestaurantsList";
            this.dataGridViewRestaurantsList.RowHeadersWidth = 51;
            this.dataGridViewRestaurantsList.RowTemplate.Height = 24;
            this.dataGridViewRestaurantsList.Size = new System.Drawing.Size(776, 242);
            this.dataGridViewRestaurantsList.TabIndex = 11;
            // 
            // labelRestaurantsList
            // 
            this.labelRestaurantsList.AutoSize = true;
            this.labelRestaurantsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelRestaurantsList.Location = new System.Drawing.Point(268, 30);
            this.labelRestaurantsList.Name = "labelRestaurantsList";
            this.labelRestaurantsList.Size = new System.Drawing.Size(235, 32);
            this.labelRestaurantsList.TabIndex = 14;
            this.labelRestaurantsList.Text = "Restaurants List";
            // 
            // CustomerRestaurantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.labelRestaurantsList);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonViewMenu);
            this.Controls.Add(this.dataGridViewRestaurantsList);
            this.Name = "CustomerRestaurantList";
            this.Text = "Restaurants";
            this.Load += new System.EventHandler(this.CustomerRestaurantList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurantsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonViewMenu;
        private System.Windows.Forms.DataGridView dataGridViewRestaurantsList;
        private System.Windows.Forms.Label labelRestaurantsList;
    }
}