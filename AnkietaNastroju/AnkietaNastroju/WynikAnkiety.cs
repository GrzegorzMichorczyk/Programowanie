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
    public partial class WynikAnkiety : Form
    {
        public WynikAnkiety(PoziomZadowolenia poziomZadowolenia)
        {
            InitializeComponent();
            
            this.labelZadowolenie.Text = poziomZadowolenia.ToString();

            string nazwaObrka = "";
            if (poziomZadowolenia == PoziomZadowolenia.Dobrze)
            {
                this.labelZadowolenie.ForeColor = Color.Green;
                nazwaObrka = "dobrze.jpg";
            }
            else if (poziomZadowolenia == PoziomZadowolenia.Średnio)
            {
                this.labelZadowolenie.ForeColor = Color.Red;
                nazwaObrka = "srednio.jpg";
            }
            else if (poziomZadowolenia == PoziomZadowolenia.Źle)
            {
                this.labelZadowolenie.ForeColor = Color.Red;
                nazwaObrka = "zle.jpg";
            }

            pictureBox1.Image = Image.FromFile("zdjeciaNatrojow/"+nazwaObrka);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WynikAnkiety_Load(object sender, EventArgs e)
        {

        }
    }
}