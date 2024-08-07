namespace ABCCarTraders.GUI.Controlers
{
    partial class NavBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnItemCount = new System.Windows.Forms.Label();
            this.picBoxCart = new System.Windows.Forms.PictureBox();
            this.btnLoginHome = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItemCount
            // 
            this.btnItemCount.AutoSize = true;
            this.btnItemCount.BackColor = System.Drawing.Color.Transparent;
            this.btnItemCount.Location = new System.Drawing.Point(1099, 4);
            this.btnItemCount.Name = "btnItemCount";
            this.btnItemCount.Size = new System.Drawing.Size(14, 16);
            this.btnItemCount.TabIndex = 1;
            this.btnItemCount.Text = "0";
            // 
            // picBoxCart
            // 
            this.picBoxCart.Image = global::ABCCarTraders.Properties.Resources.cart;
            this.picBoxCart.Location = new System.Drawing.Point(1049, 8);
            this.picBoxCart.Name = "picBoxCart";
            this.picBoxCart.Size = new System.Drawing.Size(62, 50);
            this.picBoxCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCart.TabIndex = 0;
            this.picBoxCart.TabStop = false;
            // 
            // btnLoginHome
            // 
            this.btnLoginHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoginHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoginHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoginHome.ForeColor = System.Drawing.Color.White;
            this.btnLoginHome.Location = new System.Drawing.Point(832, 17);
            this.btnLoginHome.Name = "btnLoginHome";
            this.btnLoginHome.Size = new System.Drawing.Size(180, 33);
            this.btnLoginHome.TabIndex = 2;
            this.btnLoginHome.Text = "Login";
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoginHome);
            this.Controls.Add(this.btnItemCount);
            this.Controls.Add(this.picBoxCart);
            this.Name = "NavBar";
            this.Size = new System.Drawing.Size(1138, 65);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCart;
        private System.Windows.Forms.Label btnItemCount;
        private Guna.UI2.WinForms.Guna2Button btnLoginHome;
    }
}
