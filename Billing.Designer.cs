namespace Supplier
{
    partial class Billing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LogoutBilling = new System.Windows.Forms.Button();
            this.PartyName = new System.Windows.Forms.TextBox();
            this.ResetBill = new System.Windows.Forms.Button();
            this.DeleteBill = new System.Windows.Forms.Button();
            this.AddBill = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DiscountBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBill = new System.Windows.Forms.ComboBox();
            this.BillDataGridView = new System.Windows.Forms.DataGridView();
            this.S_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Proceed = new System.Windows.Forms.Button();
            this.TotalBill = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.LogoutBilling);
            this.panel1.Controls.Add(this.PartyName);
            this.panel1.Controls.Add(this.ResetBill);
            this.panel1.Controls.Add(this.DeleteBill);
            this.panel1.Controls.Add(this.AddBill);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DiscountBill);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.QuantityBill);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NameBill);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 150);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(457, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // LogoutBilling
            // 
            this.LogoutBilling.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LogoutBilling.FlatAppearance.BorderSize = 0;
            this.LogoutBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBilling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBilling.Location = new System.Drawing.Point(564, 16);
            this.LogoutBilling.Name = "LogoutBilling";
            this.LogoutBilling.Size = new System.Drawing.Size(92, 25);
            this.LogoutBilling.TabIndex = 16;
            this.LogoutBilling.Text = "Logout";
            this.LogoutBilling.UseVisualStyleBackColor = false;
            this.LogoutBilling.Click += new System.EventHandler(this.LogoutBilling_Click);
            // 
            // PartyName
            // 
            this.PartyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyName.Location = new System.Drawing.Point(56, 16);
            this.PartyName.Name = "PartyName";
            this.PartyName.Size = new System.Drawing.Size(395, 26);
            this.PartyName.TabIndex = 15;
            // 
            // ResetBill
            // 
            this.ResetBill.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ResetBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBill.ForeColor = System.Drawing.Color.Maroon;
            this.ResetBill.Location = new System.Drawing.Point(443, 113);
            this.ResetBill.Name = "ResetBill";
            this.ResetBill.Size = new System.Drawing.Size(214, 32);
            this.ResetBill.TabIndex = 14;
            this.ResetBill.Text = "Reset";
            this.ResetBill.UseVisualStyleBackColor = false;
            this.ResetBill.Click += new System.EventHandler(this.ResetBill_Click);
            // 
            // DeleteBill
            // 
            this.DeleteBill.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DeleteBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBill.Location = new System.Drawing.Point(223, 113);
            this.DeleteBill.Name = "DeleteBill";
            this.DeleteBill.Size = new System.Drawing.Size(214, 32);
            this.DeleteBill.TabIndex = 14;
            this.DeleteBill.Text = "Delete";
            this.DeleteBill.UseVisualStyleBackColor = false;
            this.DeleteBill.Click += new System.EventHandler(this.DeleteBill_Click);
            // 
            // AddBill
            // 
            this.AddBill.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBill.Location = new System.Drawing.Point(3, 113);
            this.AddBill.Name = "AddBill";
            this.AddBill.Size = new System.Drawing.Size(214, 32);
            this.AddBill.TabIndex = 14;
            this.AddBill.Text = "Add";
            this.AddBill.UseVisualStyleBackColor = false;
            this.AddBill.Click += new System.EventHandler(this.AddBill_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SandyBrown;
            this.label6.Location = new System.Drawing.Point(561, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Discount%";
            // 
            // DiscountBill
            // 
            this.DiscountBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountBill.Location = new System.Drawing.Point(564, 75);
            this.DiscountBill.Name = "DiscountBill";
            this.DiscountBill.Size = new System.Drawing.Size(92, 26);
            this.DiscountBill.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SandyBrown;
            this.label4.Location = new System.Drawing.Point(482, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // QuantityBill
            // 
            this.QuantityBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityBill.Location = new System.Drawing.Point(485, 75);
            this.QuantityBill.Name = "QuantityBill";
            this.QuantityBill.Size = new System.Drawing.Size(73, 26);
            this.QuantityBill.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Party:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(1, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // NameBill
            // 
            this.NameBill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NameBill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NameBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBill.FormattingEnabled = true;
            this.NameBill.Location = new System.Drawing.Point(4, 73);
            this.NameBill.Name = "NameBill";
            this.NameBill.Size = new System.Drawing.Size(475, 28);
            this.NameBill.TabIndex = 8;
            // 
            // BillDataGridView
            // 
            this.BillDataGridView.AllowUserToResizeColumns = false;
            this.BillDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S_No,
            this.Quantity,
            this.Item,
            this.TP,
            this.Discount,
            this.Rate,
            this.NetAmount});
            this.BillDataGridView.Location = new System.Drawing.Point(13, 168);
            this.BillDataGridView.Name = "BillDataGridView";
            this.BillDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillDataGridView.Size = new System.Drawing.Size(659, 355);
            this.BillDataGridView.TabIndex = 1;
            // 
            // S_No
            // 
            this.S_No.HeaderText = "S.No";
            this.S_No.Name = "S_No";
            this.S_No.ReadOnly = true;
            this.S_No.Width = 50;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 70;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 205;
            // 
            // TP
            // 
            this.TP.HeaderText = "TP";
            this.TP.Name = "TP";
            this.TP.ReadOnly = true;
            this.TP.Width = 80;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Dis%";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 50;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 80;
            // 
            // NetAmount
            // 
            this.NetAmount.HeaderText = "Net Amount";
            this.NetAmount.Name = "NetAmount";
            this.NetAmount.ReadOnly = true;
            this.NetAmount.Width = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.Proceed);
            this.panel2.Controls.Add(this.TotalBill);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(13, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 35);
            this.panel2.TabIndex = 9;
            // 
            // Proceed
            // 
            this.Proceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceed.ForeColor = System.Drawing.Color.White;
            this.Proceed.Location = new System.Drawing.Point(534, -1);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(127, 38);
            this.Proceed.TabIndex = 3;
            this.Proceed.Text = "Proceed";
            this.Proceed.UseVisualStyleBackColor = false;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // TotalBill
            // 
            this.TotalBill.AutoSize = true;
            this.TotalBill.BackColor = System.Drawing.Color.Transparent;
            this.TotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalBill.Location = new System.Drawing.Point(120, -4);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(39, 42);
            this.TotalBill.TabIndex = 2;
            this.TotalBill.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(3, -5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 42);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total:";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BillDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NameBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuantityBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DiscountBill;
        private System.Windows.Forms.Button ResetBill;
        private System.Windows.Forms.Button DeleteBill;
        private System.Windows.Forms.Button AddBill;
        private System.Windows.Forms.DataGridView BillDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Proceed;
        private System.Windows.Forms.TextBox PartyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAmount;
        private System.Windows.Forms.Button LogoutBilling;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}