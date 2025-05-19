namespace WinFormsApp1
{
    partial class ErgonomikTezgahAnalizi
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            btnAnalyze = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            rbHeavy = new RadioButton();
            rbLight = new RadioButton();
            rbPrecision = new RadioButton();
            label5 = new Label();
            txtBenchHeight = new TextBox();
            txtWorkerHeight = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panelAdjustment = new Panel();
            lblAdjustment = new Label();
            lblRange = new Label();
            lblIdealHeight = new Label();
            lblCurrentHeight = new Label();
            lblResultTitle = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panelAdjustment.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(149, 349);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(144, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(281, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(49, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 106);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 33);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 132);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // btnAnalyze
            // 
            btnAnalyze.BackColor = Color.Lavender;
            btnAnalyze.Location = new Point(384, 316);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(94, 29);
            btnAnalyze.TabIndex = 0;
            btnAnalyze.Text = "Analiz Et";
            btnAnalyze.UseVisualStyleBackColor = false;
            btnAnalyze.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtBenchHeight);
            groupBox2.Controls.Add(txtWorkerHeight);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(6, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 344);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ölçüm Bilgileri";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 284);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 7;
            label6.Text = "...";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbHeavy);
            groupBox3.Controls.Add(rbLight);
            groupBox3.Controls.Add(rbPrecision);
            groupBox3.Location = new Point(6, 200);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(322, 72);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "İş Tipi";
            // 
            // rbHeavy
            // 
            rbHeavy.AutoSize = true;
            rbHeavy.Location = new Point(210, 26);
            rbHeavy.Name = "rbHeavy";
            rbHeavy.Size = new Size(72, 24);
            rbHeavy.TabIndex = 10;
            rbHeavy.TabStop = true;
            rbHeavy.Text = "Ağır İş";
            rbHeavy.UseVisualStyleBackColor = true;
            rbHeavy.CheckedChanged += rbHeavy_CheckedChanged;
            // 
            // rbLight
            // 
            rbLight.AutoSize = true;
            rbLight.Location = new Point(110, 26);
            rbLight.Name = "rbLight";
            rbLight.Size = new Size(94, 24);
            rbLight.TabIndex = 9;
            rbLight.TabStop = true;
            rbLight.Text = "Normal İş";
            rbLight.UseVisualStyleBackColor = true;
            rbLight.CheckedChanged += rbLight_CheckedChanged;
            // 
            // rbPrecision
            // 
            rbPrecision.AutoSize = true;
            rbPrecision.Location = new Point(6, 26);
            rbPrecision.Name = "rbPrecision";
            rbPrecision.Size = new Size(89, 24);
            rbPrecision.TabIndex = 8;
            rbPrecision.TabStop = true;
            rbPrecision.Text = "Hassas iş";
            rbPrecision.UseVisualStyleBackColor = true;
            rbPrecision.CheckedChanged += rbPrecision_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 144);
            label5.Name = "label5";
            label5.Size = new Size(211, 20);
            label5.TabIndex = 5;
            label5.Text = "Mevcut Tezgah Yüksekliği (cm)";
            // 
            // txtBenchHeight
            // 
            txtBenchHeight.Location = new Point(30, 167);
            txtBenchHeight.Name = "txtBenchHeight";
            txtBenchHeight.Size = new Size(125, 27);
            txtBenchHeight.TabIndex = 4;
            // 
            // txtWorkerHeight
            // 
            txtWorkerHeight.Location = new Point(30, 114);
            txtWorkerHeight.Name = "txtWorkerHeight";
            txtWorkerHeight.Size = new Size(125, 27);
            txtWorkerHeight.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 91);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 2;
            label4.Text = "Çalışan Boyu (cm):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 47);
            label3.Name = "label3";
            label3.Size = new Size(240, 20);
            label3.TabIndex = 1;
            label3.Text = "Çalışan Ve Tezgah Bilgilerini Giriniz";
            // 
            // panelAdjustment
            // 
            panelAdjustment.Controls.Add(lblAdjustment);
            panelAdjustment.Controls.Add(lblRange);
            panelAdjustment.Controls.Add(lblIdealHeight);
            panelAdjustment.Controls.Add(lblCurrentHeight);
            panelAdjustment.Controls.Add(lblResultTitle);
            panelAdjustment.Location = new Point(363, 28);
            panelAdjustment.Name = "panelAdjustment";
            panelAdjustment.Size = new Size(267, 256);
            panelAdjustment.TabIndex = 0;
            // 
            // lblAdjustment
            // 
            lblAdjustment.AutoSize = true;
            lblAdjustment.Location = new Point(21, 158);
            lblAdjustment.Name = "lblAdjustment";
            lblAdjustment.Size = new Size(12, 20);
            lblAdjustment.TabIndex = 5;
            lblAdjustment.Text = ".";
            lblAdjustment.Click += lblAdjustment_Click;
            // 
            // lblRange
            // 
            lblRange.AutoSize = true;
            lblRange.Location = new Point(21, 128);
            lblRange.Name = "lblRange";
            lblRange.Size = new Size(12, 20);
            lblRange.TabIndex = 4;
            lblRange.Text = ".";
            // 
            // lblIdealHeight
            // 
            lblIdealHeight.AutoSize = true;
            lblIdealHeight.Location = new Point(21, 101);
            lblIdealHeight.Name = "lblIdealHeight";
            lblIdealHeight.Size = new Size(12, 20);
            lblIdealHeight.TabIndex = 3;
            lblIdealHeight.Text = ".";
            // 
            // lblCurrentHeight
            // 
            lblCurrentHeight.AutoSize = true;
            lblCurrentHeight.Location = new Point(21, 75);
            lblCurrentHeight.Name = "lblCurrentHeight";
            lblCurrentHeight.Size = new Size(12, 20);
            lblCurrentHeight.TabIndex = 2;
            lblCurrentHeight.Text = ".";
            // 
            // lblResultTitle
            // 
            lblResultTitle.AutoSize = true;
            lblResultTitle.Location = new Point(21, 31);
            lblResultTitle.Name = "lblResultTitle";
            lblResultTitle.Size = new Size(12, 20);
            lblResultTitle.TabIndex = 0;
            lblResultTitle.Text = ".";
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Location = new Point(536, 316);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Ana Menü";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // ErgonomikTezgahAnalizi
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(658, 368);
            Controls.Add(button2);
            Controls.Add(panelAdjustment);
            Controls.Add(groupBox2);
            Controls.Add(btnAnalyze);
            Name = "ErgonomikTezgahAnalizi";
            Text = "Ergonomik Tezgah Analizi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panelAdjustment.ResumeLayout(false);
            panelAdjustment.PerformLayout();
            ResumeLayout(false);
            // 
            // rula
            // 
            //            AutoScaleDimensions = new SizeF(8F, 20F);
            /*            AutoScaleMode = AutoScaleMode.Font;
                        ClientSize = new Size(800, 450);
                        Controls.Add(label2);
                        Controls.Add(label1);
                        Controls.Add(groupBox1);
                        Controls.Add(button1);
                        Controls.Add(textBox2);
                        Controls.Add(textBox1);
                        Name = "rula";
                        Text = "rula";
                        groupBox1.ResumeLayout(false);
                        groupBox1.PerformLayout();
                        ResumeLayout(false);
                        PerformLayout();*/
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button btnAnalyze;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox txtBenchHeight;
        private TextBox txtWorkerHeight;
        private RadioButton rbHeavy;
        private RadioButton rbLight;
        private RadioButton rbPrecision;
        private Panel panelAdjustment;
        private Label lblAdjustment;
        private Label lblRange;
        private Label lblIdealHeight;
        private Label lblCurrentHeight;
        private Label lblResultTitle;
        private Button button2;
        private Label label6;
    }
}