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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreen mS = new mainScreen();
            mS.Show();
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            if(adminId.Text=="jaygurudev" && adminPassword.Text == "ashokji")
            {
                this.Hide();
                Admin_Tool_Inventory ADT = new Admin_Tool_Inventory();
                ADT.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Id or Password","Message");
                adminId.Text = "";
                adminPassword.Text = "";
            }
        }
    }
}
