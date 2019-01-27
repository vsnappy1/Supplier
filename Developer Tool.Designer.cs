namespace Supplier
{
    partial class Developer_Tool
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
            this.Work = new System.Windows.Forms.Button();
            this.DontWorkk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Work
            // 
            this.Work.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Work.FlatAppearance.BorderSize = 0;
            this.Work.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Work.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Work.ForeColor = System.Drawing.Color.White;
            this.Work.Location = new System.Drawing.Point(18, 51);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(320, 204);
            this.Work.TabIndex = 2;
            this.Work.Text = "Work";
            this.Work.UseVisualStyleBackColor = false;
            this.Work.Click += new System.EventHandler(this.Work_Click);
            // 
            // DontWorkk
            // 
            this.DontWorkk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DontWorkk.FlatAppearance.BorderSize = 0;
            this.DontWorkk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DontWorkk.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DontWorkk.ForeColor = System.Drawing.Color.White;
            this.DontWorkk.Location = new System.Drawing.Point(344, 51);
            this.DontWorkk.Name = "DontWorkk";
            this.DontWorkk.Size = new System.Drawing.Size(320, 204);
            this.DontWorkk.TabIndex = 2;
            this.DontWorkk.Text = "Don\'t Work";
            this.DontWorkk.UseVisualStyleBackColor = false;
            this.DontWorkk.Click += new System.EventHandler(this.DontWorkk_Click);
            // 
            // Developer_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.DontWorkk);
            this.Controls.Add(this.Work);
            this.Name = "Developer_Tool";
            this.Text = "Developer_Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Work;
        private System.Windows.Forms.Button DontWorkk;
    }
}