using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class Form1 : Form
    {
        private string currentOperation = "";
        private double result = 0;
        private bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        // Hanterar sifferknappar
        private void btn_Click(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") || isOperationPerformed)
                resultTextBox.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            resultTextBox.Text += button.Text;
        }

        // Hanterar operatorer (+, -, *, /)
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                btnEquals.PerformClick();
                currentOperation = button.Text;
                secondTextBox.Text = result + " " + currentOperation;
                isOperationPerformed = true;
            }
            else
            {
                currentOperation = button.Text;
                result = Double.Parse(resultTextBox.Text);
                secondTextBox.Text = result + " " + currentOperation;
                isOperationPerformed = true;
            }
        }

        // Rensar hela textfältet (C)
        private void btnClear_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
            result = 0;
            secondTextBox.Text = "";
            currentOperation = "";
        }

        // Kvadratrot (√)
        private void btnClearOne_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Math.Sqrt(Double.Parse(resultTextBox.Text)).ToString();
        }

        // Tar bort senaste siffran (<-)
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Length > 0)
                resultTextBox.Text = resultTextBox.Text.Remove(resultTextBox.Text.Length - 1);
            if (resultTextBox.Text == "")
                resultTextBox.Text = "0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void btnComma_Click(object sender, EventArgs e)
        {

        }

        // Växlar tecken (+/-)
        private void button20_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text != "0")
                resultTextBox.Text = (-1 * Double.Parse(resultTextBox.Text)).ToString();
        }
        // Hanterar procent
        private void btnPercent_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = (Double.Parse(resultTextBox.Text) / 100).ToString();
        }

        private void firstTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void thirdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
