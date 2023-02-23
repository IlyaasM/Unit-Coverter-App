using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double userin= 0.0, userout=0.0;
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string[] length = new string[] { "Centimeter", "Meter", "Kilometer"};
            if (radioButton1.Checked == true)
                {
               
                foreach (string item in length)
                {
                    comboBox1.Items.Add(item);
                    comboBox2.Items.Add(item);
                }
                 label1.Text = "Convert Length";
                 textBox1.Text = "";
                 textBox1.Focus();
            }
                else
                {
                label1.Text = "Select Unit";
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text="";
                foreach (string item in length)
                {
                    comboBox1.Items.Remove(item);
                    comboBox2.Items.Remove(item);
                }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2_SelectedIndexChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string[] Mass = new string[] { "Milligram", "Gram", "Kilogram" };
            if (radioButton2.Checked == true)
            {

                foreach (string item in Mass)
                {
                    comboBox1.Items.Add(item);
                    comboBox2.Items.Add(item);
                }
                label1.Text = "Convert Mass";
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                label1.Text = "Select Unit";
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                foreach (string item in Mass)
                {
                    comboBox1.Items.Remove(item);
                    comboBox2.Items.Remove(item);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string[] Time = new string[] { "Seconds", "Minutes", "Hours" };
            if (radioButton3.Checked == true)
            {

                foreach (string item in Time)
                {
                    comboBox1.Items.Add(item);
                    comboBox2.Items.Add(item);
                }
                label1.Text = "Convert Time";
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                label1.Text = "Select Unit";
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                foreach (string item in Time)
                {
                    comboBox1.Items.Remove(item);
                    comboBox2.Items.Remove(item);
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string[] Temp = new string[] { "Celsius", "Fahrenheit", "Kelvins" };
            if (radioButton4.Checked == true)
            {

                foreach (string item in Temp)
                {
                    comboBox1.Items.Add(item);
                    comboBox2.Items.Add(item);
                }
                label1.Text = "Convert Temperatures";
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                label1.Text = "Select Unit";
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                foreach (string item in Temp)
                {
                    comboBox1.Items.Remove(item);
                    comboBox2.Items.Remove(item);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LENGTH CONVERSIONS
            if (comboBox1.Text == comboBox2.Text)
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin;
                textBox2.Text = Convert.ToString(userout);
                MessageBox.Show("No Conversion Needed Here...\nSelect Another Unit to Convert to","Incorrect");
            }
            if (comboBox1.Text=="Centimeter"&& comboBox2.Text == "Meter")
            {
               userin=Convert.ToDouble(textBox1.Text);
                userout = userin / 100;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Centimeter" && comboBox2.Text == "Kilometer")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin / 100000;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Meter" && comboBox2.Text == "Centimeter")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin * 100;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Meter" && comboBox2.Text == "Kilometer")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin / 1000;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Kilometer" && comboBox2.Text == "Centimeter")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin * 100000;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Kilometer" && comboBox2.Text == "Meter")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin * 1000;
                textBox2.Text = Convert.ToString(userout);
            }
            //MASS CONVESR\IONS
            if (comboBox1.Text == "Milligram" && comboBox2.Text == "Gram")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin / 1000;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Milligram" && comboBox2.Text == "Kilogram")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin / 1000000;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Gram" && comboBox2.Text == "Milligram")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin * 1000;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Gram" && comboBox2.Text == "Kilogram")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin / 1000;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Kilogram" && comboBox2.Text == "Milligram")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin * 1000000;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Kilogram" && comboBox2.Text == "Gram")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin * 1000;
                textBox2.Text = Convert.ToString(userout);
            }
            //TIME CONVERSIONS
            if (comboBox1.Text == "Seconds" && comboBox2.Text == "Minutes")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin / 60;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Seconds" && comboBox2.Text == "Hours")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin *3600;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Minutes" && comboBox2.Text == "Seconds")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin *60;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Minutes" && comboBox2.Text == "Hours")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin / 60;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Hours" && comboBox2.Text == "Seconds")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin * 3600;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Hours" && comboBox2.Text == "Minutes")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin * 60;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Celsius" && comboBox2.Text == "Fahrenheit")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = (userin * 9/5)+32;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Celsius" && comboBox2.Text == "Kelvins")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin + 273.15;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Celsius")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = (userin - 32) * 5 / 9;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Kelvins")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = (userin - 32) * 5 / 9 + 273.15;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Kelvins" && comboBox2.Text == "Celsius")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = userin - 273.15;
                textBox2.Text = Convert.ToString(userout);
            }
            if (comboBox1.Text == "Kelvins" && comboBox2.Text == "Fahrenheit")
            {
                userin = Convert.ToDouble(textBox1.Text);
                userout = (userin - 273.15) * 9/5 + 32;
                textBox2.Text = Convert.ToString(userout);
            }
        }
    }
}
