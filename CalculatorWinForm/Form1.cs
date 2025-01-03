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

        private void btnPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnClearOne_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void btnComma_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

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
