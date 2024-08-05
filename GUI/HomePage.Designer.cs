namespace ABCCarTraders.GUI
{
    partial class HomePage
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
            this.flowPanelHome = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbItemtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // flowPanelHome
            // 
            this.flowPanelHome.Location = new System.Drawing.Point(12, 122);
            this.flowPanelHome.Name = "flowPanelHome";
            this.flowPanelHome.Size = new System.Drawing.Size(1112, 606);
            this.flowPanelHome.TabIndex = 0;
            this.flowPanelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.flwpnlCar_Paint);
            // 
            // cmbItemtype
            // 
            this.cmbItemtype.BackColor = System.Drawing.Color.Transparent;
            this.cmbItemtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItemtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbItemtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbItemtype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbItemtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbItemtype.ItemHeight = 30;
            this.cmbItemtype.Location = new System.Drawing.Point(874, 80);
            this.cmbItemtype.Name = "cmbItemtype";
            this.cmbItemtype.Size = new System.Drawing.Size(250, 36);
            this.cmbItemtype.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(12, 55);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 740);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbItemtype);
            this.Controls.Add(this.flowPanelHome);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelHome;
        private Guna.UI2.WinForms.Guna2ComboBox cmbItemtype;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}