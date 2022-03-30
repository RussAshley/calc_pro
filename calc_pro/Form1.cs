using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calc_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //this.label1.Text = "0";
            this.main_num_label.ResetText();
            //this.first_num_label.ResetText();
           // this.operator_label.ResetText();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text =this.main_num_label.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";
            if (main_num_label.Text!="")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
           
            this.main_num_label.ResetText();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";
            if (main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
           
            this.main_num_label.ResetText();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "X";
            if (main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
          
            this.main_num_label.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "/";
            if (main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
           
            this.main_num_label.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double resultNumber= 0;

            double.TryParse(this.main_num_label.Text, out secondNumber);
            double.TryParse(this.first_num_label.Text, out firstNumber);

            if (this.operator_label.Text=="+")
            {
                resultNumber = firstNumber + secondNumber;
            }

            if (this.operator_label.Text == "-")
            {
                resultNumber = firstNumber - secondNumber;
            }

            if (this.operator_label.Text == "X")
            {
                resultNumber = firstNumber * secondNumber;
            }

            if (this.operator_label.Text == "/")
            {
                resultNumber = firstNumber / secondNumber;
            }

            this.main_num_label.Text = resultNumber.ToString();
            this.first_num_label.ResetText();
            this.operator_label.ResetText();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + ".";
        }
    }
}
