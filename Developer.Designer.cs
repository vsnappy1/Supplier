namespace Supplier
{
    partial class Developer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeveloperId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeveloperPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeveloperLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.BackHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 35);
            this.panel1.TabIndex = 6;
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
            this.label1.Location = new System.Drawing.Point(467, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Developer";
            // 
            // DeveloperId
            // 
            this.DeveloperId.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperId.Location = new System.Drawing.Point(12, 120);
            this.DeveloperId.Name = "DeveloperId";
            this.DeveloperId.Size = new System.Drawing.Size(659, 29);
            this.DeveloperId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Developer Id";
            // 
            // DeveloperPassword
            // 
            this.DeveloperPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperPassword.Location = new System.Drawing.Point(12, 175);
            this.DeveloperPassword.Name = "DeveloperPassword";
            this.DeveloperPassword.Size = new System.Drawing.Size(659, 29);
            this.DeveloperPassword.TabIndex = 7;
            this.DeveloperPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // DeveloperLogin
            // 
            this.DeveloperLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DeveloperLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeveloperLogin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeveloperLogin.Location = new System.Drawing.Point(12, 221);
            this.DeveloperLogin.Name = "DeveloperLogin";
            this.DeveloperLogin.Size = new System.Drawing.Size(660, 33);
            this.DeveloperLogin.TabIndex = 9;
            this.DeveloperLogin.Text = "Login";
            this.DeveloperLogin.UseVisualStyleBackColor = false;
            this.DeveloperLogin.Click += new System.EventHandler(this.DeveloperLogin_Click);
            // 
            // Developer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.DeveloperLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeveloperPassword);
            this.Controls.Add(this.DeveloperId);
            this.Controls.Add(this.panel1);
            this.Name = "Developer";
            this.Text = "Developer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeveloperId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DeveloperPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeveloperLogin;
    }
}