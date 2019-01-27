using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace Supplier
{
    public partial class Billing : Form
    {
        Billingg B;
        Combobox CB;
        int Sno = 1;
        bool isNumeric;
        public Billing()
        {
            InitializeComponent();
        }


        public DataGridView DGV()
        {
            return BillDataGridView;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            B = new Billingg(BillDataGridView);
            CB = new Combobox(NameBill);

        }

        private void AddBill_Click(object sender, EventArgs e)
        {
            // if (NameBill.Text != "" && QuantityBill.Text != "" && DiscountBill.Text != "")
            // {
            //     if (isNumeric = int.TryParse(QuantityBill.Text, out int n))        //to make sure entered data is number not string
            //     {
            //         if (isNumeric = int.TryParse(DiscountBill.Text, out int nm))
            //         {
            //             B.Insert(Sno, NameBill.Text, Convert.ToInt32(QuantityBill.Text), Convert.ToInt32(DiscountBill.Text));
            //             TotalBill.Text = B.Total().ToString();
            //             ClearFields();
            //             Sno++;
            //         }
            //        else
            //        {
            //            MessageBox.Show("Discount must be a number");
            //            DiscountBill.Text = "";
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Quantity must be a number");
            //        QuantityBill.Text = "";
            //    }
            //}
            // else
            //     MessageBox.Show("Please Fill All Boxes(Name/Quantity/Discount)");
            
            MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath));
        }

        private void ResetBill_Click(object sender, EventArgs e)
        {
            B.Reset();
            TotalBill.Text = B.Total().ToString();
            Sno = 1;
        }

        private void DeleteBill_Click(object sender, EventArgs e)
        {
            B.Delete();
            TotalBill.Text = B.Total().ToString();
            Sno = BillDataGridView.RowCount;
            ClearFields();
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
             DialogResult DR = MessageBox.Show("Are You Sure", "Message", MessageBoxButtons.YesNo);
             if (DR == DialogResult.Yes)
             {
                 B.Update();
                 Final_Bill FB = new Final_Bill(BillDataGridView, B.Total());
                 FB.DateTime = dateTimePicker1.Text;
                 FB.PartyName = PartyName.Text;
                 FB.Show();
                 ClearFields();
                 B.Reset();
             }
            

        }

        private void LogoutBilling_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreen mS = new mainScreen();
            mS.Show();
        }

        void ClearFields()
        {
            NameBill.Text = "";
            QuantityBill.Text = "";
            DiscountBill.Text = "";
        }
    }
}
