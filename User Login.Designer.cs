namespace Supplier
{
    partial class User_Login
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
            this.userLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLogin
            // 
            this.userLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLogin.Location = new System.Drawing.Point(182, 203);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(300, 26);
            this.userLogin.TabIndex = 10;
            this.userLogin.Text = "Login";
            this.userLogin.UseVisualStyleBackColor = false;
            this.userLogin.Click += new System.EventHandler(this.userLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Id";
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.Location = new System.Drawing.Point(182, 171);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(300, 26);
            this.userPassword.TabIndex = 6;
            this.userPassword.UseSystemPasswordChar = true;
            // 
            // userId
            // 
            this.userId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId.Location = new System.Drawing.Point(182, 121);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(300, 26);
            this.userId.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.BackHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 35);
            this.panel1.TabIndex = 5;
            // 
            // BackHome
            // 
            this.BackHome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackHome.FlatAppearance.BorderSize = 0;
            this.BackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackHome.ForeColor = System.Drawing.Color.White;
            this.BackHome.Location = new System.Drawing.Point(0, 0);
            this.BackHome.Name = "BackHome";
            this.BackHome.Size = new System.Drawing.Size(75, 35);
            this.BackHome.TabIndex = 1;
            this.BackHome.Text = "Back";
            this.BackHome.UseVisualStyleBackColor = false;
            this.BackHome.Click += new System.EventHandler(this.BackHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(456, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Login";
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.panel1);
            this.Name = "User_Login";
            this.Text = "User_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackHome;
        private System.Windows.Forms.Label label1;
    }
}