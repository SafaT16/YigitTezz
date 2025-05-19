using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class AGrubu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AGrubu));
            pictureBox1 = new PictureBox();
            textGovdeSkor = new TextBox();
            textBoyunSkor = new TextBox();
            textBacakSkor = new TextBox();
            label1 = new Label();
            label3 = new Label();
            BtnDevamEt = new Button();
            labelsonuc = new Label();
            pictureBox2 = new PictureBox();
            textboxAgirlik = new TextBox();
            labelPuan = new Label();
            label5 = new Label();
            CmbGuc = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            labelToplam = new Label();
            groupBox2 = new GroupBox();
            BtnHesapla = new Button();
            groupBox6 = new GroupBox();
            label10 = new Label();
            groupBox4 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.Image = Properties.Resources.Ekran_görüntüsü_2025_01_03_231429;
            pictureBox1.Location = new Point(21, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 416);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textGovdeSkor
            // 
            textGovdeSkor.Anchor = AnchorStyles.None;
            textGovdeSkor.BackColor = Color.White;
            textGovdeSkor.Location = new Point(114, 49);
            textGovdeSkor.Multiline = true;
            textGovdeSkor.Name = "textGovdeSkor";
            textGovdeSkor.Size = new Size(125, 24);
            textGovdeSkor.TabIndex = 0;
            // 
            // textBoyunSkor
            // 
            textBoyunSkor.Anchor = AnchorStyles.None;
            textBoyunSkor.BackColor = Color.White;
            textBoyunSkor.Location = new Point(114, 82);
            textBoyunSkor.Multiline = true;
            textBoyunSkor.Name = "textBoyunSkor";
            textBoyunSkor.Size = new Size(125, 23);
            textBoyunSkor.TabIndex = 1;
            // 
            // textBacakSkor
            // 
            textBacakSkor.Anchor = AnchorStyles.None;
            textBacakSkor.BackColor = Color.White;
            textBacakSkor.Location = new Point(114, 20);
            textBacakSkor.Multiline = true;
            textBacakSkor.Name = "textBacakSkor";
            textBacakSkor.Size = new Size(125, 23);
            textBacakSkor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(245, 19);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 8;
            label1.Text = "Reba Skorlama Formu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(171, 19);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 10;
            label3.Text = "A Grubu";
            // 
            // BtnDevamEt
            // 
            BtnDevamEt.BackColor = Color.Lavender;
            BtnDevamEt.ForeColor = SystemColors.Desktop;
            BtnDevamEt.Location = new Point(12, 461);
            BtnDevamEt.Name = "BtnDevamEt";
            BtnDevamEt.Size = new Size(94, 29);
            BtnDevamEt.TabIndex = 14;
            BtnDevamEt.Text = "Devam Et";
            BtnDevamEt.UseVisualStyleBackColor = false;
            BtnDevamEt.Click += button1_Click;
            // 
            // labelsonuc
            // 
            labelsonuc.AutoSize = true;
            labelsonuc.Location = new Point(182, 54);
            labelsonuc.Name = "labelsonuc";
            labelsonuc.Size = new Size(18, 20);
            labelsonuc.TabIndex = 17;
            labelsonuc.Text = "...";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 475);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(435, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // textboxAgirlik
            // 
            textboxAgirlik.BackColor = Color.White;
            textboxAgirlik.Location = new Point(166, 31);
            textboxAgirlik.Name = "textboxAgirlik";
            textboxAgirlik.Size = new Size(125, 27);
            textboxAgirlik.TabIndex = 20;
            // 
            // labelPuan
            // 
            labelPuan.AutoSize = true;
            labelPuan.Location = new Point(182, 28);
            labelPuan.Name = "labelPuan";
            labelPuan.Size = new Size(18, 20);
            labelPuan.TabIndex = 25;
            labelPuan.Text = "...";
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.Grip;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(9, 28);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 24;
            label5.Text = "Yük Skoru: ";
            // 
            // CmbGuc
            // 
            CmbGuc.BackColor = Color.FromArgb(224, 224, 224);
            CmbGuc.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbGuc.FormattingEnabled = true;
            CmbGuc.Items.AddRange(new object[] { "Evet", "Hayır" });
            CmbGuc.Location = new Point(166, 72);
            CmbGuc.Name = "CmbGuc";
            CmbGuc.Size = new Size(125, 28);
            CmbGuc.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(6, 75);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 22;
            label4.Text = "Ani Güç Kullanıldı mı?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(6, 34);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 21;
            label2.Text = "Ağırlık: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(9, 54);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 22;
            label7.Text = "Vücut Pozisyon Skorları:";
            // 
            // labelToplam
            // 
            labelToplam.AutoSize = true;
            labelToplam.Location = new Point(182, 84);
            labelToplam.Name = "labelToplam";
            labelToplam.Size = new Size(18, 20);
            labelToplam.TabIndex = 23;
            labelToplam.Text = "...";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(BtnHesapla);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(BtnDevamEt);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(483, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 516);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reba Skorlama Formu";
            // 
            // BtnHesapla
            // 
            BtnHesapla.BackColor = Color.Lavender;
            BtnHesapla.ForeColor = SystemColors.Desktop;
            BtnHesapla.Location = new Point(12, 302);
            BtnHesapla.Name = "BtnHesapla";
            BtnHesapla.Size = new Size(94, 29);
            BtnHesapla.TabIndex = 15;
            BtnHesapla.Text = "Hesapla";
            BtnHesapla.UseVisualStyleBackColor = false;
            BtnHesapla.Click += btnDevam_Click_1;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.GradientInactiveCaption;
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(labelToplam);
            groupBox6.Controls.Add(labelPuan);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(labelsonuc);
            groupBox6.Location = new Point(6, 337);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(308, 118);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "Skor Bilgileri";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Desktop;
            label10.Location = new Point(9, 84);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 26;
            label10.Text = "A Grubu Skoru: ";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.GradientInactiveCaption;
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(textBacakSkor);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(textBoyunSkor);
            groupBox4.Controls.Add(textGovdeSkor);
            groupBox4.Location = new Point(6, 152);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 144);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vücut Pozisyon Skorları";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Desktop;
            label9.Location = new Point(9, 85);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 2;
            label9.Text = "Bacak Skoru:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Desktop;
            label8.Location = new Point(9, 23);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 1;
            label8.Text = "Gövde Skoru:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(9, 52);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 0;
            label6.Text = "Boyun Skoru:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientInactiveCaption;
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textboxAgirlik);
            groupBox3.Controls.Add(CmbGuc);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(6, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(308, 120);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Yük Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(151, 461);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Ana Menü";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // AGrubu
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(848, 604);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.GrayText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AGrubu";
            Text = " ";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TextBox textBoyunSkor;
        private TextBox textGovdeSkor;
        private TextBox textBacakSkor;
        private Button BtnDevamEt;
        private Label labelsonuc;
        private PictureBox pictureBox2;
        private TextBox textboxAgirlik;
        private Label label4;
        private Label label2;
        private ComboBox CmbGuc;
        private Label labelPuan;
        private Label label5;
        private Label label7;
        private Label labelToplam;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox6;
        private Label label9;
        private Label label8;
        private Label label6;
        private Button BtnHesapla;
        private Label label10;
        private Button button1;
    }
}