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
            loadButton = new Button();
            infoBox = new Label();
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
            // loadButton
            // 
            loadButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            loadButton.Location = new Point(234, 336);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(121, 34);
            loadButton.TabIndex = 39;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // infoBox
            // 
            infoBox.BackColor = SystemColors.ButtonHighlight;
            infoBox.BorderStyle = BorderStyle.FixedSingle;
            infoBox.Location = new Point(190, 9);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(222, 289);
            infoBox.TabIndex = 40;
            infoBox.Click += infoBox_Click;
            // 
            // ThirdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 382);
            Controls.Add(infoBox);
            Controls.Add(loadButton);
            Controls.Add(button2);
            Name = "ThirdForm";
            Text = "ThirdForm";
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button2;
        private Button loadButton;
        private Label infoBox;
    }
}