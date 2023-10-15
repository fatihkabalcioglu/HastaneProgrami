using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProgrami
{
    public partial class Form2 : Form
    {
        List<Hasta> hastalar = new List<Hasta>();
        List<Randevu> randevular = new List<Randevu>();

        private Form form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public void btnKaydet_Click(object sender, EventArgs e)
        {
            string saat;
            Hasta hasta = new Hasta();
            Randevu randevu = new Randevu();

            hasta.AdSoyad = txtAdSoyad.Text;
            hasta.TC = mtxtTC.Text;
            hasta.Telefon = mtxtTelefon.Text;
            hasta.Cinsiyet = radKadin.Checked ? radKadin.Text : radKadin.Text;

            randevu.Poliklinik = cboxPoliklinik.SelectedItem.ToString();
            randevu.Tarih = dtpTarih.Value;

            if(radOnIki.Checked )
            {
                saat = radOnIki.Text;
            }
            else if(radOnUc.Checked )
            {
                saat = radOnUc.Text;
            }
            else if(radOnDort.Checked )
            {
                saat = radOnDort.Text;
            }
            else
            {
                saat = radOnBes.Text;
            }
            randevu.Saat = saat;

            hastalar.Add(hasta);
            randevular.Add(randevu);
            BilgileriTemizle();
            form1.VeriEkle(hastalar, randevular);
        }

        private void BilgileriTemizle()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Clear();
                }
                else if(control is MaskedTextBox)
                {
                    MaskedTextBox mtb = (MaskedTextBox)control;
                    mtb.Clear();
                }
                else if(control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.SelectedIndex = -1;
                }
                else if(control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e) { }
    }
}
