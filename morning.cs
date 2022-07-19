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
    public partial class morning : Form
    {
        string station = "", feeder = "";
        Int32 fullc = 0, fullv = 0, fullt = 0, fullp = 0;
        Int32 subc = 0, subv =0, subt =0, subp =0;
        Int32 addc=0, addv=0,addt=0, addp=0;
            Excel excel = new Excel(@"C:\Users\The Master\Desktop\mydata.xlsx", 1);
        public morning(string s1 , string s2)
        {
            InitializeComponent();
            station = s1;
            feeder = s2;
            fillcombo(comboBox1, 3);
            fillcombo(comboBox2, 3);
            fillcombo(comboBox3, 3);
            fillcombo(comboBox4, 3);
            
            int i =findraw(station, feeder, "كامل المغذي", 3);
            fullc = Convert.ToInt32(excel.readCell(i, 11));
            fullv = Convert.ToInt32(excel.readCell(i, 12));
            fullt = Convert.ToInt32(excel.readCell(i, 8));
            fullp = Convert.ToInt32(excel.readCell(i, 9));

            addc = fullc;
            addv = fullv;
            addt = fullt;
            addp = fullp;
            subc = fullc;
            subv = fullv;
            subt = fullt;
            subp = fullp;

        }

        bool dragging;
        Point offset;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset.X = e.X;
            offset.Y = e.Y;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentscreenpos = PointToScreen(e.Location);
                Location = new Point(currentscreenpos.X - offset.X, currentscreenpos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void exbtn_Click(object sender, EventArgs e)
        {
            excel.close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UNfeeder P = new UNfeeder(fullc, fullp,fullt);
            P.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transferload k = new Transferload(station, feeder);
            k.Show();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
            fillinfo(comboBox1.Text, textBox24, textBox23, textBox22, textBox21);
            subinfo(textBox24.Text, textBox23.Text, textBox22.Text, textBox21.Text);
            textBox1.Text = subc.ToString(); 
            textBox2.Text = subv.ToString();
            textBox3.Text = subt.ToString();
            textBox5.Text = subp.ToString();
            remaining(textBox24.Text, textBox23.Text, textBox22.Text, textBox21.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
            fillinfo(comboBox2.Text, textBox28, textBox27, textBox26, textBox25);
            subinfo( textBox28.Text, textBox27.Text, textBox26.Text, textBox25.Text);
            textBox8.Text = subc.ToString() ;
            textBox7.Text = subv.ToString();
            textBox6.Text = subt.ToString();
            textBox4.Text = subp.ToString();
            remaining(textBox28.Text, textBox27.Text, textBox26.Text, textBox25.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
            fillinfo(comboBox3.Text, textBox32, textBox31, textBox30, textBox29);
            subinfo( textBox32.Text, textBox31.Text, textBox30.Text, textBox29.Text);
            textBox12.Text = subc.ToString();
            textBox11.Text = subv.ToString();
            textBox10.Text = subt.ToString();
            textBox9.Text = subp.ToString();
            remaining(textBox32.Text, textBox31.Text, textBox30.Text, textBox29.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
            fillinfo(comboBox4.Text, textBox36, textBox35, textBox34, textBox33);
            subinfo( textBox36.Text, textBox35.Text, textBox34.Text, textBox33.Text);
            textBox16.Text = subc.ToString();
            textBox15.Text = subv.ToString();
            textBox14.Text = subt.ToString();
            textBox13.Text = subp.ToString();
            remaining(textBox36.Text, textBox35.Text, textBox34.Text, textBox33.Text);

        }





        public void fillcombo(ComboBox x, int j)                 // fill combo function
        {
            
            string s = "";
            for (int i = 2; excel.readCell(i, j) != ""; i++)
            {if (excel.readCell(i, 1) == station && excel.readCell(i, 2) == feeder)
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



        public int findraw(string station,string feeder , string s, int j)                               // find raw function
        {
           
            for (int i = 2; excel.readCell(i, 1) != ""; i++)
            {
                if (excel.readCell(i, 1) == station && excel.readCell(i, j) == s && excel.readCell(i,2)==feeder)
                {
                   
                    return i;
                }
            }
           
            return -1;



        }


        public void fillinfo(string s , TextBox customers , TextBox vip , TextBox trans , TextBox pmt)
        {
           
            int i = findraw(station, feeder, s, 3);
            customers.Text = excel.readCell(i, 11);
            vip.Text = excel.readCell(i, 12);
            trans.Text = excel.readCell(i, 8);
            pmt.Text = excel.readCell(i, 9);

           
        }



        public void subinfo( string c1 , string v1 , string t1 , string p1)
        {
            subc = (subc - Convert.ToInt32(c1));
            subv = (subv - Convert.ToInt32(v1));
            subt = (subt - Convert.ToInt32(t1));
            subp = (subp - Convert.ToInt32(p1));
        }




        public void remaining( string c, string v, string t, string p)
        {


            addc = (addc - Convert.ToInt32(c));
            addv = (addv - Convert.ToInt32(v));
            addt = (addt - Convert.ToInt32(t));
            addp = (addp - Convert.ToInt32(p));


            textBox20.Text = addc.ToString() ;
            textBox19.Text = addv.ToString();
            textBox18.Text = addt.ToString();
            textBox17.Text = addp.ToString();
        }

       



       




    }
}
