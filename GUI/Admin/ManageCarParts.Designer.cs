namespace ABCCarTraders.GUI.Admin
{
    partial class ManageCarParts
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
            this.lblCarPartName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.lblPartPrice = new System.Windows.Forms.Label();
            this.lblCarPartImage = new System.Windows.Forms.Label();
            this.lblCarParttID = new System.Windows.Forms.Label();
            this.picCarPartImage = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbPartNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPartPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCarPartID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCarPartName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCarPartImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarPartName
            // 
            this.lblCarPartName.AutoSize = true;
            this.lblCarPartName.Location = new System.Drawing.Point(38, 57);
            this.lblCarPartName.Name = "lblCarPartName";
            this.lblCarPartName.Size = new System.Drawing.Size(95, 16);
            this.lblCarPartName.TabIndex = 0;
            this.lblCarPartName.Text = "Car Part Name";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(37, 103);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(83, 16);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Brand Name";
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Location = new System.Drawing.Point(38, 152);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(82, 16);
            this.lblPartNumber.TabIndex = 2;
            this.lblPartNumber.Text = "Part Number";
            // 
            // lblPartPrice
            // 
            this.lblPartPrice.AutoSize = true;
            this.lblPartPrice.Location = new System.Drawing.Point(38, 200);
            this.lblPartPrice.Name = "lblPartPrice";
            this.lblPartPrice.Size = new System.Drawing.Size(65, 16);
            this.lblPartPrice.TabIndex = 3;
            this.lblPartPrice.Text = "Part Price";
            // 
            // lblCarPartImage
            // 
            this.lblCarPartImage.AutoSize = true;
            this.lblCarPartImage.Location = new System.Drawing.Point(428, 43);
            this.lblCarPartImage.Name = "lblCarPartImage";
            this.lblCarPartImage.Size = new System.Drawing.Size(45, 16);
            this.lblCarPartImage.TabIndex = 4;
            this.lblCarPartImage.Text = "Image";
            // 
            // lblCarParttID
            // 
            this.lblCarParttID.AutoSize = true;
            this.lblCarParttID.Location = new System.Drawing.Point(38, 262);
            this.lblCarParttID.Name = "lblCarParttID";
            this.lblCarParttID.Size = new System.Drawing.Size(71, 16);
            this.lblCarParttID.TabIndex = 5;
            this.lblCarParttID.Text = "Car Part ID";
            // 
            // picCarPartImage
            // 
            this.picCarPartImage.Location = new System.Drawing.Point(500, 43);
            this.picCarPartImage.Name = "picCarPartImage";
            this.picCarPartImage.Size = new System.Drawing.Size(255, 252);
            this.picCarPartImage.TabIndex = 6;
            this.picCarPartImage.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(159, 291);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(233, 30);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(159, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(233, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(233, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(500, 337);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(255, 30);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(500, 301);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(121, 30);
            this.btnChoose.TabIndex = 16;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(627, 301);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 30);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(588, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 32);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbBrand
            // 
            this.cmbBrand.BackColor = System.Drawing.Color.Transparent;
            this.cmbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBrand.ItemHeight = 30;
            this.cmbBrand.Location = new System.Drawing.Point(159, 93);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(233, 36);
            this.cmbBrand.TabIndex = 20;
            // 
            // tbPartNumber
            // 
            this.tbPartNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPartNumber.DefaultText = "";
            this.tbPartNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPartNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPartNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPartNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPartNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPartNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPartNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPartNumber.Location = new System.Drawing.Point(159, 142);
            this.tbPartNumber.Name = "tbPartNumber";
            this.tbPartNumber.PasswordChar = '\0';
            this.tbPartNumber.PlaceholderText = "";
            this.tbPartNumber.SelectedText = "";
            this.tbPartNumber.Size = new System.Drawing.Size(233, 36);
            this.tbPartNumber.TabIndex = 21;
            // 
            // tbPartPrice
            // 
            this.tbPartPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPartPrice.DefaultText = "";
            this.tbPartPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPartPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPartPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPartPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPartPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPartPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPartPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPartPrice.Location = new System.Drawing.Point(159, 189);
            this.tbPartPrice.Name = "tbPartPrice";
            this.tbPartPrice.PasswordChar = '\0';
            this.tbPartPrice.PlaceholderText = "";
            this.tbPartPrice.SelectedText = "";
            this.tbPartPrice.Size = new System.Drawing.Size(233, 36);
            this.tbPartPrice.TabIndex = 22;
            // 
            // tbCarPartID
            // 
            this.tbCarPartID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCarPartID.DefaultText = "";
            this.tbCarPartID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCarPartID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCarPartID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCarPartID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCarPartID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCarPartID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCarPartID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCarPartID.Location = new System.Drawing.Point(159, 249);
            this.tbCarPartID.Name = "tbCarPartID";
            this.tbCarPartID.PasswordChar = '\0';
            this.tbCarPartID.PlaceholderText = "";
            this.tbCarPartID.SelectedText = "";
            this.tbCarPartID.Size = new System.Drawing.Size(233, 36);
            this.tbCarPartID.TabIndex = 23;
            // 
            // tbCarPartName
            // 
            this.tbCarPartName.Location = new System.Drawing.Point(159, 50);
            this.tbCarPartName.Multiline = true;
            this.tbCarPartName.Name = "tbCarPartName";
            this.tbCarPartName.Size = new System.Drawing.Size(233, 36);
            this.tbCarPartName.TabIndex = 24;
            // 
            // ManageCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCarPartName);
            this.Controls.Add(this.tbCarPartID);
            this.Controls.Add(this.tbPartPrice);
            this.Controls.Add(this.tbPartNumber);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.picCarPartImage);
            this.Controls.Add(this.lblCarParttID);
            this.Controls.Add(this.lblCarPartImage);
            this.Controls.Add(this.lblPartPrice);
            this.Controls.Add(this.lblPartNumber);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblCarPartName);
            this.Name = "ManageCarParts";
            this.Text = "ManageCarParts";
            ((System.ComponentModel.ISupportInitialize)(this.picCarPartImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarPartName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblPartNumber;
        private System.Windows.Forms.Label lblPartPrice;
        private System.Windows.Forms.Label lblCarPartImage;
        private System.Windows.Forms.Label lblCarParttID;
        private System.Windows.Forms.PictureBox picCarPartImage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBack;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBrand;
        private Guna.UI2.WinForms.Guna2TextBox tbPartNumber;
        private Guna.UI2.WinForms.Guna2TextBox tbPartPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbCarPartID;
        private System.Windows.Forms.TextBox tbCarPartName;
    }
}