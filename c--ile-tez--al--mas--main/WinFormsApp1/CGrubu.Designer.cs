namespace WinFormsApp1
{
    partial class CGrubu
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            lblRebaDegree = new Label();
            richTextBoxRecommendation = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Location = new Point(12, 226);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 67);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 1;
            label1.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 31);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 2;
            label2.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 263);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 3;
            label3.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 263);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 4;
            label4.Text = "C Skoru: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 201);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giriş Skorları";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(15, 155);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(134, 24);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Dengesiz Duruş";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 125);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(232, 24);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Tekrarlanan Kısa Aralıklı Eylem";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 95);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(164, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Vücut Bölümü Statik";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 67);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 1;
            label6.Text = "B Skoru: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 31);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 0;
            label5.Text = "A Skoru: ";
            // 
            // lblRebaDegree
            // 
            lblRebaDegree.AutoSize = true;
            lblRebaDegree.Location = new Point(301, 24);
            lblRebaDegree.Name = "lblRebaDegree";
            lblRebaDegree.Size = new Size(18, 20);
            lblRebaDegree.TabIndex = 5;
            lblRebaDegree.Text = "...";
            // 
            // richTextBoxRecommendation
            // 
            richTextBoxRecommendation.Location = new Point(301, 57);
            richTextBoxRecommendation.Name = "richTextBoxRecommendation";
            richTextBoxRecommendation.Size = new Size(412, 226);
            richTextBoxRecommendation.TabIndex = 6;
            richTextBoxRecommendation.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Location = new Point(538, 304);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Ana Menü";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Location = new Point(379, 305);
            button3.Name = "button3";
            button3.Size = new Size(94, 28);
            button3.TabIndex = 8;
            button3.Text = "Geri Gel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // CGrubu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(725, 344);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBoxRecommendation);
            Controls.Add(lblRebaDegree);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Name = "CGrubu";
            Text = "Reba C";
            Load += Form5_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label lblRebaDegree;
        private RichTextBox richTextBoxRecommendation;
        private Button button2;
        private Button button3;
    }
}