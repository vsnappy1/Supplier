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


namespace Supplier
{
    public partial class Final_Bill : Form
    {
        DataGridView DGV = new DataGridView();
        double Total;
        int i;
        public string DateTime;
        public string PartyName;

        public Final_Bill(DataGridView dgv, double total)
        {
            InitializeComponent();
            DGV = dgv;
            Total = total;
        }

        private void Final_Bill_Load(object sender, EventArgs e)
        {
            FinalBillDataGridView.Rows.Add(DGV.RowCount);

            for (i = 0; i < DGV.RowCount - 1; i++)
                for (int j = 0; j < 7; j++)
                    FinalBillDataGridView.Rows[i].Cells[j].Value = DGV.Rows[i].Cells[j].Value.ToString();

            for (int j = 0; j < 7; j++)
                FinalBillDataGridView.Rows[i].Cells[j].Value = "-------------------------------------------------------------------------------------------------";

            FinalBillDataGridView.Rows[i + 1].Cells[5].Value = "TOTAL:";
            FinalBillDataGridView.Rows[i + 1].Cells[6].Value = Total;
        }

        void PrintOnPaper(string text, int textsize, FontStyle Fs, float x, float y, float width, float height, PrintPageEventArgs e)
        {
            // Create string to draw.
            String drawString = text;

            // Create font and brush.
            Font drawFont = new Font("Arial", textsize, Fs);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            // Create rectangle for drawing.

            RectangleF drawRect = new RectangleF(x, y, width, height);

            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // MessageBox.Show((BillDataGridView.RowCount * 100).ToString());
            PrintOnPaper("JAY GURU DEV", 24, FontStyle.Bold, 300, 50, 300, 50, e);
            PrintOnPaper("--------------------------------------------------------" +
                         "--------------------------------------------------------" +
                         "--------------------------------------------------------", 16, FontStyle.Regular, 0, 80, 1200, 20, e);

            PrintOnPaper("Date: " + DateTime, 16, FontStyle.Regular, 0, 120, 200, 50, e);
            PrintOnPaper("Party: " + PartyName, 20, FontStyle.Regular, 0, 150, 600, 50, e);

            Bitmap bm = new Bitmap(FinalBillDataGridView.Width, 1000);
            FinalBillDataGridView.DrawToBitmap(bm, new Rectangle(0, 200, this.FinalBillDataGridView.Width, this.FinalBillDataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);

            PrintOnPaper("Software Developed By:  Vishal Kumar Ramchand  |  Contact: 03322397045", 14, FontStyle.Italic, 80, 1050, 800, 50, e);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
