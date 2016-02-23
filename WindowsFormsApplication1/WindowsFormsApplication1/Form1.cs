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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");

            comboBox1.Hide();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                label2.Text = "0";
                comboBox1.Hide();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label2.Text = "30";
                comboBox1.Hide();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label2.Text = "60";
                comboBox1.Hide();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("1"))
            {
                label2.Text = "4";
            }
            else if (comboBox1.Text.Equals("2"))
            {
                label2.Text = "6";
            }
            else if (comboBox1.Text.Equals("3"))
            {
                label2.Text = "12";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
