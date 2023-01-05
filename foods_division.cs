using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_Kelompok9
{
    public partial class foods_division : UserControl
    {
        public foods_division()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Cari Makanan")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Cari Makanan";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void foods_division_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == label7.Text.ToLower())
            {
                label7.BackColor = Color.Orange;
                label1.BackColor = Color.Orange;
            }
            else if (textBox1.Text.ToLower() == label8.Text.ToLower())
            {
                label8.BackColor = Color.Orange;
                label2.BackColor = Color.Orange;
            }
            else if(textBox1.Text.ToLower() == label9.Text.ToLower())
            {
                label9.BackColor = Color.Orange;
                label3.BackColor = Color.Orange;
            }else if(textBox1.Text.ToLower() == label10.Text.ToLower())
            {
                label10.BackColor = Color.Orange;
                label4.BackColor = Color.Orange;
            }else if(textBox1.Text.ToLower() == label11.Text.ToLower())
            {
                label11.BackColor = Color.Orange;
                label5.BackColor = Color.Orange;
            }else if(textBox1.Text.ToLower() == label12.Text.ToLower())
            {
                label12.BackColor = Color.Orange;
                label6.BackColor = Color.Orange;
            }
            else
            {
                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
                label3.BackColor = Color.White;
                label4.BackColor = Color.White;
                label5.BackColor = Color.White;
                label6.BackColor = Color.White;
                label7.BackColor = Color.White;
                label8.BackColor = Color.White;
                label9.BackColor = Color.White;
                label10.BackColor = Color.White;
                label11.BackColor = Color.White;
                label12.BackColor = Color.White;
            }
        }
    }
}
