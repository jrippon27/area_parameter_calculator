using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_parameter_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double firstTextBoxNumber;
            double secondTextBoxNumber;
            double thirdTextBoxNumber;
            double answer;

            
            if (string.IsNullOrEmpty(thirdNumber.Text))
            {
                MessageBox.Show("Please enter a value of 1 as the third number cannot be empty!");
            }
            else
            {
                firstTextBoxNumber = double.Parse(firstNumber.Text);
                secondTextBoxNumber = double.Parse(secondNumber.Text);
                thirdTextBoxNumber = double.Parse(thirdNumber.Text);

                answer = (firstTextBoxNumber * secondTextBoxNumber) *
                    thirdTextBoxNumber;
                MessageBox.Show(answer.ToString());
            }
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int secondTextBoxNumber;
            int thirdTextBoxNumber;
            int answer;

            if (string.IsNullOrEmpty(thirdNumber.Text))
            {
                MessageBox.Show("Please enter a value of 0 as the third number cannot be empty!");
            }
            else
            {
                firstTextBoxNumber = int.Parse(firstNumber.Text);
                secondTextBoxNumber = int.Parse(secondNumber.Text);
                thirdTextBoxNumber = int.Parse(thirdNumber.Text);

                answer = firstTextBoxNumber + secondTextBoxNumber +
                    thirdTextBoxNumber;
                MessageBox.Show(answer.ToString());
            }
        }
        private void firstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstNumber.Clear();
            secondNumber.Clear();
            thirdNumber.Clear();
        }
    }
}
