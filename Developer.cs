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
    public partial class Developer : Form
    {
        public Developer()
        {
            InitializeComponent();
        }

        private void DeveloperLogin_Click(object sender, EventArgs e)
        {
            if (DeveloperId.Text == "vsnappy1" && DeveloperPassword.Text == "vsnappy1")
            {
                Developer_Tool DT = new Developer_Tool();
                DT.Show();
            }
            else
                MessageBox.Show("Incorrect Password","Warning");
        }

        private void BackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreen mS = new mainScreen();
            mS.Show();
        }
    }
}
