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
    public partial class delivery_division : UserControl
    {
        public delivery_division()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Tulis nama kecamatan, kota, provinsi")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Tulis nama kecamatan, kota, provinsi";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
