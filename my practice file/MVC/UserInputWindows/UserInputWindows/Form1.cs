using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInputWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string name = nametextbox.Text;
            MessageBox.Show("hello" + name);


        }

        private void CancleButoon_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            String iteam = comboBox1.Text;
            MessageBox.Show(iteam, "food iteam", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (oddCheckbox.Checked && Evencheckbox.Checked)
            {
                MessageBox.Show("Both");
            }
            else if (oddCheckbox.Checked)
            {
                MessageBox.Show("odd");

            }
            else if (Evencheckbox.Checked)
            {
                MessageBox.Show("Even");


            }
            else
            {
                MessageBox.Show("please select a option");

            }



    }


    }
}
