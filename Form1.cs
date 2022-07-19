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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainpnl.BringToFront();
            label8.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            helppnl.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            aboutpnl.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainpnl.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainpnl.BringToFront();
        }

        bool dragging;
        Point offset;
        private void mainpnl_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset.X = e.X;
            offset.Y = e.Y;
        }

        private void mainpnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentscreenpos = PointToScreen(e.Location);
                Location =new Point(currentscreenpos.X - offset.X, currentscreenpos.Y - offset.Y);
            }
        }

        private void mainpnl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "123456")
                {
                    label8.Show();
                    dashboard board = new dashboard();
                    board.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("incorrect user name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("incorrect user name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    };
}
