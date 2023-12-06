namespace ŞEYMA1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox2 = new ComboBox();
            ShowDetails = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(300, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(814, 131);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            // 
            // ShowDetails
            // 
            ShowDetails.BackColor = Color.PapayaWhip;
            ShowDetails.BackgroundImage = (Image)resources.GetObject("ShowDetails.BackgroundImage");
            ShowDetails.ImageAlign = ContentAlignment.TopCenter;
            ShowDetails.Location = new Point(775, 256);
            ShowDetails.Name = "ShowDetails";
            ShowDetails.Size = new Size(190, 252);
            ShowDetails.TabIndex = 7;
            ShowDetails.UseVisualStyleBackColor = false;
            ShowDetails.Click += ShowDetails_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(591, 256);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(603, 252);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(377, 9);
            label1.Name = "label1";
            label1.Size = new Size(543, 48);
            label1.TabIndex = 9;
            label1.Text = "HAYDİ BİRLİKTE ÖĞRENELİM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(591, 198);
            label2.Name = "label2";
            label2.Size = new Size(546, 25);
            label2.TabIndex = 10;
            label2.Text = "BİLGİ KARTINI AÇMAK İÇİN SORU İŞARETİNE TIKLAYINIZ!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(245, 84);
            label3.Name = "label3";
            label3.Size = new Size(261, 25);
            label3.TabIndex = 11;
            label3.Text = "ANA KATAGORİYİ SEÇİNİZ.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 255);
            label4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(761, 84);
            label4.Name = "label4";
            label4.Size = new Size(256, 25);
            label4.TabIndex = 12;
            label4.Text = "ALT KATAGORİYİ SEÇİNİZ.";
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(71, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1343, 643);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(ShowDetails);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox2;
        private Button ShowDetails;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}