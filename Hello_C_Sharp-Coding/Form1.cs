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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string msg = this.textBox4.Text;
            //msg = this.textBox4.Text;
            MessageBox.Show("Hi : " + msg);
            MessageBox.Show("Hi : " + msg + " Welcome back!");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //string a1;
            //string a2;
            //a1 = this.textBox5.Text;
            //a2= this.textBox6.Text;

            int a1; // int is for numbers up to 2 billion
            int a2;
            int a3;
            //a1 = Convert.ToInt32( this.textBox5.Text);
            //a2= Convert.ToInt32(this.textBox6.Text);

            Int32.TryParse(this.textBox5.Text, out a1);
            Int32.TryParse(this.textBox6.Text, out a2);
            a3 = a1 + a2;
            MessageBox.Show( a3.ToString() );
        }

        private void button14_Click(object sender, EventArgs e)
        {
            long a1; // long and Int64 are the same and interchangeable and for numbers OVER 2 billion
            Int64 a2;
            Int64 a3;
            //a1 = Convert.ToInt32( this.textBox5.Text);
            //a2= Convert.ToInt32(this.textBox6.Text);

            Int64.TryParse(this.textBox5.Text, out a1);
            Int64.TryParse(this.textBox6.Text, out a2);
            a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            float a1; // float for decimals
            float a2;
            float a3;
            //a1 = Convert.ToInt32( this.textBox5.Text);
            //a2= Convert.ToInt32(this.textBox6.Text);

            float.TryParse(this.textBox5.Text, out a1);
            float.TryParse(this.textBox6.Text, out a2);
            a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double a1; // double for more DP decimals
            double a2;
            double a3;
            //a1 = Convert.ToInt32( this.textBox5.Text);
            //a2= Convert.ToInt32(this.textBox6.Text);

            double.TryParse(this.textBox5.Text, out a1);
            double.TryParse(this.textBox6.Text, out a2);
            a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            decimal a1; // decimal for  even more DP decimals and more accurate
            decimal a2;
            decimal a3;
            //a1 = Convert.ToInt32( this.textBox5.Text);
            //a2= Convert.ToInt32(this.textBox6.Text);

            decimal.TryParse(this.textBox5.Text, out a1);
            decimal.TryParse(this.textBox6.Text, out a2);
            a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bool b;
           b= this.button17.Enabled;
           MessageBox.Show(b.ToString());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc";
            this.process1.Start();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.process2.StartInfo.FileName = "C:\\Windows\\System32\\notepad";
            this.process2.Start();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.process2.StartInfo.FileName = "C:\\Program Files (x86)\\GOG Galaxy\\GalaxyClient";
            this.process2.Start();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Int32 uyb;

            Int32.TryParse(this.textBox7.Text, out uyb);
            Int32 curr_yr;
            curr_yr = DateTime.Now.Year;

            Int32 age = curr_yr - uyb;
            MessageBox.Show(age.ToString());

            if(age > 35)
            {
                MessageBox.Show("OK Boomer!");
            }
             else
            {
                MessageBox.Show("Just a godam kid!");
            }
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Int32 i;

            for(i = 0; i < 20; i++)
            {
                MessageBox.Show("I am a For Loop. My number is: "+ i.ToString());
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Int32 j;
            for(j=0; j<1000; j++)
            {
                this.comboBox1.Items.Add(j.ToString());
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Int32 mn;
            Int32.TryParse(this.textBox8.Text, out mn);

            string month_name = "Unknown";

            if (mn == 1)
            {
                //  MessageBox.Show("January");
                month_name = "January";
            }

            if (mn == 2)
            {
                // MessageBox.Show("Febuary");
                month_name = "Febuary";
            }

            if (mn == 3)
            {
                // MessageBox.Show("March");
                month_name = "March";
            }

            if (mn == 4)
            {
                // MessageBox.Show("April");
                month_name = "April";
            }

            if (mn == 5)
            {
                // MessageBox.Show("May");
                month_name = "May";
            }

            if (mn == 6)
            {
                //MessageBox.Show("June");
                month_name = "June";
            }

            if (mn == 7)
            {
                // MessageBox.Show("July");
                month_name = "July";
            }

            if (mn == 8)
            {
                //MessageBox.Show("JAugust");
                month_name = "August";
            }

            if (mn == 9)
            {
                //MessageBox.Show("September");
                month_name = "September";
            }

            if (mn == 10)
            {
                // MessageBox.Show("October");
                month_name = "October";
            }

            if (mn == 11)
            {
                // MessageBox.Show("November");
                month_name = "November";
            }

            if (mn == 12)
            {
                // MessageBox.Show("December");
                month_name = "December";
            }

            MessageBox.Show(month_name);


        }

        private void button27_Click(object sender, EventArgs e)
        {
            Int32 mn;
            Int32.TryParse(this.textBox8.Text, out mn);
            string month_name = "";
            switch(mn)

            { case 1:
                    month_name = "January";
                    break;

                case 2:
                    month_name = "Febuary";
                    break;

                case 3:
                    month_name = "March";
                    break;

                case 4:
                    month_name = "April";
                    break;

                case 5:
                    month_name = "May";
                    break;

                case 6:
                    month_name = "June";
                    break;

                case 7:
                    month_name = "July";
                    break;

                case 8:
                    month_name = "August";
                    break;

                case 9:
                    month_name = "September";
                    break;

                case 10:
                    month_name = "October";
                    break;

                case 11:
                    month_name = "November";
                    break;

                case 12:
                    month_name = "December";
                    break;


                default:

                    month_name = "Must be between 1 and 12";
                    break;

            }

            MessageBox.Show(month_name);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string month_name;
            month_name = this.textBox9.Text;
            string month_number;


            switch(month_name)
            {
                case "January":
                    month_number = " 1";
                    break;

                case "Febuary":
                    month_number = " 2";
                    break;

                case "March":
                    month_number = " 3";
                    break;

                case "April":
                    month_number = " 4";
                    break;

                case "May":
                    month_number = " 5";
                    break;

                case "June":
                    month_number = " 6";
                    break;

                case "July":
                    month_number = " 7";
                    break;

                case "August":
                    month_number = " 8";
                    break;

                case "September":
                    month_number = " 9";
                    break;

                case "October":
                    month_number = " 10";
                    break;


                case "November":
                    month_number = " 11";
                    break;

                case "December":
                    month_number = " 12";
                    break;

                default:
                    month_number = " Please check spelling;";

                    break;

            }
            MessageBox.Show(month_number);
        }
    }
}
