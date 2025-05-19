namespace WinFormsApp1
{
    partial class BGrubu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BGrubu));
            label1 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label5 = new Label();
            groupBox1 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            comboBox4 = new ComboBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            comboBox5 = new ComboBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label15 = new Label();
            label10 = new Label();
            label9 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(194, 64);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "B Grubu ";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(191, 190);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 24);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyDown += Form4_KeyDown;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(191, 160);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 24);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged_1;
            textBox1.KeyDown += Form4_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(187, 28);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 24);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyDown += Form4_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(499, 64);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 3;
            label2.Text = "Belirlenen Skorlar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ekran_görüntüsü_2025_01_03_2314071;
            pictureBox1.Location = new Point(37, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Location = new Point(17, 132);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Sonuç";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(17, 60);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 17;
            label3.Text = "B Grubu Skoru =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(972, 503);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 18;
            label4.Text = "                                   ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 19;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(460, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 260);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 191);
            label14.Name = "label14";
            label14.Size = new Size(80, 20);
            label14.TabIndex = 28;
            label14.Text = "Bilek Skor::";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 161);
            label13.Name = "label13";
            label13.Size = new Size(94, 20);
            label13.TabIndex = 27;
            label13.Text = "Alt Kol Skor: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 29);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 26;
            label12.Text = "Üst Kol Skor: ";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Evet", "Hayır" });
            comboBox4.Location = new Point(189, 218);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(165, 28);
            comboBox4.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 127);
            label11.Name = "label11";
            label11.Size = new Size(168, 20);
            label11.TabIndex = 10;
            label11.Text = "Kollar destekleniyor mu:";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Evet", "Hayır" });
            comboBox3.Location = new Point(189, 124);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(165, 28);
            comboBox3.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 221);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 8;
            label8.Text = "Bilekte dönme var mı:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Evet", "Hayır" });
            comboBox2.Location = new Point(189, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 28);
            comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Evet", "Hayır" });
            comboBox1.Location = new Point(189, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 28);
            comboBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 93);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 5;
            label7.Text = "Omuz yükseltilmiş mi: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 59);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 4;
            label6.Text = "Kolda dönme var mı:";
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "İyi", "Orta", "Zayıf" });
            comboBox5.Location = new Point(187, 26);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(169, 28);
            comboBox5.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Location = new Point(262, 132);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 24;
            button1.Text = "İlerle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(comboBox5);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(460, 356);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(384, 167);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(17, 34);
            label15.Name = "label15";
            label15.Size = new Size(134, 20);
            label15.TabIndex = 25;
            label15.Text = "Kavrama Seviyesi:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(187, 60);
            label10.Name = "label10";
            label10.Size = new Size(21, 20);
            label10.TabIndex = 22;
            label10.Text = "...";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(1066, 467);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 21;
            label9.Text = "Sonuç:";
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Location = new Point(143, 132);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 26;
            button3.Text = "Geri Gel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // BGrubu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(878, 610);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BGrubu";
            Text = "B Grubu ";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label3;
        private Label label4;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label7;
        private Label label6;
        private ComboBox comboBox3;
        private Label label8;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label11;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Button button1;
        private GroupBox groupBox2;
        private Label label12;
        private Label label14;
        private Label label13;
        private Label label10;
        private Label label9;
        private Label label15;
        private Button button3;
    }
}