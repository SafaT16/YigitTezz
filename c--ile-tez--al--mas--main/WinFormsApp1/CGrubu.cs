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
    public partial class CGrubu : Form
    {
        public string sayi1;
        public string sayi2;
        public CGrubu()
        {
            InitializeComponent();
        }



        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = sayi1;
            label2.Text = sayi2;
        }
        int rebaC;
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxRecommendation.ReadOnly = true;
            int rebaA = int.Parse(label1.Text);
            int rebaB = int.Parse(label2.Text);


            // REBA C matrisini tanımla
            int[,] CMatrix = new int[,]
            {
        { 1, 2, 3, 3, 4, 4, 5, 6, 7, 7, 8, 8 },
        { 2, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8, 8 },
        { 3, 3, 4, 4, 5, 6, 6, 7, 8, 8, 8, 9 },
        { 3, 4, 4, 5, 6, 6, 7, 8, 8, 8, 9, 9 },
        { 4, 4, 5, 6, 6, 7, 8, 8, 9, 9,10,10 },
        { 5, 5, 6, 6, 7, 8, 8, 9, 9,10,10,11 },
        { 6, 6, 7, 8, 8, 9, 9,10,10,11,11,12 },
        { 7, 7, 8, 8, 9, 9,10,10,11,11,12,12 },
        { 8, 8, 9, 9,10,10,11,11,12,12,12,12 },
        { 9, 9,10,10,11,11,12,12,12,12,12,12 },
        {10,10,11,11,12,12,12,12,12,12,12,12 },
        {12,12,12,12,12,12,12,12,12,12,12,12 }
            };

            // Dizideki indexler 0'dan başladığı için -1
            int aIndex = rebaA - 1;
            int bIndex = rebaB - 1;

            // Skorları kontrol et
            if (aIndex >= 0 && aIndex < 12 && bIndex >= 0 && bIndex < 12)
            {


                rebaC = CMatrix[aIndex, bIndex];
                if (checkBox1.Checked)
                {
                    rebaC += 1;
                }
                if (checkBox2.Checked)
                {
                    rebaC += 1;
                }
                if (checkBox3.Checked)
                {
                    rebaC += 1;
                }
                label3.Text = rebaC.ToString();
            }
            else
            {
                label3.Text = "Geçersiz A veya B skoru!";
            }

            string derece = "";
            string oneriler = "";

            if (rebaC <= 3)
            {
                derece = "Derece 1 (REBA Skoru: 2–3) – Düşük Risk";
                oneriler = "• TAVSİYE EDİLEN ÖNERİLER •\n" +
                           "• Ergonomi eğitimi verilerek küçük duruş hataları önlenebilir.\n" +
                           "• Anti-fatigue mat sağlanabilir.\n" +
                           "• Araç-gereçler doğal erişim mesafesine alınabilir.\n" +
                           "• Ayakta/oturarak çalışma seçeneği sunulabilir.\n" +
                           "• Çalışma temposu düşürülerek tekrarlı hareketler azaltılabilir.";
            }
            else if (rebaC <= 7)
            {
                derece = "Derece 2 (REBA Skoru: 4–7) – Orta Risk";
                oneriler = "• TAVSİYE EDİLEN ÖNERİLER •\n" +
                    "• Tezgâh yüksekliği antropometrik ölçülere göre ayarlanmalı.\n" +
                           "• İş rotasyonu uygulanabilir.\n" +
                           "• Kızak, raylı sistemler entegre edilebilir.\n" +
                           "• Turntable ya da kaldırma platformu eklenebilir.\n" +
                           "• Mikro molalar planlanabilir.\n" +
                           "• Modüler sistemli düzenlemeler yapılabilir.";
            }
            else if (rebaC <= 10)
            {
                derece = "Derece 3 (REBA Skoru: 8–10) – Yüksek Risk";
                oneriler = "• TAVSİYE EDİLEN ÖNERİLER •\n" +
                    "• İstasyon ergonomik prensiplerle yeniden tasarlanmalı.\n" +
                           "• Otomatik/pnömatik sistemlerle desteklenmeli.\n" +
                           "• Ayarlanabilir masa/sehpa kullanılmalı.\n" +
                           "• Bel, boyun destekleri eklenmeli.\n" +
                           "• Çalışan sayısı artırılarak yük paylaşılmalı.\n" +
                           "• Ayak basamakları ve diz destekleri eklenmeli.";
            }
            else // 11–15
            {
                derece = "Derece 4 (REBA Skoru: 11–15) – Çok Yüksek Risk";
                oneriler = "• İstasyon tamamen yeniden yapılandırılmalı.\n" +
                           "• Kaldırma ekipmanları entegre edilmeli.\n" +
                           "• Çalışma geçici olarak durdurulmalı.\n" +
                           "• İş akışı yeniden tasarlanmalı.\n" +
                           "• Bariyerler, yönlendirici sistemler eklenmeli.\n" +
                           "• Risk değerlendirmesi yapılmalı.";
            }

            lblRebaDegree.Text = derece;
            richTextBoxRecommendation.Text = oneriler;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaEkran form1 = new AnaEkran();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BGrubu bGrubu = new BGrubu();
            bGrubu.Show();
            this.Hide();
        }
    }
}
