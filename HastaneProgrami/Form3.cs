using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProgrami
{
    public partial class Form3 : Form
    {
        private Form1 form1;
        List<Hasta> hastalar;
        List<Randevu> randevular;

        public Form3(Form1 form1, List<Hasta> hastalar, List<Randevu> randevular)
        {
            InitializeComponent();
            this.form1 = form1;
            this.hastalar = hastalar;
            this.randevular = randevular;
        }

        private void Listele()
        {
            lstRandevuBilgileri.Items.Clear();
            string info;
            for (int i = 0; i < hastalar.Count; i++)
            {
                info = $"{hastalar[i].AdSoyad} - {randevular[i].Poliklinik} - {randevular[i].Tarih} - {randevular[i].Saat}";
                lstRandevuBilgileri.Items.Add(info);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
