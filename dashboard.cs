using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace myDataBase
{


    public partial class dashboard : Form
    {
        Excel excel = new Excel(@"C:\Users\The Master\Desktop\mydata.xlsx", 1);
        public dashboard()
        {
            InitializeComponent();

            mainpnl.BringToFront();
            this.dashbtn.BackColor = System.Drawing.Color.DimGray;

            fillcombo(comboBox1, 1, 1);
            fillcombo(comboBox2, 2, 1);
            fillcombo(comboBox48, 2, 2);
            fillcombo(comboBox4, 2, 1);
            dashchartsBegin();
            titlelabel.Text = "Main Dashboard";















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
            excel.close();
            Application.Exit();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dashbtn_Click(object sender, EventArgs e)
        {
            mainpnl.BringToFront();
            titlelabel.Text = "Main Dashboard";
            this.dashbtn.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.ngbtn.BackColor = System.Drawing.Color.DarkGray;
            this.isobtn.BackColor = System.Drawing.Color.DarkGray;
            this.emailbtn.BackColor = System.Drawing.Color.DarkGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            stationpnl.BringToFront();
            titlelabel.Text = "Station Information";
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.dashbtn.BackColor = System.Drawing.Color.DarkGray;
            this.ngbtn.BackColor = System.Drawing.Color.DarkGray;
            this.isobtn.BackColor = System.Drawing.Color.DarkGray;
            this.emailbtn.BackColor = System.Drawing.Color.DarkGray;
        }

        private void ngbtn_Click(object sender, EventArgs e)
        {

            NGpnl.BringToFront();
            titlelabel.Text = "NG Outage";
            this.ngbtn.BackColor = System.Drawing.Color.DimGray;
            this.dashbtn.BackColor = System.Drawing.Color.DarkGray;
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.isobtn.BackColor = System.Drawing.Color.DarkGray;
            this.emailbtn.BackColor = System.Drawing.Color.DarkGray;
        }

        private void isobtn_Click(object sender, EventArgs e)
        {
            isolationpnl.BringToFront();
            datebox.Text = DateTime.Now.ToLongTimeString();
            titlelabel.Text = "Isolation Prosedure";
            this.isobtn.BackColor = System.Drawing.Color.DimGray;
            this.dashbtn.BackColor = System.Drawing.Color.DarkGray;
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.ngbtn.BackColor = System.Drawing.Color.DarkGray;
            this.emailbtn.BackColor = System.Drawing.Color.DarkGray;
        }

        private void emailbtn_Click(object sender, EventArgs e)
        {
            emailpnl.BringToFront();
            titlelabel.Text = "Email";
            this.emailbtn.BackColor = System.Drawing.Color.DimGray;
            this.dashbtn.BackColor = System.Drawing.Color.DarkGray;
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.ngbtn.BackColor = System.Drawing.Color.DarkGray;
            this.isobtn.BackColor = System.Drawing.Color.DarkGray;
        }



        private void morningbtn_Click(object sender, EventArgs e)
        {
            morning m = new morning(comboBox1.Text, comboBox2.Text);
            m.Show();
        }

        private void label43_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox1.Text = comboBox1.SelectedItem.ToString();
            comboBox2.Enabled = true;

            int cussum = 0, vipsum = 0, pmtsum = 0, trsum = 0;
            for (int i = 2; excel.readCell(i, 1) != ""; i++)
            {
                if (comboBox1.Text == excel.readCell(i, 1) && excel.readCell(i, 3) == "كامل المغذي")
                {

                    cussum += Convert.ToInt32(excel.readCell(i, 11));
                    vipsum += Convert.ToInt32(excel.readCell(i, 12));
                    trsum += Convert.ToInt32(excel.readCell(i, 8));
                    pmtsum += Convert.ToInt32(excel.readCell(i, 9));

                }
            }

            textBox1.Text = cussum.ToString();
            textBox2.Text = vipsum.ToString();
            textBox3.Text = trsum.ToString();
            textBox5.Text = pmtsum.ToString();



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text != "" && textBox14.Text != "" && textBox15.Text != "")
            {
                clearbtn.Enabled = true;
                reportbtn.Enabled = true;
                erbtn.Enabled = true;
            }
            else
            {
                clearbtn.Enabled = false;
                reportbtn.Enabled = false;
                erbtn.Enabled = false;
            }
        }

 

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = comboBox2.SelectedItem.ToString();

            morningbtn.Enabled = true;
            button5.Enabled = true;
            for (int i = 2; excel.readCell(i, 2) != ""; i++)
            {
                if (comboBox2.Text == excel.readCell(i, 2) && comboBox1.Text == excel.readCell(i, 1) && excel.readCell(i, 3) == "كامل المغذي")
                {
                    textBox10.Text = excel.readCell(i, 11);
                    textBox9.Text = excel.readCell(i, 12);
                    textBox8.Text = excel.readCell(i, 8);
                    textBox6.Text = excel.readCell(i, 9);
                    textBox11.Text = excel.readCell(i, 14);
                    textBox7.Text = excel.readCell(i, 15);
                    textBox4.Text = excel.readCell(i, 16);
                }
            }


        }


        public void fillcombo(ComboBox x, int j, int sheet)                 // fill combo function
        {
            excel.selectSheet(sheet);
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
            excel.selectSheet(1);

        }



        public int findraw(string station, string s, int j, int sheet)                               // find raw function returns the data raw no in excel sheet
        {
            excel.selectSheet(sheet);

            for (int i = 2; excel.readCell(i, 1) != ""; i++)
            {
                if (excel.readCell(i, 1) == station && excel.readCell(i, j) == s)
                {
                    excel.selectSheet(1);
                    return i;
                }
            }
            excel.selectSheet(1);
            return -1;



        }




        public void ngselect(ComboBox x)                                  //  special for comboboxes of ng outage
        {
            x.Text = x.SelectedText;

            if (textBox23.Text !="")
            {
                int i = 0;
                i = findraw(comboBox1.Text, x.Text, 2, 1);
                if (i > 0)
                {
                    if (i != -1)
                    {
                        int s = 0;

                        s = Convert.ToInt32(textBox23.Text) + 1;
                        textBox23.Text = s.ToString();
                        textBox27.Text = (Convert.ToInt32(textBox27.Text) + Convert.ToInt32(excel.readCell(i, 11))).ToString();
                        textBox26.Text = (Convert.ToInt32(textBox26.Text) + Convert.ToInt32(excel.readCell(i, 12))).ToString();
                        textBox25.Text = (Convert.ToInt32(textBox25.Text) + Convert.ToInt32(excel.readCell(i, 8))).ToString();
                        textBox22.Text = (Convert.ToInt32(textBox22.Text) + Convert.ToInt32(excel.readCell(i, 9))).ToString();



                        s = Convert.ToInt32(textBox21.Text) - 1;
                        textBox21.Text = s.ToString();
                        textBox20.Text = (Convert.ToInt32(textBox20.Text) - Convert.ToInt32(excel.readCell(i, 11))).ToString();
                        textBox19.Text = (Convert.ToInt32(textBox19.Text) - Convert.ToInt32(excel.readCell(i, 12))).ToString();
                        textBox18.Text = (Convert.ToInt32(textBox18.Text) - Convert.ToInt32(excel.readCell(i, 8))).ToString();
                        textBox16.Text = (Convert.ToInt32(textBox16.Text) - Convert.ToInt32(excel.readCell(i, 9))).ToString();
                        if (textBox20.Text !="" && textBox27.Text !="")
                        {
                            float k = (Convert.ToInt32(textBox20.Text) + Convert.ToInt32(textBox27.Text));
                            textBox17.Text =(getint((Convert.ToInt64(textBox20.Text) / k) * 100)).ToString() + "%";
                            textBox24.Text =(getint((Convert.ToInt64(textBox27.Text) / k) * 100)).ToString() + "%";
                        }
                        else
                        {
                            textBox17.Text = "divided by zero";
                        }
                       
                        

                    }
                }
                else { MessageBox.Show("element not found ", "Error"); }
            }

            else
            {
                int i = 0;
                i = findraw(comboBox1.Text, comboBox4.Text, 2, 1);
                if (i > 0)
                {
                    if (i != -1)
                    {

                        textBox23.Text = "1";
                        textBox27.Text = excel.readCell(i, 11);
                        textBox26.Text = excel.readCell(i, 12);
                        textBox25.Text = excel.readCell(i, 8);
                        textBox22.Text = excel.readCell(i, 9);



                        float s = 0;
                        textBox21.Text = (Convert.ToInt32(textBox21.Text) - 1).ToString();
                        textBox20.Text = (Convert.ToInt32(textBox20.Text) - Convert.ToInt32(excel.readCell(i, 11))).ToString();
                        textBox19.Text = (Convert.ToInt32(textBox19.Text) - Convert.ToInt32(excel.readCell(i, 12))).ToString();
                        textBox18.Text = (Convert.ToInt32(textBox18.Text) - Convert.ToInt32(excel.readCell(i, 8))).ToString();
                        textBox16.Text = (Convert.ToInt32(textBox16.Text) - Convert.ToInt32(excel.readCell(i, 9))).ToString();
                        if (textBox20.Text != "" && textBox27.Text != "")
                        {
                            s = (Convert.ToInt32(textBox20.Text) + Convert.ToInt32(textBox27.Text));
                            textBox17.Text =(getint((Convert.ToInt64(textBox20.Text) / s)*100)).ToString() + "%";
                            textBox24.Text =(getint((Convert.ToInt64(textBox27.Text) / s) * 100)).ToString() + "%";
                        }
                        else
                        {
                            textBox17.Text = "divided by zero";
                        }
                       

                    }
                }
                else { MessageBox.Show("element not found ", "Error"); }
            }
        }











        private void comboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {

            clearbtn.Enabled = true;
            reportbtn.Enabled = true;
            erbtn.Enabled = true;
            textBox14.Text = DateTime.Now.ToLongTimeString();
            textBox15.Text = DateTime.Now.ToShortDateString();
           
            int i = 0;
            i = findraw(comboBox1.Text, comboBox48.Text, 3, 2);
            if (i > 0)
            {
                if (i != -1)
                {
                    excel.selectSheet(2);
                    textBox21.Text = excel.readCell(i, 13);
                    textBox20.Text = excel.readCell(i, 11);
                    textBox19.Text = excel.readCell(i, 12);
                    textBox18.Text = excel.readCell(i, 8);
                    textBox16.Text = excel.readCell(i, 9);
                    textBox17.Text = "no restorated yet";
                    excel.selectSheet(1);

                }
            }
            else { MessageBox.Show("element not found ", "Error"); }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*
            */
           
        }

       

        private void clearbtn_Click(object sender, EventArgs e)
        {
            comboBox48.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox21.Text = ""; textBox23.Text = "";
            textBox20.Text = ""; textBox27.Text = "";
            textBox19.Text = ""; textBox26.Text = "";
            textBox18.Text = ""; textBox25.Text = "";
            textBox16.Text = ""; textBox22.Text = "";
            textBox17.Text = ""; textBox24.Text = "";
            listBox1.Items.Clear();
           
        }

        private void reportbtn_Click(object sender, EventArgs e)             // store the data in  mydata excel file sheet 3
        {
            excel.selectSheet(3);

            excel.writeCell(10, 3, comboBox3.Text);
            excel.writeCell(10, 5, textBox15.Text);
            excel.writeCell(11, 3, comboBox1.Text);
            excel.writeCell(11, 5, textBox14.Text);
            excel.writeCell(12, 3, comboBox48.Text);
            excel.writeCell(14, 5, textBox23.Text);
            excel.writeCell(15, 5, textBox26.Text);
            excel.writeCell(16, 5, textBox27.Text);
            excel.writeCell(17, 5, textBox21.Text);
            excel.writeCell(18, 5, textBox19.Text);
            excel.writeCell(19, 5, textBox20.Text);
            excel.save();
            
            excel.selectSheet(1);

        }

        private void erbtn_Click(object sender, EventArgs e)
        {
            Excel ex1 = new Excel(@"C:\Users\The Master\Desktop\erplan.xlsx", 1);
            ex1.show();
            
            ex1.close();
        }


        public void dashchartsBegin()
        {
            Excel ex = new Excel(@"C:\Users\The Master\Desktop\dash.xlsx", 1);
            // 
            //  max load chart
            //
            int s = Convert.ToInt32(ex.readCell(38, 9));
            this.loafchart.Series["max load"].Points.AddXY("2019", s);
            s = Convert.ToInt32(ex.readCell(38, 10));
            this.loafchart.Series["max load"].Points.AddXY("2020", s);

            s = Convert.ToInt32(ex.readCell(38, 6));
            this.loafchart.Series["load"].Points.AddXY("2019", s);
            s = Convert.ToInt32(ex.readCell(38, 7));
            this.loafchart.Series["load"].Points.AddXY("2020", s);
            precentlab.Text = ex.readCell(41, 9);
            //
            // most 5 load stations chart
            //

            
            s = Convert.ToInt32(ex.readCell(80,7));
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            this.chart1.Series["Series1"].Points.AddXY(ex.readCell(80,6),s);
            s = Convert.ToInt32(ex.readCell(81, 7));
            this.chart1.Series["Series1"].Points.AddXY(ex.readCell(81, 6), s);
            s = Convert.ToInt32(ex.readCell(82, 7));
            this.chart1.Series["Series1"].Points.AddXY(ex.readCell(82, 6), s);
            s = Convert.ToInt32(ex.readCell(83, 7));
            this.chart1.Series["Series1"].Points.AddXY(ex.readCell(83, 6), s);
            s = Convert.ToInt32(ex.readCell(84, 7));
            this.chart1.Series["Series1"].Points.AddXY(ex.readCell(84, 6), s);

            //
            //time load chart
            //
            string t,v;
            for (int j = 79; j <= 100; j++)
            {
                t = ex.readCell(j, 1);
                v = ex.readCell(j, 2);
                timechart.Series["load"].Points.AddXY(t, v);
            }
          

            //
            //most 5 trip stations
            //
            s = Convert.ToInt32(ex.readCell(55, 2));
            tripchart.Series["Series1"].IsValueShownAsLabel = true;
            this.tripchart.Series["Series1"].Points.AddXY(ex.readCell(55,1), s);
            s = Convert.ToInt32(ex.readCell(56, 2));
            this.tripchart.Series["Series1"].Points.AddXY(ex.readCell(56, 1), s);
            s = Convert.ToInt32(ex.readCell(57, 2));
            this.tripchart.Series["Series1"].Points.AddXY(ex.readCell(57, 1), s);
            s = Convert.ToInt32(ex.readCell(58, 2));
            this.tripchart.Series["Series1"].Points.AddXY(ex.readCell(58, 1), s);
            s = Convert.ToInt32(ex.readCell(59, 2));
            this.tripchart.Series["Series1"].Points.AddXY(ex.readCell(59, 1), s);
            // 
            // most 10 trip feeders  chart
            //
            for (int j = 39; j <= 49; j++)
            {
                 s = Convert.ToInt32(ex.readCell(j, 2));
                this.tripfeederschart.Series["feeder"].Points.AddXY(ex.readCell(j,1), s);
            }
            // 
            // feeders exceed load
            //
            for (int j = 63; j <= 74; j++)
            {
                s = Convert.ToInt32(ex.readCell(j, 2));
                this.exceedchart.Series["exceed"].Points.AddXY(ex.readCell(j, 1), s);
            }

            // 
            // saifi 2019
            //
            for (int j = 15; j <=21; j++)
            {
              
                this.saifi2019.Series["طارئ"].Points.AddXY(ex.readCell(j,1), ex.readCell(j, 2));
                this.saifi2019.Series["مجدول"].Points.AddXY(ex.readCell(j,1), ex.readCell(j, 3));
                this.saifi2019.Series["مجموع"].Points.AddXY(ex.readCell(j,1), ex.readCell(j, 4));
            }
            // 
            // saifi 2020
            //
            for (int j = 4; j <= 10; j++)
            {

                this.saifi2020.Series["طارئ"].Points.AddXY(ex.readCell(j, 1), ex.readCell(j, 2));
                this.saifi2020.Series["مجدول"].Points.AddXY(ex.readCell(j, 1), ex.readCell(j, 3));
                this.saifi2020.Series["مجموع"].Points.AddXY(ex.readCell(j, 1), ex.readCell(j, 4));
            }
            // 
            // saidi 2019
            //
            for (int j = 15; j <= 21; j++)
            {

                this.saidi2019.Series["طارئ"].Points.AddXY(ex.readCell(j, 1), ex.readCell(j,5));
                this.saidi2019.Series["مجدول"].Points.AddXY(ex.readCell(j, 1), ex.readCell(j, 6));
                this.saidi2019.Series["مجموع"].Points.AddXY(ex.readCell(j, 1), ex.readCell(j, 7));
            }
            // 
            // saidi 2020
            //
            for (int j = 4; j <= 10; j++)
            {

                this.saidi2020.Series["طارئ"].Points.AddXY(ex.readCell(j, 1), ex.readCell(j, 5));
                this.saidi2020.Series["مجدول"].Points.AddXY(ex.readCell(j, 1), ex.readCell(j,6));
                this.saidi2020.Series["مجموع"].Points.AddXY(ex.readCell(j, 1), ex.readCell(j,7));
            }
            // 
            // نسبة الانحراف مع 2019
            //
            for (int j = 26; j <= 32; j++)
            {

                this.chart4.Series["saifi"].Points.AddXY(ex.readCell(j, 1), ex.sumrang(j,2,j ,3));
                this.chart4.Series["saidi"].Points.AddXY(ex.readCell(j, 1), ex.sumrang(j, 4, j, 5));
                
            }
            // 
            // نسبة الانحراف مع مستهدف الهيئة حتي اغسطس
            //
            for (int j = 26; j <= 32; j++)
            {

                this.chart2.Series["saifi"].Points.AddXY(ex.readCell(j, 1), ex.sumrang(26, 6, 32, 7));
                this.chart2.Series["saidi"].Points.AddXY(ex.readCell(j, 1), ex.sumrang(26,8, 32, 9));

            }
            // 
            //نسبة الانحراف مع مستهدف  المركز الرئيس حتي اغسطس
            //
            for (int j = 26; j <= 32; j++)
            {

                this.chart5.Series["saifi"].Points.AddXY(ex.readCell(j, 1), ex.sumrang(26, 10, 32, 11));
                this.chart5.Series["saidi"].Points.AddXY(ex.readCell(j, 1), ex.sumrang(26, 12, 32, 33));

            }


            ex.close();
        }

        private void sentbtn_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.office365.com",                                    // if you want to link the app with gmail put Host ="stmp.gmail.com"
                Port = 587,                                                     // the same port number for gmail
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "mail here",                                       // put mail here
                    Password="pass here"                                          // put pass here
                }
            
            };
            MailAddress fromemail = new MailAddress("mail here ", "my data base app");        // put mail here
            MailAddress toemail = new MailAddress(addressbox.Text, "someone");                // you can put receiver name instead of "someone"
            MailMessage message = new MailMessage()
            {
                From=fromemail,
                Subject=subbox.Text,
                Body=messagebox.Text,

            };
            message.To.Add(toemail);
            client.SendCompleted += Client_SendCompleted;
            client.SendMailAsync(message);

        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show("something wrong \n " + e.Error.Message, "error");
                return;
            }
            else
            { 
               MessageBox.Show("sent successfully", "done");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.office365.com",                                                        // if you want to link the app with gmail put Host ="stmp.gmail.com"
                Port = 587,                                                                         //// the same port number for gmail
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "mail here",                                       // put mail here
                    Password = "pass here"                                          // put pass here
                }

            };
            MailAddress fromemail = new MailAddress("mail here ", "my data base app");          // put mail here
            MailAddress toemail = new MailAddress(" DESTINATION MAIL HERE", "someone");         // put destination email  and you can put receiver name instead of "someone"
            MailMessage message = new MailMessage()
            {
                From = fromemail,
                Subject = subbox.Text,
                //
                //you can change message body from here
                //
                Body = "STATION  :" + comboBox1.Text + "\t FEEDER  : " + comboBox2.Text + " Report \n" + "number of customers    :  " + textBox10.Text + "\n VIP customers   :  " + textBox9.Text + 
                        "\n U/G Transformer  :  " + textBox8.Text + "\n PMT  :  " + textBox6.Text + "\n U/G %  :  " + textBox7.Text + "\n PMT%  :  " + textBox11.Text + "\n Area  :  " + textBox4.Text+
                         "\n \n best wishes",



            };
            message.To.Add(toemail);
            client.SendCompleted += Client_SendCompleted1;
            client.SendMailAsync(message);

        }




        private void Client_SendCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("something wrong \n " + e.Error.Message, "error");
                return;
            }
            else
            {
                MessageBox.Show("sent successfully", "done");
            }
        }



        private void subbtn_Click(object sender, EventArgs e)
        {
            ngselect(comboBox4);
            listBox1.Items.Add(comboBox4.Text);
            subbtn.Enabled = false;
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox4.Text = comboBox4.SelectedText;
            comboBox4.Text = comboBox4.SelectedItem.ToString();
            subbtn.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pipnl.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            charts2pnl.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dashchartsBegin();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mainpnl.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mainpnl.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Excel exx = new Excel(@"C:\Users\The Master\Desktop\isolation.xlsx", 1);
          
            //
            //work permit no
            //
            exx.writeCell(8, 7, t1.Text);
            exx.writeCell(8, 8, t1.Text);
            exx.writeCell(8, 9, t1.Text);
            //
            //type of work
            //
            exx.writeCell(10, 3, t2.Text);
            exx.writeCell(10, 4, t2.Text);
            //
            //date
            //
            exx.writeCell(9, 9, datebox.Text);
            exx.writeCell(9, 10, datebox.Text);
            //
            //day
            //
            exx.writeCell(9, 6, daycombo.Text);
            //
            // complete date 
            //
            exx.writeCell(9, 1, t3.Text);
            exx.writeCell(9, 2, t3.Text);
            //
            //station1
            //
            exx.writeCell(11, 4, t11.Text); exx.writeCell(23, 2, t11.Text); exx.writeCell(50, 2, t11.Text); exx.writeCell(57, 2, t11.Text);
            exx.writeCell(14, 1, t11.Text); exx.writeCell(31, 2, t11.Text); exx.writeCell(51, 2, t11.Text); exx.writeCell(56, 2, t11.Text);
            exx.writeCell(22, 2, t11.Text); exx.writeCell(32, 2, t11.Text);
            //
            //station2
            //
            exx.writeCell(11, 10, t12.Text);
            exx.writeCell(10, 16, t12.Text);
            //
            //feeder
            //
            exx.writeCell(11, 6, t13.Text);
            exx.writeCell(16, 1, t13.Text);
            //
            // ALT feeder
            //
            exx.writeCell(24, 2, t14.Text); exx.writeCell(34, 2, t14.Text); exx.writeCell(58, 2, t14.Text); exx.writeCell(11, 8, t14.Text);
            exx.writeCell(25, 2, t14.Text); exx.writeCell(52, 2, t14.Text); exx.writeCell(59, 2, t14.Text); exx.writeCell(14, 12, t14.Text);
            exx.writeCell(33, 2, t14.Text); exx.writeCell(53, 2, t14.Text);
            //
            //new
            //
            exx.writeCell(41, 3, t23.Text); exx.writeCell(48, 3, t23.Text); exx.writeCell(54, 2, t23.Text);
            exx.writeCell(42, 3, t23.Text); exx.writeCell(49, 2, t23.Text); exx.writeCell(60, 2, t23.Text);
            exx.writeCell(43, 3, t23.Text); exx.writeCell(47, 2, t23.Text); exx.writeCell(16, 6, t23.Text);
            exx.writeCell(44, 3, t23.Text); exx.writeCell(46, 2, t23.Text); exx.writeCell(10, 5, t23.Text);
            exx.writeCell(45, 3, t23.Text); exx.writeCell(40, 2, t23.Text); exx.writeCell(38, 8, t23.Text);
            //
            //connect ring
            //
            exx.writeCell(12, 9, t15.Text); exx.writeCell(26, 3, t15.Text); exx.writeCell(55, 3, t15.Text);
            //
            //trans1
            //
            exx.writeCell(27, 3, t21.Text); exx.writeCell(28, 2, t21.Text); exx.writeCell(48, 2, t21.Text);
            exx.writeCell(29, 3, t21.Text); exx.writeCell(30, 2, t21.Text); exx.writeCell(41, 9, t21.Text);
            exx.writeCell(35, 3, t21.Text); exx.writeCell(44, 2, t21.Text); exx.writeCell(10, 11, t21.Text);
            exx.writeCell(36, 3, t21.Text); exx.writeCell(39, 3, t21.Text); exx.writeCell(16, 7, t21.Text);
            exx.writeCell(37, 3, t21.Text); exx.writeCell(38, 3, t21.Text);
            //
            //trans2
            //
            exx.writeCell(27, 2, t22.Text); exx.writeCell(39, 2, t22.Text); exx.writeCell(30, 3, t22.Text);
            exx.writeCell(29, 2, t22.Text); exx.writeCell(41, 2, t22.Text); exx.writeCell(47, 3, t22.Text);
            exx.writeCell(35, 2, t22.Text); exx.writeCell(42, 2, t22.Text); exx.writeCell(54, 3, t22.Text);
            exx.writeCell(36, 2, t22.Text); exx.writeCell(43, 2, t22.Text); exx.writeCell(10, 8, t22.Text);
            exx.writeCell(37, 2, t22.Text); exx.writeCell(45, 2, t22.Text); exx.writeCell(16, 5, t22.Text);
            exx.writeCell(38, 2, t22.Text); exx.writeCell(28, 3, t22.Text);
            //
            //towards
            //
            exx.writeCell(12, 5, t24.Text);
            exx.save();
            exx.close();
        }

        public int getint(float x)
        {
            int p =(int) x;
            float sub = x - p;
            if (sub >= 0.5)
            {
                return (p + 1);
            }
            else { return p; }

        }

     
    };
}
