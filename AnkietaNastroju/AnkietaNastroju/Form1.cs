using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnkietaNastroju
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPodsumowanie_Click(object sender, EventArgs e)
        {
            KalkulatorZadowolenia kalkulator = new KalkulatorZadowolenia();
            kalkulator.Pytanie1 = this.comboBoxPytanie1.Text;

            List<string> odp2 = new List<string>();
            foreach (string text in this.checkedListBoxPytanie2.CheckedItems)
            {
                odp2.Add(text);
            }
            kalkulator.Pytanie2 = odp2;
            kalkulator.Pytanie3 = this.radioButtonPytanie3Tak.Checked;
            kalkulator.Pytanie3Bis = (string)this.listBoxPytanie3bis.SelectedItem;
            kalkulator.Pytanie4 = numericUpDownPytanie4.Value;

            WynikAnkiety wynikAnkiety = new WynikAnkiety(kalkulator.WyliczPoziomZadowolenia());
            wynikAnkiety.ShowDialog();
        }

        private void radioButtonPytanie3Tak_CheckedChanged(object sender, EventArgs e)
        {
            this.listBoxPytanie3bis.Enabled = !this.radioButtonPytanie3Tak.Checked;
        }

        private void comboBoxPytanie1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
