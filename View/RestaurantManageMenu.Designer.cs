namespace Food_Delivery_System.View
{
    partial class RestaurantManageMenu
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewManageMenu = new System.Windows.Forms.DataGridView();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelMenu.Location = new System.Drawing.Point(356, 31);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(89, 32);
            this.labelMenu.TabIndex = 18;
            this.labelMenu.Text = "Menu";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonRemove.Location = new System.Drawing.Point(251, 356);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(132, 32);
            this.buttonRemove.TabIndex = 17;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonAdd.Location = new System.Drawing.Point(92, 356);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 32);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewManageMenu
            // 
            this.dataGridViewManageMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageMenu.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewManageMenu.Name = "dataGridViewManageMenu";
            this.dataGridViewManageMenu.RowHeadersWidth = 51;
            this.dataGridViewManageMenu.RowTemplate.Height = 24;
            this.dataGridViewManageMenu.Size = new System.Drawing.Size(776, 242);
            this.dataGridViewManageMenu.TabIndex = 15;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonGoBack.Location = new System.Drawing.Point(572, 356);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(132, 32);
            this.buttonGoBack.TabIndex = 20;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonUpdate.Location = new System.Drawing.Point(413, 356);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(132, 32);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // RestaurantManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewManageMenu);
            this.Name = "RestaurantManageMenu";
            this.Text = "Manage Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewManageMenu;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonUpdate;
    }
}