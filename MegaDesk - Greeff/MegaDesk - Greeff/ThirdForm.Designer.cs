namespace MegaDesk___Greeff
{
    partial class ThirdForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            nameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Depth = new Label();
            Width = new Label();
            rushBox = new TextBox();
            materialBox = new TextBox();
            drawerBox = new TextBox();
            depthBox = new TextBox();
            widthBox = new TextBox();
            totalBox = new TextBox();
            dateBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 336);
            button2.Name = "button2";
            button2.Size = new Size(121, 34);
            button2.TabIndex = 3;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(216, 23);
            label3.TabIndex = 27;
            label3.Text = "Rush order selection";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 39);
            label4.Name = "label4";
            label4.Size = new Size(216, 23);
            label4.TabIndex = 26;
            label4.Text = "Customer Name";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(234, 42);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "name here";
            nameBox.Size = new Size(89, 23);
            nameBox.TabIndex = 25;
            nameBox.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 167);
            label1.Name = "label1";
            label1.Size = new Size(216, 23);
            label1.TabIndex = 24;
            label1.Text = "Material";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(216, 23);
            label2.TabIndex = 23;
            label2.Text = "Number Of Drawers";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Depth
            // 
            Depth.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Depth.Location = new Point(12, 254);
            Depth.Name = "Depth";
            Depth.Size = new Size(216, 23);
            Depth.TabIndex = 21;
            Depth.Text = "Depth (In inches Squared)";
            Depth.TextAlign = ContentAlignment.MiddleCenter;
            Depth.Click += Depth_Click;
            // 
            // Width
            // 
            Width.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Width.Location = new Point(12, 211);
            Width.Name = "Width";
            Width.Size = new Size(216, 23);
            Width.TabIndex = 20;
            Width.Text = "Width (In inches Squared)";
            Width.TextAlign = ContentAlignment.MiddleCenter;
            Width.Click += Width_Click;
            // 
            // rushBox
            // 
            rushBox.Location = new Point(234, 82);
            rushBox.Name = "rushBox";
            rushBox.PlaceholderText = "name here";
            rushBox.Size = new Size(89, 23);
            rushBox.TabIndex = 30;
            // 
            // materialBox
            // 
            materialBox.Location = new Point(234, 167);
            materialBox.Name = "materialBox";
            materialBox.PlaceholderText = "name here";
            materialBox.Size = new Size(89, 23);
            materialBox.TabIndex = 32;
            // 
            // drawerBox
            // 
            drawerBox.Location = new Point(234, 127);
            drawerBox.Name = "drawerBox";
            drawerBox.PlaceholderText = "name here";
            drawerBox.Size = new Size(89, 23);
            drawerBox.TabIndex = 31;
            // 
            // depthBox
            // 
            depthBox.Location = new Point(234, 254);
            depthBox.Name = "depthBox";
            depthBox.PlaceholderText = "name here";
            depthBox.Size = new Size(89, 23);
            depthBox.TabIndex = 34;
            // 
            // widthBox
            // 
            widthBox.Location = new Point(234, 214);
            widthBox.Name = "widthBox";
            widthBox.PlaceholderText = "name here";
            widthBox.Size = new Size(89, 23);
            widthBox.TabIndex = 33;
            // 
            // totalBox
            // 
            totalBox.Location = new Point(409, 250);
            totalBox.Name = "totalBox";
            totalBox.PlaceholderText = "name here";
            totalBox.Size = new Size(143, 23);
            totalBox.TabIndex = 38;
            totalBox.TextChanged += textBox6_TextChanged;
            // 
            // dateBox
            // 
            dateBox.Location = new Point(409, 160);
            dateBox.Name = "dateBox";
            dateBox.PlaceholderText = "name here";
            dateBox.Size = new Size(143, 23);
            dateBox.TabIndex = 37;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(444, 214);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 36;
            label5.Text = "Total\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(444, 127);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 35;
            label6.Text = "Date\r\n";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ThirdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 382);
            Controls.Add(totalBox);
            Controls.Add(dateBox);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(depthBox);
            Controls.Add(widthBox);
            Controls.Add(materialBox);
            Controls.Add(drawerBox);
            Controls.Add(rushBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Depth);
            Controls.Add(Width);
            Controls.Add(button2);
            Name = "ThirdForm";
            Text = "ThirdForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox nameBox;
        private Label label1;
        private Label label2;
        private Label Depth;
        private Label Width;
        private TextBox rushBox;
        private TextBox materialBox;
        private TextBox drawerBox;
        private TextBox depthBox;
        private TextBox widthBox;
        private TextBox totalBox;
        private TextBox dateBox;
        private Label label5;
        private Label label6;
    }
}