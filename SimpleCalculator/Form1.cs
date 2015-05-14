using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double cNumber;
        double dNumber;
        Calculator s = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
             cNumber = Convert.ToDouble(firstTextBox.Text);
             dNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = s.add(cNumber, dNumber).ToString();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            cNumber = Convert.ToDouble(firstTextBox.Text);
            dNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = s.subtract(cNumber, dNumber).ToString();

        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            cNumber = Convert.ToDouble(firstTextBox.Text);
            dNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = s.multiply(cNumber, dNumber).ToString();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            cNumber = Convert.ToDouble(firstTextBox.Text);
            dNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = s.divide(cNumber, dNumber).ToString();
        }

        private void firstTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
