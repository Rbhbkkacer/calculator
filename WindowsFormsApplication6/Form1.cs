using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void num(Button sender)
        {
            if (textBox1.Text!="0")
            {
                textBox1.Text += sender.Text;
            }
            else
            {
                textBox1.Text = sender.Text;
            }
        }
        
        private void dot(Button sender)
        {
            bool good = true;
            for(byte i=0;i<=textBox1.Text.Length-1;i++)
            {
                if (textBox1.Text[i] == sender.Text[0])
                {
                    good = false;
                }
            }
            if (good)
            {
                textBox1.Text = textBox1.Text + sender.Text;
            }
        }
        private void kalk()
        {
            if(label3.Text==button11.Text)
            {
                label2.Text = Convert.ToString(Convert.ToDouble(label2.Text) + Convert.ToDouble(label1.Text));
            }
            else if(label3.Text==button12.Text)
            {
                label2.Text = Convert.ToString(Convert.ToDouble(label2.Text) - Convert.ToDouble(label1.Text));
            }
            else if(label3.Text==button13.Text)
            {
                label2.Text = Convert.ToString(Convert.ToDouble(label2.Text) * Convert.ToDouble(label1.Text));
            }
            else if (label3.Text == button14.Text)
            {
                label2.Text = Convert.ToString(Convert.ToDouble(label2.Text) / Convert.ToDouble(label1.Text));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            kalk();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num((Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num((Button)sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num((Button)sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num((Button)sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num((Button)sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num((Button)sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num((Button)sender);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            num((Button)sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dot((Button)sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kalk();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kalk();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kalk();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kalk();
        }
    }
}
