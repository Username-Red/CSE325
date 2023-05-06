namespace MegaDesk_Greeff
{
    public partial class MegaDesk : Form
    {
        //public MegaDesk()
        //{
        //    InitializeComponent();
        //}

        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 31);
            button1.Name = "button1";
            button1.Size = new Size(257, 68);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            ClientSize = new Size(604, 376);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }




        //public void CalculatePrice()
        //{
        //    double area = Desk.Area();
        //    int drawerPrice = Desk.DrawerCount() * 50;
        //    double materialPrice = Materials[Desk._material];
        //    double price;

        //    if (area > 1000)
        //    {
        //        price = area + drawerPrice + materialPrice;
        //    }

        //    else if (area <= 1000)
        //    {
        //        price = 200 + drawerPrice + materialPrice;
        //    }
        //}

        

        private Button button1;
    }
}