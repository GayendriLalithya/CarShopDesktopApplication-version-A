namespace ABCCarTraders
{
    partial class LoginForm
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
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbUname = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbPsw = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPsw = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblAccReg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Location = new System.Drawing.Point(610, 316);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(69, 16);
            this.lnkRegister.TabIndex = 7;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Click Here";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            this.lnkRegister.Click += new System.EventHandler(this.lnkRegister_Click);
            this.lnkRegister.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkRegister_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCCarTraders.Properties.Resources.Car2;
            this.pictureBox1.Location = new System.Drawing.Point(6, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 358);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tbUname
            // 
            this.tbUname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUname.DefaultText = "";
            this.tbUname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUname.Location = new System.Drawing.Point(506, 74);
            this.tbUname.Name = "tbUname";
            this.tbUname.PasswordChar = '\0';
            this.tbUname.PlaceholderText = "";
            this.tbUname.SelectedText = "";
            this.tbUname.Size = new System.Drawing.Size(261, 36);
            this.tbUname.TabIndex = 10;
            // 
            // lblUname
            // 
            this.lblUname.BackColor = System.Drawing.Color.Transparent;
            this.lblUname.Location = new System.Drawing.Point(407, 83);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(66, 18);
            this.lblUname.TabIndex = 11;
            this.lblUname.Text = "Username";
            // 
            // tbPsw
            // 
            this.tbPsw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPsw.DefaultText = "";
            this.tbPsw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPsw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPsw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPsw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPsw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPsw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPsw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPsw.Location = new System.Drawing.Point(506, 144);
            this.tbPsw.Name = "tbPsw";
            this.tbPsw.PasswordChar = '\0';
            this.tbPsw.PlaceholderText = "";
            this.tbPsw.SelectedText = "";
            this.tbPsw.Size = new System.Drawing.Size(261, 36);
            this.tbPsw.TabIndex = 12;
            // 
            // lblPsw
            // 
            this.lblPsw.BackColor = System.Drawing.Color.Transparent;
            this.lblPsw.Location = new System.Drawing.Point(407, 153);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(63, 18);
            this.lblPsw.TabIndex = 13;
            this.lblPsw.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(499, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 37);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblAccReg
            // 
            this.lblAccReg.BackColor = System.Drawing.Color.Transparent;
            this.lblAccReg.Location = new System.Drawing.Point(453, 316);
            this.lblAccReg.Name = "lblAccReg";
            this.lblAccReg.Size = new System.Drawing.Size(146, 18);
            this.lblAccReg.TabIndex = 15;
            this.lblAccReg.Text = "Don\'t have an Account ?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAccReg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.tbPsw);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.tbUname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnkRegister);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbUname;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUname;
        private Guna.UI2.WinForms.Guna2TextBox tbPsw;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPsw;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccReg;
    }
}