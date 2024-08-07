namespace ABCCarTraders.GUI.Admin
{
    partial class ManageBrands
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
            this.picBrandImage = new System.Windows.Forms.PictureBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblBrandImg = new System.Windows.Forms.Label();
            this.btnImgChoose = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsertBrand = new System.Windows.Forms.Button();
            this.btnUpdateBrand = new System.Windows.Forms.Button();
            this.btnSearchBrand = new System.Windows.Forms.Button();
            this.btnDeleteBrand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbBrandName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBrandID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBrandImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBrandImage
            // 
            this.picBrandImage.Location = new System.Drawing.Point(165, 118);
            this.picBrandImage.Name = "picBrandImage";
            this.picBrandImage.Size = new System.Drawing.Size(229, 213);
            this.picBrandImage.TabIndex = 0;
            this.picBrandImage.TabStop = false;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(56, 69);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(83, 16);
            this.lblBrandName.TabIndex = 1;
            this.lblBrandName.Text = "Brand Name";
            // 
            // lblBrandImg
            // 
            this.lblBrandImg.AutoSize = true;
            this.lblBrandImg.Location = new System.Drawing.Point(56, 122);
            this.lblBrandImg.Name = "lblBrandImg";
            this.lblBrandImg.Size = new System.Drawing.Size(84, 16);
            this.lblBrandImg.TabIndex = 2;
            this.lblBrandImg.Text = "Brand Image";
            // 
            // btnImgChoose
            // 
            this.btnImgChoose.Location = new System.Drawing.Point(165, 337);
            this.btnImgChoose.Name = "btnImgChoose";
            this.btnImgChoose.Size = new System.Drawing.Size(109, 32);
            this.btnImgChoose.TabIndex = 3;
            this.btnImgChoose.Text = "Choose";
            this.btnImgChoose.UseVisualStyleBackColor = true;
            this.btnImgChoose.Click += new System.EventHandler(this.btnImgChoose_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(285, 337);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 32);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsertBrand
            // 
            this.btnInsertBrand.Location = new System.Drawing.Point(165, 389);
            this.btnInsertBrand.Name = "btnInsertBrand";
            this.btnInsertBrand.Size = new System.Drawing.Size(229, 31);
            this.btnInsertBrand.TabIndex = 6;
            this.btnInsertBrand.Text = "Insert";
            this.btnInsertBrand.UseVisualStyleBackColor = true;
            this.btnInsertBrand.Click += new System.EventHandler(this.btnInsertBrand_Click);
            // 
            // btnUpdateBrand
            // 
            this.btnUpdateBrand.Location = new System.Drawing.Point(529, 165);
            this.btnUpdateBrand.Name = "btnUpdateBrand";
            this.btnUpdateBrand.Size = new System.Drawing.Size(219, 31);
            this.btnUpdateBrand.TabIndex = 7;
            this.btnUpdateBrand.Text = "Update";
            this.btnUpdateBrand.UseVisualStyleBackColor = true;
            this.btnUpdateBrand.Click += new System.EventHandler(this.btnUpdateBrand_Click);
            // 
            // btnSearchBrand
            // 
            this.btnSearchBrand.Location = new System.Drawing.Point(529, 115);
            this.btnSearchBrand.Name = "btnSearchBrand";
            this.btnSearchBrand.Size = new System.Drawing.Size(219, 31);
            this.btnSearchBrand.TabIndex = 8;
            this.btnSearchBrand.Text = "Search";
            this.btnSearchBrand.UseVisualStyleBackColor = true;
            this.btnSearchBrand.Click += new System.EventHandler(this.btnSearchBrand_Click);
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.Location = new System.Drawing.Point(529, 213);
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Size = new System.Drawing.Size(219, 31);
            this.btnDeleteBrand.TabIndex = 9;
            this.btnDeleteBrand.Text = "Delete";
            this.btnDeleteBrand.UseVisualStyleBackColor = true;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Brand Id";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(581, 388);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 32);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbBrandName
            // 
            this.tbBrandName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBrandName.DefaultText = "";
            this.tbBrandName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBrandName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBrandName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBrandName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBrandName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBrandName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbBrandName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBrandName.Location = new System.Drawing.Point(165, 59);
            this.tbBrandName.Name = "tbBrandName";
            this.tbBrandName.PasswordChar = '\0';
            this.tbBrandName.PlaceholderText = "";
            this.tbBrandName.SelectedText = "";
            this.tbBrandName.Size = new System.Drawing.Size(229, 36);
            this.tbBrandName.TabIndex = 13;
            // 
            // tbBrandID
            // 
            this.tbBrandID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBrandID.DefaultText = "";
            this.tbBrandID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBrandID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBrandID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBrandID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBrandID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBrandID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbBrandID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBrandID.Location = new System.Drawing.Point(529, 58);
            this.tbBrandID.Name = "tbBrandID";
            this.tbBrandID.PasswordChar = '\0';
            this.tbBrandID.PlaceholderText = "";
            this.tbBrandID.SelectedText = "";
            this.tbBrandID.Size = new System.Drawing.Size(219, 36);
            this.tbBrandID.TabIndex = 14;
            // 
            // ManageBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbBrandID);
            this.Controls.Add(this.tbBrandName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteBrand);
            this.Controls.Add(this.btnSearchBrand);
            this.Controls.Add(this.btnUpdateBrand);
            this.Controls.Add(this.btnInsertBrand);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnImgChoose);
            this.Controls.Add(this.lblBrandImg);
            this.Controls.Add(this.lblBrandName);
            this.Controls.Add(this.picBrandImage);
            this.Name = "ManageBrands";
            this.Text = "ManageBrands";
            ((System.ComponentModel.ISupportInitialize)(this.picBrandImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBrandImage;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblBrandImg;
        private System.Windows.Forms.Button btnImgChoose;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsertBrand;
        private System.Windows.Forms.Button btnUpdateBrand;
        private System.Windows.Forms.Button btnSearchBrand;
        private System.Windows.Forms.Button btnDeleteBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private Guna.UI2.WinForms.Guna2TextBox tbBrandName;
        private Guna.UI2.WinForms.Guna2TextBox tbBrandID;
    }
}