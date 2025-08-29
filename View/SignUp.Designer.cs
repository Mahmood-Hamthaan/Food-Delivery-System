namespace Food_Delivery_System.View
{
    partial class SignUp
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
            this.labelSignUp = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.buttonRider = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonRestaurant = new System.Windows.Forms.Button();
            this.buttonBackToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelSignUp.Location = new System.Drawing.Point(245, 53);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(122, 32);
            this.labelSignUp.TabIndex = 0;
            this.labelSignUp.Text = "Sign Up";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.Location = new System.Drawing.Point(231, 128);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(171, 20);
            this.Role.TabIndex = 1;
            this.Role.Text = "What is Your Role?";
            // 
            // buttonRider
            // 
            this.buttonRider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonRider.Location = new System.Drawing.Point(258, 186);
            this.buttonRider.Name = "buttonRider";
            this.buttonRider.Size = new System.Drawing.Size(107, 32);
            this.buttonRider.TabIndex = 2;
            this.buttonRider.Text = "Rider";
            this.buttonRider.UseVisualStyleBackColor = true;
            this.buttonRider.Click += new System.EventHandler(this.buttonRider_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonCustomer.Location = new System.Drawing.Point(87, 186);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(107, 32);
            this.buttonCustomer.TabIndex = 3;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonRestaurant
            // 
            this.buttonRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonRestaurant.Location = new System.Drawing.Point(429, 186);
            this.buttonRestaurant.Name = "buttonRestaurant";
            this.buttonRestaurant.Size = new System.Drawing.Size(107, 32);
            this.buttonRestaurant.TabIndex = 4;
            this.buttonRestaurant.Text = "Restaurant";
            this.buttonRestaurant.UseVisualStyleBackColor = true;
            this.buttonRestaurant.Click += new System.EventHandler(this.buttonRestaurant_Click);
            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonBackToLogin.Location = new System.Drawing.Point(235, 274);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(149, 32);
            this.buttonBackToLogin.TabIndex = 5;
            this.buttonBackToLogin.Text = "Back To Login";
            this.buttonBackToLogin.UseVisualStyleBackColor = true;
            this.buttonBackToLogin.Click += new System.EventHandler(this.buttonBackToLogin_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 381);
            this.Controls.Add(this.buttonBackToLogin);
            this.Controls.Add(this.buttonRestaurant);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonRider);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.labelSignUp);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Button buttonRider;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonRestaurant;
        private System.Windows.Forms.Button buttonBackToLogin;
    }
}