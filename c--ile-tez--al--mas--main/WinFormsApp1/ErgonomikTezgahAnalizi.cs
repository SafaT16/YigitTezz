using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ErgonomikTezgahAnalizi : Form
    {
        public ErgonomikTezgahAnalizi()
        {
            InitializeComponent();
        }









        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            double workerHeight = double.Parse(txtWorkerHeight.Text);
            double benchHeight = double.Parse(txtBenchHeight.Text);
            string taskType = GetSelectedTaskType();

            var result = CalculateErgonomics(workerHeight, benchHeight, taskType);
            DisplayResults(result);
            


        }
        private bool ValidateInputs()
        {
            if (!double.TryParse(txtWorkerHeight.Text, out double workerHeight) || workerHeight <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir çalışan boyu giriniz.");
                return false;
            }

            if (!double.TryParse(txtBenchHeight.Text, out double benchHeight) || benchHeight <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tezgah yüksekliği giriniz.");
                return false;
            }

            return true;
        }
        private string GetSelectedTaskType()
        {


            if (rbPrecision.Checked) return "precision";
            if (rbLight.Checked) return "light";
            if (rbHeavy.Checked) return "heavy";
            return "light";
        }
        private ErgonomicResult CalculateErgonomics(double workerHeight, double benchHeight, string taskType)
        {
            double elbowHeight = workerHeight * 0.62;

            double idealHeight, minHeight, maxHeight;

            switch (taskType)
            {
                case "precision":
                    minHeight = elbowHeight * 1.1;
                    maxHeight = elbowHeight * 1.15;
                    idealHeight = elbowHeight * 1.12;
                    break;
                case "light":
                    minHeight = elbowHeight * 0.9;
                    maxHeight = elbowHeight * 0.95;
                    idealHeight = elbowHeight * 0.92;
                    break;
                case "heavy":
                    minHeight = elbowHeight * 0.8;
                    maxHeight = elbowHeight * 0.85;
                    idealHeight = elbowHeight * 0.82;
                    break;
                default:
                    minHeight = elbowHeight * 0.9;
                    maxHeight = elbowHeight * 0.95;
                    idealHeight = elbowHeight * 0.92;
                    break;
            }

            bool isErgonomic = benchHeight >= minHeight && benchHeight <= maxHeight;

            return new ErgonomicResult
            {
                Ideal = Math.Round(idealHeight, 1),
                Min = Math.Round(minHeight, 1),
                Max = Math.Round(maxHeight, 1),
                Current = benchHeight,
                IsErgonomic = isErgonomic,
                TaskType = taskType
            };
        }
        private void DisplayResults(ErgonomicResult result)
        {
            if (rbHeavy.Checked || rbLight.Checked || rbPrecision.Checked)
            {
                lblIdealHeight.Text = $"İdeal: {result.Ideal} cm";
                lblRange.Text = $"Aralık: {result.Min} - {result.Max} cm";
                lblCurrentHeight.Text = $"Mevcut: {result.Current} cm";

                if (result.IsErgonomic)
                {
                    lblResultTitle.Text = "Tezgah yüksekliği ergonomik!";
                    lblResultTitle.ForeColor = Color.Green;
                    lblAdjustment.Text = "";
                }
                else
                {
                    lblResultTitle.Text = "Tezgah yüksekliği ergonomik değil!";
                    lblResultTitle.ForeColor = Color.Red;

                    double fark = Math.Round(Math.Abs(result.Ideal - result.Current), 1);
                    string yon = result.Ideal > result.Current ? "yükseltilmeli" : "alçaltılmalı";
                    lblAdjustment.Text = $"Yükseklik {fark} cm {yon}.";
                }
            }
            else 
            {
                MessageBox.Show("Lütfen iş türü seçin");
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AnaEkran form1 = new AnaEkran();
            form1.Show();
            this.Hide();
        }

        private void lblAdjustment_Click(object sender, EventArgs e)
        {

        }

        private void rbPrecision_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Hassas el işleri, montaj, yazma gibi işler için \n uygundur!";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbLight_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Paketleme, hafif montaj, klavye kullanımı gibi \n işler için uygundur!";
        }

        private void rbHeavy_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Ağır malzemelerin taşınması, kaldırılması  gibi \n işler için uygundur!";        }
    }
    public class ErgonomicResult
    {
        public double Ideal { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Current { get; set; }
        public bool IsErgonomic { get; set; }
        public string TaskType { get; set; }
    }








}

