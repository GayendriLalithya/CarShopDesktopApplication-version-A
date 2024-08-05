namespace ABCCarTraders.GUI.Controlers
{
    partial class CarPartCard
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
            this.pictureBoxCarPart = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnViewMore = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.lblPartNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCarPartName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarPart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCarPart
            // 
            this.pictureBoxCarPart.ImageRotate = 0F;
            this.pictureBoxCarPart.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxCarPart.Name = "pictureBoxCarPart";
            this.pictureBoxCarPart.Size = new System.Drawing.Size(258, 209);
            this.pictureBoxCarPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarPart.TabIndex = 0;
            this.pictureBoxCarPart.TabStop = false;
            this.pictureBoxCarPart.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnViewMore
            // 
            this.btnViewMore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewMore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewMore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewMore.ForeColor = System.Drawing.Color.White;
            this.btnViewMore.Location = new System.Drawing.Point(147, 316);
            this.btnViewMore.Name = "btnViewMore";
            this.btnViewMore.Size = new System.Drawing.Size(121, 35);
            this.btnViewMore.TabIndex = 14;
            this.btnViewMore.Text = "View More";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(11, 316);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(130, 35);
            this.btnAddToCart.TabIndex = 13;
            this.btnAddToCart.Text = "Add To Cart";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaceOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(11, 357);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(257, 36);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            // 
            // lblPartNo
            // 
            this.lblPartNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPartNo.Location = new System.Drawing.Point(21, 279);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(78, 18);
            this.lblPartNo.TabIndex = 11;
            this.lblPartNo.Text = "Part Number";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(185, 279);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 18);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Location = new System.Drawing.Point(185, 241);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(39, 18);
            this.lblBrand.TabIndex = 9;
            this.lblBrand.Text = "Brand";
            // 
            // lblCarPartName
            // 
            this.lblCarPartName.BackColor = System.Drawing.Color.Transparent;
            this.lblCarPartName.Location = new System.Drawing.Point(21, 241);
            this.lblCarPartName.Name = "lblCarPartName";
            this.lblCarPartName.Size = new System.Drawing.Size(91, 18);
            this.lblCarPartName.TabIndex = 8;
            this.lblCarPartName.Text = "Car Part Name";
            // 
            // CarPartCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewMore);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblPartNo);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblCarPartName);
            this.Controls.Add(this.pictureBoxCarPart);
            this.Name = "CarPartCard";
            this.Size = new System.Drawing.Size(279, 405);
            this.Load += new System.EventHandler(this.CarPartCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxCarPart;
        private Guna.UI2.WinForms.Guna2Button btnViewMore;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPartNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCarPartName;
    }
}
