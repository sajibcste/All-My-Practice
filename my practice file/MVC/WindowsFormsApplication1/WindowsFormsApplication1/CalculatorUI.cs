using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double FirstNumber = Convert.ToDouble(FirstNumbertextBox.Text);
            double SecondFirstNumber = Convert.ToDouble(SecondNumbertextbox.Text);

            ResultTextBox.Text = Add(FirstNumber, SecondFirstNumber).ToString();



        }

        private double Add(double FirstNumber, double SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
    }
}
