using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12Baskaev
{
    public partial class Form1 : Form
    {
        int day = 0;
        int month = 0;
        int sieson = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                day = Int32.Parse(textBox1.Text);

            }
            catch (FormatException)
            {
                textBox1.Text = "";
                MessageBox.Show("Цифрами пожалуйста! Целыми)");
                return;
            }
            if (day > 364 || day < 1)
            {
                MessageBox.Show("В 2023 году 365 дней, введите корректное число");
            }
            if (day <= 31) { month = 0; sieson = 1; }
            else if (day <= 59) { month = 1; sieson = 1; }
            else if (day <= 90) { month = 2; sieson = 2; }
            else if (day <= 120) { month = 3; sieson = 2; }
            else if (day <= 159) { month = 4; sieson = 2; }
            else if (day <= 181) { month = 5; sieson = 3; }
            else if (day <= 212) { month = 6; sieson = 3; }
            else if (day <= 243) { month = 7; sieson = 3; }
            else if (day <= 273) { month = 8; sieson = 4; }
            else if (day <= 304) { month = 9; sieson = 4; }
            else if (day <= 334) { month = 10; sieson = 4; }
            else if (day <= 365) { month = 11; sieson = 1; }
            listBox1.SelectedIndex = month;
            if (sieson ==1) { radioButton3.Checked = true; }
            if (sieson == 2) { radioButton4.Checked = true; }
            if (sieson == 3) { radioButton2.Checked = true; }
            if (sieson == 4) { radioButton1.Checked = true; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
