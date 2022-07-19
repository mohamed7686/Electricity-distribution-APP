using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myDataBase
{
    public partial class UNfeeder : Form
    {
        Int32 customers = 0, pmt = 0, trans = 0;
        public UNfeeder(Int32 s1 ,Int32 s2 , Int32 s3)
        {
            InitializeComponent();
            customers = s1;
            pmt = s2;
            trans = s3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  p=0;

            string k = (pmt * Convert.ToInt32(fact2.Text)).ToString();
           string v= (trans * Convert.ToInt32(fact1.Text)).ToString();
            pmtf.Text = fact2.Text;
            unf.Text = fact1.Text;
            p = Convert.ToInt32(k);
            cust.Text = (p + Convert.ToInt32(v)).ToString();
            if ((pmt - Convert.ToInt32(fact2.Text)) >= 0)
            {
                textBox1.Text = (pmt - Convert.ToInt32(fact2.Text)).ToString();
            }
            else
            {
                textBox1.Text = "<0";
            }
            if((trans - Convert.ToInt32(fact1.Text))>0)
            {
                textBox2.Text = (trans - Convert.ToInt32(fact1.Text)).ToString();
            }
            else
            {
                textBox2.Text = "<0";
            }
            if ((customers - Convert.ToInt32(cust.Text)) > 0)
            {

                remainingbox.Text = (customers - Convert.ToInt32(cust.Text)).ToString();
            }
            else
            {
                remainingbox.Text = "<0";
            }
        }

        bool dragging;
        Point offset;
        private void toppnl_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset.X = e.X;
            offset.Y = e.Y;
        }

        private void toppnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentscreenpos = PointToScreen(e.Location);
                Location = new Point(currentscreenpos.X - offset.X, currentscreenpos.Y - offset.Y);
            }
        }

        private void toppnl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void exbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
