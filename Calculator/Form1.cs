using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int too1; //ene 2 huvisagchiig buh function ashiglah bolomjtoi
        char uildel='+'; //zuvhun neg temdegt hadgalna.
        public Form1()
        {
            InitializeComponent(); //uuniig ustgaj bolohgui.
        }

        private void button1_Click(object sender, EventArgs e)
        { // '0' tovchluur daragdsan ueiin program
            textBox1.Text += "0";
            int t = Convert.ToInt32(textBox1.Text);
            textBox1.Text = t.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {// '1' tovchluur daragdsan ueiin program
            // textBox1.Text -t deer 1-g zalgana.
            textBox1.Text += "1";
            //tuuniigee too bolgoj hurvuulne.
            int t = Convert.ToInt32(textBox1.Text);
            //toogoo string bolgoj hurvuulne.
            textBox1.Text = t.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {// '2' tovchluur daragdsan ueiin program
            textBox1.Text += "2";
            int t = Convert.ToInt32(textBox1.Text);
            textBox1.Text = t.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {// '3' tovchluur daragdsan ueiin program
            textBox1.Text += "3";
            int t = Convert.ToInt32(textBox1.Text);
            textBox1.Text = t.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {// '4' tovchluur daragdsan ueiin program
            textBox1.Text += "4";
            int t = Convert.ToInt32(textBox1.Text);
            textBox1.Text = t.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {// '5' tovchluur daragdsan ueiin program
            textBox1.Text += "5";
            int t = Convert.ToInt32(textBox1.Text);
            textBox1.Text = t.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {// '6' tovchluur daragdsan ueiin program
            textBox1.Text += "6";
            int t = Convert.ToInt32(textBox1.Text);
            textBox1.Text = t.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {// '7' tovchluur daragdsan ueiin program
            textBox1.Text += "7";
            int t = Convert.ToInt32(textBox1.Text);
            textBox1.Text = t.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {// '8' tovchluur daragdsan ueiin program
            textBox1.Text += "8";
            int t = Convert.ToInt32(textBox1.Text);
            textBox1.Text = t.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {   // 9-n too daragdsan
            textBox1.Text += "9";
            int t = Convert.ToInt32(textBox1.Text);
            textBox1.Text = t.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {   // + temdeg daragsan ueiin program
            too1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            uildel = '+';
        }

        private void button15_Click(object sender, EventArgs e)
        {   // '=' -n temdeg daragdsan.
            switch (uildel) //uildel gedeg huvisagchiig doorh tohioldol bureer shalgana.
            {
                case '+': // uildel='+' baih ued doorh program ajilna.
                    //end '+' baih ueiin kodiig end bichne.
                    int sum = too1 + Convert.ToInt32(textBox1.Text);
                    textBox1.Text = sum.ToString(); //sum n too uchir string bolgoh shaardlagtai.
                    break;  
                case '-': // uildel='-' baih ued doorh program ajilna.
                    //end '-' baih ueiin kodiig end bichne.
                    sum = too1 - Convert.ToInt32(textBox1.Text);
                    textBox1.Text = sum.ToString();
                    break;
                case '*': // uildel='*' baih ued doorh program ajilna.
                    //end '-' baih ueiin kodiig end bichne.
                    sum = too1 * Convert.ToInt32(textBox1.Text);
                    textBox1.Text = sum.ToString();
                    break;
                case '/': // uildel='/' baih ued doorh program ajilna.
                    sum = too1 / Convert.ToInt32(textBox1.Text);
                    textBox1.Text = sum.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // '-' temdeg daragsan ueiin program
            too1 = Convert.ToInt32(textBox1.Text); //textbox -iin utgiig too1-d hadgalj avna.
            textBox1.Text = "0"; //textbox -oo 0 -s ehluulne.
            uildel = '-'; //yamar uildel hiihiig hadgalah shaardlagatai
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // '*' temdeg daragsan ueiin program
            too1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            uildel = '*';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // '/' temdeg daragsan ueiin program
            too1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            uildel = '/';
        }
    }
}
