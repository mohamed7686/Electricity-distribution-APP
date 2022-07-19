
namespace myDataBase
{
    partial class Transferload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transferload));
            this.toppnl = new System.Windows.Forms.Panel();
            this.titlelabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.exbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.amper = new System.Windows.Forms.TextBox();
            this.amperlabel = new System.Windows.Forms.Label();
            this.pmttext = new System.Windows.Forms.TextBox();
            this.transtext = new System.Windows.Forms.TextBox();
            this.viptext = new System.Windows.Forms.TextBox();
            this.custtext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toppnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppnl
            // 
            this.toppnl.BackColor = System.Drawing.Color.DimGray;
            this.toppnl.Controls.Add(this.titlelabel);
            this.toppnl.Controls.Add(this.button2);
            this.toppnl.Controls.Add(this.exbtn);
            this.toppnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppnl.Location = new System.Drawing.Point(0, 0);
            this.toppnl.Name = "toppnl";
            this.toppnl.Size = new System.Drawing.Size(505, 39);
            this.toppnl.TabIndex = 2;
            this.toppnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppnl_MouseDown);
            this.toppnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppnl_MouseMove);
            this.toppnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toppnl_MouseUp);
            // 
            // titlelabel
            // 
            this.titlelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.titlelabel.Location = new System.Drawing.Point(186, 5);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(190, 24);
            this.titlelabel.TabIndex = 3;
            this.titlelabel.Text = "Transfer load";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(54, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 28);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exbtn
            // 
            this.exbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exbtn.BackgroundImage")));
            this.exbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exbtn.Location = new System.Drawing.Point(10, 5);
            this.exbtn.Name = "exbtn";
            this.exbtn.Size = new System.Drawing.Size(38, 28);
            this.exbtn.TabIndex = 0;
            this.exbtn.UseVisualStyleBackColor = true;
            this.exbtn.Click += new System.EventHandler(this.exbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 373);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.amper);
            this.panel3.Controls.Add(this.amperlabel);
            this.panel3.Controls.Add(this.pmttext);
            this.panel3.Controls.Add(this.transtext);
            this.panel3.Controls.Add(this.viptext);
            this.panel3.Controls.Add(this.custtext);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(36, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 211);
            this.panel3.TabIndex = 1;
            // 
            // amper
            // 
            this.amper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amper.Location = new System.Drawing.Point(149, 177);
            this.amper.Name = "amper";
            this.amper.Size = new System.Drawing.Size(127, 26);
            this.amper.TabIndex = 6;
            // 
            // amperlabel
            // 
            this.amperlabel.BackColor = System.Drawing.Color.Transparent;
            this.amperlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amperlabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.amperlabel.Location = new System.Drawing.Point(282, 183);
            this.amperlabel.Name = "amperlabel";
            this.amperlabel.Size = new System.Drawing.Size(133, 19);
            this.amperlabel.TabIndex = 4;
            this.amperlabel.Text = "load allowed";
            this.amperlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pmttext
            // 
            this.pmttext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pmttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmttext.Location = new System.Drawing.Point(185, 135);
            this.pmttext.Name = "pmttext";
            this.pmttext.Size = new System.Drawing.Size(218, 26);
            this.pmttext.TabIndex = 1;
            // 
            // transtext
            // 
            this.transtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transtext.Location = new System.Drawing.Point(185, 96);
            this.transtext.Name = "transtext";
            this.transtext.Size = new System.Drawing.Size(218, 26);
            this.transtext.TabIndex = 1;
            // 
            // viptext
            // 
            this.viptext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viptext.Location = new System.Drawing.Point(185, 59);
            this.viptext.Name = "viptext";
            this.viptext.Size = new System.Drawing.Size(218, 26);
            this.viptext.TabIndex = 1;
            // 
            // custtext
            // 
            this.custtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custtext.Location = new System.Drawing.Point(185, 22);
            this.custtext.Name = "custtext";
            this.custtext.Size = new System.Drawing.Size(218, 26);
            this.custtext.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(14, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "ampere";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(14, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "pmt";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(14, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "U/G Transformer";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(14, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "vip";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "no.customers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(30, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 96);
            this.panel2.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownHeight = 100;
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Location = new System.Drawing.Point(132, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(277, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 100;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(132, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "feeder2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "station2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Transferload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(505, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toppnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transferload";
            this.Text = "Transferload";
            this.toppnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppnl;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pmttext;
        private System.Windows.Forms.TextBox transtext;
        private System.Windows.Forms.TextBox viptext;
        private System.Windows.Forms.TextBox custtext;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox amper;
        private System.Windows.Forms.Label amperlabel;
        private System.Windows.Forms.Label label7;
    }
}