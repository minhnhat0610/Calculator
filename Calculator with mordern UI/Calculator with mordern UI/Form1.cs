using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Calculator_with_mordern_UI
{
    public partial class CalculatorWithMordernUIDemo : Form
    {
        double result = 0;
        char  sign;
        double num;
        int count = 0;
        public CalculatorWithMordernUIDemo()
        {
            InitializeComponent();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonNumber1_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "1";
        }

        private void ButtonNumber2_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "2";
        }

        private void ButtonNumber3_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "3";
        }

        private void ButtonNumber4_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "4";
        }

        private void ButtonNumber5_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "5";
        }

        private void ButtonNumber6_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "6";
        }

        private void ButtonNumber7_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "7";
        }

        private void ButtonNumber8_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "8";
        }

        private void ButtonNumber9_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "9";
        }

        private void ButtonNumber0_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "0";
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text += ".";
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if(count == 0)
            {
                sign = '+';
            }
            Calcualte();
            sign = '+';
            ResultBox.Text = null;
            count++;
            
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                sign = '-';
            }
            Calcualte();
            sign = '-';
            ResultBox.Text = null;
            count++;
        }

        private void MultilyButton_Click(object sender, EventArgs e)
        {
            if(count == 0)
            {
                sign = 'x';
            }
            Calcualte();
            sign = 'x';
            ResultBox.Text = null;
            count++;

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                sign = '/';
            }
            Calcualte();
            sign = '/';
            ResultBox.Text = null;
            count++;
            
        }

        private void Calcualte()
        {
            num = Convert.ToDouble(ResultBox.Text);
            if (sign == '+')
            {
                result += num;
            }
            else if (sign == '-')
            {
                if (count == 0) result = num - result;
                else result -= num;
            }

            else if (sign == 'x')
            {
                if (result == 0) result = 1;
                result *= num;
            }

            else if (sign == '/')
            {
                if (result == 0) result = 1;
                if (count == 0)
                {
                    result = num / result;
                }

                else result /= num;
            }

        }



        private void ShowResultButton_Click(object sender, EventArgs e)
        {
            Calcualte();
            ResultBox.Text = result.ToString();
            count = 0;
            result = 0;

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = null;
            result = 0;
            count = 0;
        }

        private void CalculatorWithMordernUIDemo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                ResultBox.Text += "1";
            }

            if (e.KeyChar == '2')
            {
                ResultBox.Text += "2";
            }

            if (e.KeyChar == '3')
            {
                ResultBox.Text += "3";
            }

            if (e.KeyChar == '4')
            {
                ResultBox.Text += "4";
            }

            if (e.KeyChar == '5')
            {
                ResultBox.Text += "5";
            }

            if (e.KeyChar == '6')
            {
                ResultBox.Text += "6";
            }

            if (e.KeyChar == '7')
            {
                ResultBox.Text += "7";
            }

            if (e.KeyChar == '8')
            {
                ResultBox.Text += "8";
            }

            if (e.KeyChar == '9')
            {
                ResultBox.Text += "9";
            }

            if (e.KeyChar == '.')
            {
                ResultBox.Text += ".";
            }

            if (e.KeyChar == '0')
            {
                ResultBox.Text += "0";
            }

            if(e.KeyChar == '+')
            {
                Addbutton_Click(sender, e);
            }

            if(e.KeyChar == '-')
            {
                SubtractButton_Click(sender, e);
            }

            if(e.KeyChar == '*')
            {
                MultilyButton_Click(sender, e);
            }

            if(e.KeyChar == '/')
            {
                DivideButton_Click(sender, e);
            }

            if(e.KeyChar == (char)Keys.Back)
            {
                int lenght = ResultBox.Text.Length;
                if(lenght != 0) 
                ResultBox.Text = ResultBox.Text.Remove(lenght - 1, 1);

            }

        }

    }
}
