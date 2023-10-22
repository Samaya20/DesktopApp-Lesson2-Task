using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            //textBox1.Text += button1.Text;

            if (resultTextbox.Text == "0" || (isOperationPerformed))
                resultTextbox.Text = string.Empty;

            isOperationPerformed = false;

            Label label = (Label)sender;

            if (label.Text == ".")
            {
                if (!resultTextbox.Text.Contains('.'))
                    resultTextbox.Text += label.Text;
            }
            else
            {
                resultTextbox.Text += label.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            operationPerformed = label.Text;
            resultValue = Double.Parse(resultTextbox.Text);
            currentLabel.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (resultTextbox.Text.Length > 0)
                resultTextbox.Text = resultTextbox.Text.Remove(resultTextbox.Text.Length - 1, 1);

            if (resultTextbox.Text == "0")
                resultTextbox.Text = "0";
        }


        private void ceBtn_Click(object sender, EventArgs e)
        {
            resultTextbox.Text = "0";
            resultValue = 0;
            currentLabel.Text = resultValue.ToString();

        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            resultTextbox.Text = "0";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                resultTextbox.Text = (resultValue + double.Parse(resultTextbox.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                resultTextbox.Text = (resultValue - double.Parse(resultTextbox.Text)).ToString();
            }
            else if (operationPerformed == "X")
            {
                resultTextbox.Text = (resultValue * double.Parse(resultTextbox.Text)).ToString();
            }
            else
            {
                resultTextbox.Text = (resultValue / double.Parse(resultTextbox.Text)).ToString();
            }
        }

        private void resultTextbox_Click(object sender, EventArgs e)
        {

        }
    }
}