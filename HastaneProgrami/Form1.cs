namespace HastaneProgrami
{
    public partial class Form1 : Form
    {
        private Form form2;
        private Form form3;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            form3 = new Form3(this, hastalar, randevular);
        }

        List<Hasta> hastalar = new List<Hasta>();
        List<Randevu> randevular = new List<Randevu>();

        private void randevuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3.Hide();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(0, 0);
            this.Size = form2.ClientSize;
            form2.Show();
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Hide();
            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = new Point(0, 0);
            this.Size = form3.ClientSize;
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2.MdiParent = this;
            form3.MdiParent = this;
        }

        public void VeriEkle(List<Hasta> hastalar, List<Randevu> randevular)
        {
            foreach (var item in hastalar)
            {
                hastalar.Add(item);
            }
            foreach (var item in randevular)
            {
                randevular.Add(item);
            }
        }
    }
}