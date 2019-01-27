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
    public partial class mainScreen : Form
    {
        bool check;
        public mainScreen()
        {
            InitializeComponent();
            Developer_Tool DT = new Developer_Tool();
            check = DT.Check();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            if (check)
            {
                this.Hide();
                Admin_Login AL = new Admin_Login();
                AL.Show();
            }
            else
                MessageBox.Show("Contact Developer","Message");
        }

        private void User_Click(object sender, EventArgs e)
        {
            if (check)
            {
                this.Hide();
                User_Login UL = new User_Login();
                UL.Show();
            }
            else
                MessageBox.Show("Contact Developer", "Message");
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            Developer D = new Developer();
            D.Show();
        }
    }
}
