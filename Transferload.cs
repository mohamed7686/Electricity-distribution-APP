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
    public partial class Transferload : Form
    {
        Excel excel = new Excel(@"C:\Users\The Master\Desktop\mydata.xlsx", 1);
        string station = "", feeder = "";
        public Transferload(string s1 , string s2)
        {
            InitializeComponent();
            station = s1;
            feeder = s2;
            amperlabel.ForeColor = Color.Green;
            amperlabel.Text = "allowed";

            fillcombo(comboBox1, 1);
            fillcombo(comboBox2, 2);

        }

        private void exbtn_Click(object sender, EventArgs e)
        {
            excel.close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        public int findraw(string station, string feeder, string s, int j)                               // find raw function
        {

            for (int i = 2; excel.readCell(i, 1) != ""; i++)
            {
                if (excel.readCell(i, 1) == station && excel.readCell(i, j) == s && excel.readCell(i, 2) == feeder)
                {

                    return i;
                }
            }

            return -1;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = findraw(station, feeder, "كامل المغذي", 3);
            int j = findraw(comboBox1.Text, comboBox2.Text, "كامل المغذي", 3);
            if (j > 0)
            {

                int c = Convert.ToInt32(excel.readCell(i, 11));
                int v = Convert.ToInt32(excel.readCell(i, 12));
                int t = Convert.ToInt32(excel.readCell(i, 8));
                int p = Convert.ToInt32(excel.readCell(i, 9));
                int k = Convert.ToInt32(excel.readCell(i, 17));

                custtext.Text = (c + Convert.ToInt32(excel.readCell(j, 11))).ToString();
                viptext.Text = (v + Convert.ToInt32(excel.readCell(j, 12))).ToString();
                transtext.Text = (t + Convert.ToInt32(excel.readCell(j, 8))).ToString();
                pmttext.Text = (p + Convert.ToInt32(excel.readCell(j, 9))).ToString();
                amper.Text= (k + Convert.ToInt32(excel.readCell(j, 17))).ToString();

                if (Convert.ToInt32(amper.Text) > 200)
                {
                    amperlabel.ForeColor = Color.Red;
                    amperlabel.Text = " not allowed";
                }
                else
                {
                    amperlabel.ForeColor = Color.Green;
                    amperlabel.Text = "allowed";
                }
            }
            else { MessageBox.Show("element not found ", "Error"); }


        }

       

        public void fillcombo(ComboBox x, int j)                 // fill combo function
        {

            string s = "";
            for (int i = 2; excel.readCell(i, j) != ""; i++)
            {
                    s = excel.readCell(i, j);
                    if (x.FindStringExact(s) == -1)
                    {
                        x.Items.Add(s);
                        x.BeginUpdate();
                    }
                

            }

        }
    }
}
