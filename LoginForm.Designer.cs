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
            this.lblUname = new System.Windows.Forms.Label();
            this.lblPsw = new System.Windows.Forms.Label();
            this.tbUname = new System.Windows.Forms.TextBox();
            this.tbPsw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lblAccReg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(406, 119);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(70, 16);
            this.lblUname.TabIndex = 1;
            this.lblUname.Text = "Username";
            this.lblUname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(406, 164);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(67, 16);
            this.lblPsw.TabIndex = 2;
            this.lblPsw.Text = "Password";
            // 
            // tbUname
            // 
            this.tbUname.Location = new System.Drawing.Point(506, 113);
            this.tbUname.Name = "tbUname";
            this.tbUname.Size = new System.Drawing.Size(282, 22);
            this.tbUname.TabIndex = 3;
            this.tbUname.TextChanged += new System.EventHandler(this.tbUname_TextChanged);
            // 
            // tbPsw
            // 
            this.tbPsw.Location = new System.Drawing.Point(506, 161);
            this.tbPsw.Name = "tbPsw";
            this.tbPsw.Size = new System.Drawing.Size(282, 22);
            this.tbPsw.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(506, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 39);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.lnkRegister.Click += new System.EventHandler(this.lnkRegister_Click);
            this.lnkRegister.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkRegister_MouseClick);
            // 
            // lblAccReg
            // 
            this.lblAccReg.AutoSize = true;
            this.lblAccReg.Location = new System.Drawing.Point(446, 316);
            this.lblAccReg.Name = "lblAccReg";
            this.lblAccReg.Size = new System.Drawing.Size(146, 16);
            this.lblAccReg.TabIndex = 8;
            this.lblAccReg.Text = "Don\'t have an account?";
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAccReg);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPsw);
            this.Controls.Add(this.tbUname);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblUname);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.TextBox tbUname;
        private System.Windows.Forms.TextBox tbPsw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Label lblAccReg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}