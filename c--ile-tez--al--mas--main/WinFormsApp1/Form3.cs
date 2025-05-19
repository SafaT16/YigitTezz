using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        private int sayi1;
        private int sayi2;
        public Form3(int gelenSayi1, int gelenSayi2)
        {
            InitializeComponent();
            InitializeComponent();

            
            sayi1 = gelenSayi1;
            sayi2 = gelenSayi2;

            // Örnek kullanım:
            int toplam = sayi1 + sayi2;
            label1.Text = $"Toplam: {toplam}";

        }

        public Form3()
        {
        }

        // Form2.cs
        public int SayisalDeger => int.Parse(label1.Text);

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
