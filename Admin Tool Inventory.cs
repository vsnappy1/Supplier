using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supplier
{
    public partial class Admin_Tool_Inventory : Form
    {
        Combobox CB;
        decimal total = 0;
        TotalStock TS= new TotalStock();

        public Admin_Tool_Inventory()
        {
            InitializeComponent();
        }

        private void BackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreen mS = new mainScreen();
            mS.Show();
        }

        public void Admin_Tool_Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_DatabaseDataSet.StockTable' table. You can move, or remove it, as needed.
            this.stockTableTableAdapter.Fill(this.stock_DatabaseDataSet.StockTable);
            RefreshTable RT = new RefreshTable(StockDataGridView);
            CB = new Combobox(Name);
            total = TS.Totalstock();
        }

        private void Add_Click   (object sender, EventArgs e)
        {
            if (Name.Text != "" && TP.Text != "" && Quantity.Text != "" && Discount.Text != "")
            {
                Add Item = new Add(Name.Text, Convert.ToDouble(TP.Text), Convert.ToInt32(Quantity.Text), Convert.ToInt32(Discount.Text));
                Item.Check();
                ClearTextFields();
                RefreshTable RT = new RefreshTable(StockDataGridView);
            }
            else
                MessageBox.Show("Please Fill All Forums To Add","Notice");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Name.Text != "" && TP.Text != "" && Quantity.Text != "" && Discount.Text != "")
            {
                Update Item = new Update(Name.Text, Convert.ToDouble(TP.Text), Convert.ToInt32(Quantity.Text), Convert.ToInt32(Discount.Text));
                Item.Check();
                ClearTextFields();
                RefreshTable RT = new RefreshTable(StockDataGridView);
            }
            else
                MessageBox.Show("Please Enter The Name To Update", "Notice");

            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(Name.Text != "")
            {
                Search Item = new Search(Name.Text);
                Item.Check();
                ClearTextFields();
            }
            else
                MessageBox.Show("Please Enter The Name To Search", "Notice");


        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (Name.Text != "")
            {
                Delete Item = new Delete(Name.Text);
                Item.Check();
                ClearTextFields();
                RefreshTable RT = new RefreshTable(StockDataGridView);
            }
            else
                MessageBox.Show("Please Enter The Name To Delete", "Notice");
        }

        private void Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search Item = new Search(Name.Text);
            if (Item.Present())
            {
                TP.Text = Item.TP();
                Quantity.Text = Item.Quantity();
                Discount.Text = Item.Discount();
            }
        }

        private void Stock_Click (object sender, EventArgs e)
        {
            MessageBox.Show("Total Stock: "+ total.ToString(),"Total Stock");
        }

        void ClearTextFields()
        {
            Name.Text = "";
            TP.Text = "";
            Quantity.Text = "";
            Discount.Text = "";
        }

    }
}
