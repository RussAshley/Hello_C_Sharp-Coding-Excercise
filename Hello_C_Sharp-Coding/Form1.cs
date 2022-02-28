using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hello_C_Sharp_Coding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello this isnt my first C# code ;)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Im a penguin", "Penguin");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.OliveDrab;
            button2.BackColor = Color.DarkRed;
            //this.BackColor = Color.PowderBlue;
            button3.ForeColor = Color.Red;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " I'm Text box and im beautiful";
            this.button3.Text = "Hi sexy pants";
            this.Text = "Hi I love you; Me Too!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            //this.Enabled = false;
            //this.button5.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox2.Text= DateTime.Now.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox2.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.textBox3.Text = DateTime.Now.Hour.ToString()  + ":" +  DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to delete?", "Finish", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile("C:\\Users\\russe\\OneDrive\\Pictures\\20151121_163257082_iOS.jpg");
            this.BackgroundImage= Image.FromFile("C:\\Users\\russe\\OneDrive\\Pictures\\20151121_163257082_iOS.jpg");
        }
    }
}
