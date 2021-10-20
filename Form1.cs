using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operator_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if((result.Text == "0")||(operator_pressed))            
                result.Clear();
            
            operator_pressed = false;   
            Button b = (Button)sender;

            if(b.Text == ",")
            {
                if(!result.Text.Contains(","))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }


        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(value != 0)
            {
                buttonEquals.PerformClick();
                operator_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operator_pressed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            double current_result = Double.Parse(result.Text);
            switch (operation)
            {
                case "+":
                    result.Text = (value + current_result).ToString();
                    break;
                case "-":
                    result.Text = (value - current_result).ToString();
                    break;
                case "*":
                    result.Text = (value * current_result).ToString();
                    break;
                case "/":
                    result.Text = (value / current_result).ToString();
                    break;
                case "%":
                    result.Text = (value * current_result /100).ToString();
                    break;
                default:
                    break;
            }
            value = Double.Parse(result.Text);
            operation = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }
        
        private void buttonCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            if(result.Text.Length != 0)
            {
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
                if(result.Text.Length == 0)
                    result.Text = "0";
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button2.PerformClick();
                    break;
                case "3":
                    button3.PerformClick();
                    break;
                case "4":
                    button4.PerformClick();
                    break;
                case "5":
                    button5.PerformClick();
                    break;
                case "6":
                    button6.PerformClick();
                    break;
                case "7":
                    button7.PerformClick();
                    break;
                case "8":
                    button8.PerformClick();
                    break;
                case "9":
                    button9.PerformClick();
                    break;
                case "+":
                    buttonPlus.PerformClick();
                    break;
                case "-":
                    buttonMinus.PerformClick();
                    break;
                case "/":
                    buttonDiv.PerformClick();
                    break;
                case "*":
                    buttonMulti.PerformClick();
                    break;
                case "=":
                    buttonEquals.PerformClick();
                    break;
                case ",":
                    buttonDecimal.PerformClick();
                    break;
                default:
                    break;
            }
        }

        

        private void buttonSqrt_Click_1(object sender, EventArgs e)
        {
            buttonEquals.PerformClick();
            double temp = Double.Parse(result.Text);
            result.Text = Math.Sqrt(temp).ToString();
            equation.Text = "";
        }

        private void buttonOpposite_Click(object sender, EventArgs e)
        {
            buttonEquals.PerformClick();
            double temp = Double.Parse(result.Text);
            if (temp == 0)
                MessageBox.Show("Гагаш на 0 делить нельзя!");
            else                
                result.Text = (1 / temp).ToString();
            equation.Text = "";
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            buttonEquals.PerformClick();
            double temp = Double.Parse(result.Text);
            result.Text = Math.Pow(temp,2).ToString();
            equation.Text = "";
        }

        private void buttonEquals_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
