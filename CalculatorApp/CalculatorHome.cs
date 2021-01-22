using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorHome : Form
    {
        public CalculatorHome()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            try
            {
                int a = Convert.ToInt32(FirstTextBox.Text);
                int b = Convert.ToInt32(SecondTextBox.Text);

                int c = a + b;

                ResultTextBox.Text = c.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show("Please put valid numbers!");
                ErrorLabel.Text = "Values are not numaric.";
            }
        }

        private void FirstTextBox_TextChanged(object sender, EventArgs e)
        {
            //SecondTextBox.Text = "";
            ResultTextBox.Text = ""; 
        }

        private void SecondTextBox_TextChanged(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            try
            {
                int a = Convert.ToInt32(FirstTextBox.Text);
                int b = Convert.ToInt32(SecondTextBox.Text);

                int c = a - b;

                ResultTextBox.Text = c.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Please put valid numbers!");
                ErrorLabel.Text = "Values are not numaric.";
            }
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            try
            {
                int a = Convert.ToInt32(FirstTextBox.Text);
                int b = Convert.ToInt32(SecondTextBox.Text);

                int c = a * b;

                ResultTextBox.Text = c.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Please put valid numbers!");
                ErrorLabel.Text = "Values are not numaric.";
            }
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            try
            {
                int a = Convert.ToInt32(FirstTextBox.Text);
                int b = Convert.ToInt32(SecondTextBox.Text);

                int c = a / b;

                ResultTextBox.Text = c.ToString();
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show("Please put valid numbers!");
                ErrorLabel.Text = "Values are not numaric.";
            }
        }

        
    }
}
