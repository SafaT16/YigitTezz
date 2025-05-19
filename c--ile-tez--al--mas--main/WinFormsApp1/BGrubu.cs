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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class BGrubu : Form
    {
        public string sayi2;


        public BGrubu()
        {
            InitializeComponent();
        }
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true; // Enter tuşunun varsayılan davranışını engelle
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            // 3B REBA skor tablosu: [boyun, bacak, govde]
            int[,,] rebaB = new int[2, 6, 3]
{
    // Alt Kol 1
    {
        // Bilek 1
        { 1,2,2},
        // Bilek 2
        { 1,2,3},
        // Bilek 3
        { 3,4,5},
        {
            4,5,5
        },
        {6,7,8 },
        {
            7,8,8
        }
    },

    // Alt Kol 2
    {
        // Bilek 1
        { 1,2,3},
        // Bilek 2
        {2,3,4},
        // Bilek 3
        { 4, 5, 5 },
        {
            5,6,7
        },
        {7,8,8 },
        { 8,9,9 }
    }
};

            try
            {
                int boyun = int.Parse(textBox1.Text);   // 1–3
                int bacak = int.Parse(textBox2.Text);   // 1–4
                int govde = int.Parse(textBox3.Text);   // 1–5

                int boyunIndex = boyun - 1;
                int bacakIndex = bacak - 1;
                int govdeIndex = govde - 1;

                if (boyunIndex < 0 || boyunIndex > 2 || bacakIndex < 0 || bacakIndex > 4 || govdeIndex < 0 || govdeIndex > 2)
                {
                    MessageBox.Show("Lütfen geçerli aralıkta değerler giriniz:\nBoyun: 1–3\nBacak: 1–4\nGövde: 1–4");
                    return;
                }

                int skor = rebaB[boyunIndex, bacakIndex, govdeIndex];


                if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Evet")
                {
                    skor += 1;
                }

                if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Evet")
                {
                    skor += 1;
                }
                if (comboBox3.SelectedItem != null && comboBox3.SelectedItem.ToString() == "Evet")
                {
                    skor -= 1;
                }
                if (comboBox4.SelectedItem != null && comboBox4.SelectedItem.ToString() == "Evet")
                {
                    skor += 1;
                }
                int toplamskor = 0;
                if (comboBox5.SelectedItem != null && comboBox5.SelectedItem.ToString() == "Orta")
                {
                    skor += 1;
                }
                if (comboBox5.SelectedItem != null && comboBox5.SelectedItem.ToString() == "Zayıf")
                {
                    skor += 2;
                }
                if (comboBox5.SelectedItem != null && comboBox5.SelectedItem.ToString() == "İyi")
                {
                    skor += 0;
                }
                // Skoru göster
                label4.Text = "B Grubu Skoru: " + skor.ToString();


                int skors = toplamskor + skor;
                label10.Text = skor.ToString();
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(comboBox1.Text)
                || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox3.Text)
                || string.IsNullOrWhiteSpace(comboBox4.Text)
                || string.IsNullOrWhiteSpace(comboBox5.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi");

                    return;
                }




            }
            catch
            {
                MessageBox.Show("Lütfen tüm alanlara sayısal değerler giriniz.");
            }
            button1.Enabled = true;





            /* int yukSkoru = 0;

             try
             {
                 double agirlik = double.Parse(textBox1.Text); // kilogram cinsinden değer

                 // Ağırlığa göre puanlama
                 if (agirlik < 20)
                     yukSkoru = 0;
                 else if (agirlik >= 20 && agirlik <= 45)
                     yukSkoru = 1;
                 else // agirlik > 10
                     yukSkoru = 2;



                 label10.Text = "Yük Skoru: " + yukSkoru.ToString();
             }
             catch
             {
                 MessageBox.Show("Lütfen geçerli bir ağırlık değeri giriniz.");
             }
            */

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CGrubu form5 = new CGrubu(); // Form2'nin bir örneğini oluştur
            form5.sayi1 = label10.Text;
            label5.Text = sayi2;
            form5.sayi2 = label5.Text;
            form5.Show(); // Form2'yi göster
            this.Hide();  // İsteğe bağlı: Form1'i gizle (kapatmaz)
            string deger3 = label10.Text; // Form1'deki label değeri

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AGrubu aGrubu = new AGrubu();
            aGrubu.Show();
            this.Hide();
        }
    }
}
   

