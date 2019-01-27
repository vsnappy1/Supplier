using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Supplier
{
    public partial class Developer_Tool : Form
    {
        public Developer_Tool()
        {
            InitializeComponent();
        }
        
        private void Work_Click(object sender, EventArgs e)
        {
            File.WriteAllText("check.text","true");
        }

        private void DontWorkk_Click(object sender, EventArgs e)
        {
            File.WriteAllText("check.text", "false");
        }

        public bool Check()
        {
            string readText = File.ReadAllText("check.text");
            if (readText == "true")
                return true;
            else if (readText == "false")
                return false;
            else
                return true;
        }

        
    }
}
