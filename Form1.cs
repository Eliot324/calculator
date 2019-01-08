using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public static decimal answer = 0;
        public static String tempText = "";
        public static String tempText2 = "";
        public static String mode = "";

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = tempText;

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempText = tempText + "2";
            display0.Text = tempText;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tempText = tempText + "8";
            display0.Text = tempText;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tempText = tempText + "5";
            display0.Text = tempText;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tempText = tempText + "7";
            display0.Text = tempText;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tempText = tempText + "6";
            display0.Text = tempText;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tempText = tempText + "9";
            display0.Text = tempText;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            tempText2 = tempText;
            tempText = "";
            display0.Text = tempText;
            mode = "mult";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            tempText2 = tempText;
            tempText = "";
            display0.Text = tempText;
            mode = "sub";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            tempText2 = "";
            tempText = "";
            display0.Text = tempText;


        }
   

        private void display0_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempText = tempText+ "1";
            display0.Text = tempText;

        // Console.WriteLine(tempText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tempText = tempText + "3";
            display0.Text = tempText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tempText = tempText + "4";
            display0.Text = tempText;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            tempText = tempText + "0";
            display0.Text = tempText;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            tempText2 = tempText;
            tempText = "";
            display0.Text = tempText;
            mode = "add";

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            tempText2 = tempText;
            tempText = "";
            display0.Text = tempText;
            mode = "div";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (mode.Equals("add"))
            {
                answer = decimal.Parse(tempText2)+decimal.Parse(tempText);
                String str = "";
                display0.Text = answer.ToString("0.00");
            }
            if (mode.Equals("div"))
            {
                answer = decimal.Parse(tempText2) / decimal.Parse(tempText);
                String str = "";
                display0.Text = answer.ToString("0.00");
            }
            if (mode.Equals("sub"))
            {
                answer = decimal.Parse(tempText2) - decimal.Parse(tempText);
                String str = "";
                display0.Text = answer.ToString("0.00");
            }
            if (mode.Equals("mult"))
            {
                answer = decimal.Parse(tempText2) * decimal.Parse(tempText);
                String str = "";
                display0.Text = answer.ToString("0.00");
            }
        }
    }
}
