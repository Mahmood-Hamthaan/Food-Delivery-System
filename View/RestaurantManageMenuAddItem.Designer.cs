namespace Food_Delivery_System.View
{
    partial class RestaurantManageMenuAddItem
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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDiscription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDiscription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddItem = new System.Windows.Forms.Label();
            this.comboBoxAvailability = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(203, 181);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(161, 22);
            this.textBoxPrice.TabIndex = 26;
            // 
            // textBoxDiscription
            // 
            this.textBoxDiscription.Location = new System.Drawing.Point(203, 145);
            this.textBoxDiscription.Name = "textBoxDiscription";
            this.textBoxDiscription.Size = new System.Drawing.Size(161, 22);
            this.textBoxDiscription.TabIndex = 25;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(203, 107);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 22);
            this.textBoxName.TabIndex = 24;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonGoBack.Location = new System.Drawing.Point(210, 281);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(132, 32);
            this.buttonGoBack.TabIndex = 23;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonAdd.Location = new System.Drawing.Point(60, 281);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 32);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelAvailability.Location = new System.Drawing.Point(41, 223);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(103, 20);
            this.labelAvailability.TabIndex = 19;
            this.labelAvailability.Text = "Availability : ";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelPrice.Location = new System.Drawing.Point(41, 183);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 20);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Price :";
            // 
            // labelDiscription
            // 
            this.labelDiscription.AutoSize = true;
            this.labelDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelDiscription.Location = new System.Drawing.Point(41, 143);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(110, 20);
            this.labelDiscription.TabIndex = 17;
            this.labelDiscription.Text = "Description : ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelName.Location = new System.Drawing.Point(41, 105);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 20);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Name :";
            // 
            // labelAddItem
            // 
            this.labelAddItem.AutoSize = true;
            this.labelAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddItem.Location = new System.Drawing.Point(142, 40);
            this.labelAddItem.Name = "labelAddItem";
            this.labelAddItem.Size = new System.Drawing.Size(126, 32);
            this.labelAddItem.TabIndex = 15;
            this.labelAddItem.Text = "Add Item";
            // 
            // comboBoxAvailability
            // 
            this.comboBoxAvailability.FormattingEnabled = true;
            this.comboBoxAvailability.Location = new System.Drawing.Point(203, 219);
            this.comboBoxAvailability.Name = "comboBoxAvailability";
            this.comboBoxAvailability.Size = new System.Drawing.Size(161, 24);
            this.comboBoxAvailability.TabIndex = 28;
            // 
            // RestaurantManageMenuAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 347);
            this.Controls.Add(this.comboBoxAvailability);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDiscription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAvailability);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDiscription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddItem);
            this.Name = "RestaurantManageMenuAddItem";
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDiscription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDiscription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddItem;
        private System.Windows.Forms.ComboBox comboBoxAvailability;
    }
}