using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace MegaDesk___Greeff
{
    public partial class ThirdForm : Form
    {
        public ThirdForm()
        {
            InitializeComponent();
        }

        DeskQuote quote = SecondForm.quote;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 viewSecondForm = new Form1();
            viewSecondForm.Tag = this;
            viewSecondForm.Show(this);
            Hide();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void materialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void drawerBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Depth_Click(object sender, EventArgs e)
        {
        }

        private void Width_Click(object sender, EventArgs e)
        {
        }



        private void depthBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void widthBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
