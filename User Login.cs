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
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }
        private void BackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreen mS = new mainScreen();
            mS.Show();
        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            if (userId.Text == "" && userPassword.Text == "")
            {
                this.Hide();
                Billing B = new Billing();
                B.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Id or Password", "Message");
                userId.Text = "";
                userPassword.Text = "";
            }
        }
    }
}
