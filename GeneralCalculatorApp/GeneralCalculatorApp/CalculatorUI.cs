using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralCalculatorApp
{
    public partial class CalculatorUIForm : Form
    {
        Calculator aCalculator = new Calculator();
        private double firstNo;
        private double secondNo;
        private double result;

        public CalculatorUIForm()
        {
            InitializeComponent();
        }
        private void InitializeFirstAndSecondNo()
        {
            firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            secondNo = Convert.ToDouble(secondNumberTextBox.Text);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            InitializeFirstAndSecondNo();
            result = aCalculator.Add(firstNo,secondNo);
            resultTextBox.Text = Convert.ToString(result);
        }
        private void subtractButton_Click(object sender, EventArgs e)
        {
            InitializeFirstAndSecondNo();
            result = aCalculator.Subtract(firstNo, secondNo);
            resultTextBox.Text = Convert.ToString(result);
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            InitializeFirstAndSecondNo();
            result = aCalculator.Multiply(firstNo, secondNo);
            resultTextBox.Text = Convert.ToString(result);
        }

        private void DevideButton_Click(object sender, EventArgs e)
        {
            InitializeFirstAndSecondNo();
            result = aCalculator.Devide(firstNo, secondNo);
            resultTextBox.Text = Convert.ToString(result);
        }
        

        

        

    }
}
