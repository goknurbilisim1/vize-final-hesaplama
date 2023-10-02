using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_final_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = Convert.ToDouble(txtVize.Text);
            final = Convert.ToDouble(txtFinal.Text);

            ortalama = vize * 0.4 + final * 0.6;

            lblOrtalama.Text = "Ortalama: " + ortalama;



        }
    }
}
