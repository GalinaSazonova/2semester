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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            calculator = new CalculatorClass(); 
        }

        private bool answerInTextBox = false;

        public void PushNumber(object sender, EventArgs e)
        {
            Button pushedButton = sender as Button;
            if (textBox1.TextLength < 15)
            {
                if (!answerInTextBox)
                {
                    textBox1.AppendText(pushedButton.Text);
                }
                else
                {
                    textBox2.Clear();
                    calculator.Clean();
                    textBox1.AppendText(pushedButton.Text);
                    answerInTextBox = false;
                }
            }
        }

        public void PushClear(object sender, EventArgs e)
        {
            calculator.Clean();
            textBox1.Clear();
            textBox2.Clear();
        }

        public void PushSign(object sender, EventArgs e)
        {
            Button pushedButton = sender as Button;
            if (textBox1.TextLength != 0 && textBox2.TextLength == 0)
            {
                calculator.AddNumber(Convert.ToInt32(textBox1.Text));
                textBox2.Text = textBox1.Text;
                textBox2.AppendText(pushedButton.Text);
                textBox1.Clear();
                calculator.AddSign(Convert.ToChar(pushedButton.Text));
                return;
            }
            if (answerInTextBox)
            {
                textBox2.AppendText(pushedButton.Text);
                calculator.AddSign(Convert.ToChar(pushedButton.Text));
                answerInTextBox = false;
                return;
            }
            if (textBox2.TextLength != 0 && textBox1.TextLength == 0 && !answerInTextBox)
            {
                textBox2.Clear();
                calculator.PopSign();
                textBox2.AppendText(calculator.Result());
                textBox2.AppendText(pushedButton.Text);
                calculator.AddSign(Convert.ToChar(pushedButton.Text));
                return;
            }
            if (!answerInTextBox && textBox1.TextLength != 0 && textBox2.TextLength != 0)
            {
                try
                {
                    calculator.AddNumber(Convert.ToInt32(textBox1.Text));
                }
                catch (DivideByZeroException exceptioni)
                {
                    textBox2.Clear();
                    textBox1.Clear();
                    calculator.Clean();
                    MessageBox.Show("Divide by zero");
                }
                textBox2.AppendText(calculator.Result());
                textBox1.Clear();
                textBox2.Clear();
                textBox2.AppendText(pushedButton.Text);
                calculator.AddSign(Convert.ToChar(pushedButton.Text));
                return;
            }
        }

        public void PushResult(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && !answerInTextBox)
            {
                try
                {
                    calculator.AddNumber(Convert.ToInt32(textBox1.Text));
                }
                catch (DivideByZeroException exception)
                {
                    textBox2.Clear();
                    textBox1.Clear();
                    calculator.Clean();
                    answerInTextBox = false;
                    MessageBox.Show("Divide by zero");
                }
                answerInTextBox = true;
                textBox2.Clear();
                textBox1.Clear();
                textBox2.AppendText(calculator.Result());
            }
        }
        private CalculatorClass calculator;
    }
}