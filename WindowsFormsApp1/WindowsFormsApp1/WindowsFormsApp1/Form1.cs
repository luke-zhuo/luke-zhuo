using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double resultvalue = 0;
        string operationperforemed = "";
        bool isoperationperforemed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text == "0" || isoperationperforemed)
                textBox_result.Clear();
            isoperationperforemed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                    textBox_result.Text = textBox_result.Text + button.Text;
            }
            else
            textBox_result.Text = textBox_result.Text + button.Text;


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperforemed = button.Text;
            resultvalue = double.Parse(textBox_result.Text);
            labelcurretoperation.Text = resultvalue + " " + operationperforemed;
            isoperationperforemed = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultvalue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch(operationperforemed)
            {
                case "+":
                    textBox_result.Text = (resultvalue + double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultvalue - double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultvalue * double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultvalue / double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
