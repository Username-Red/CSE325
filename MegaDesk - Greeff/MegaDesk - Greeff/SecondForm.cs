using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk___Greeff
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Form1 viewSecondForm = new Form1();
            viewSecondForm.Tag = this;
            viewSecondForm.Show(this);
            Hide();
        }

        private void Width_Validating(object sender, EventArgs e)
        {
            double width;
            double depth;

            try
            {
                width = Convert.ToInt32(widthBox.Text);


            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                widthBox.Text = "Numbers only";

                throw;
            }

            if (width < Desk.MINWIDTH)
            {
                // Do the good code
                width = Desk.MINWIDTH;
            }

            else if (width < Desk.MAXWIDTH)
            {
                // Do the bad code
                width = Desk.MAXWIDTH;
            }



            else
            {
                // Do the whoopsy code
            }
        }

        private void depthBox_Validating(object sender, CancelEventArgs e)
        {
            double depth;

            try
            {
                depth = Convert.ToInt32(depthBox.Text);

            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                widthBox.Text = "Number only";
                throw;
            }

            if (depth < Desk.MAXDEPTH)
            {
                // Do the bad code
                depth = Desk.MAXDEPTH;
            }

            else if (depth > Desk.MAXDEPTH)
            {
                // Do the bad code
                depth = Desk.MAXDEPTH;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            double width1 = Convert.ToDouble(widthBox.Text);
            double depth1 = Convert.ToDouble(depthBox.Text);
            int drawerCount = Convert.ToInt32(drawerBox.Text);
            string material = materialBox.Text;


            int rushDays = Convert.ToInt32(rushBox.Text);
            string name = nameBox.Text;
            DateTime date = DateTime.Now;

            string info = $"{width1}\n{depth1}]\n{drawerCount}\n{material}\n{rushDays}\n{name}\n{date}";
            string file = "deskQuote.txt";
            File.WriteAllText(file, info);
            Desk desk = new Desk(width1, depth1, drawerCount, material);


            DeskQuote quote = new DeskQuote(desk, rushDays, name, date);

            ThirdForm viewThirdForm = new ThirdForm();


            viewThirdForm.Tag = this;
            viewThirdForm.Show(this);
            Hide();


        }
    }
}
