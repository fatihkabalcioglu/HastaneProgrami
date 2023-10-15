namespace HastaneProgrami
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKaydet = new Button();
            groupBox2 = new GroupBox();
            radOnBes = new RadioButton();
            radOnDort = new RadioButton();
            radOnIki = new RadioButton();
            radOnUc = new RadioButton();
            dtpTarih = new DateTimePicker();
            cboxPoliklinik = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtAdSoyad = new TextBox();
            mtxtTelefon = new MaskedTextBox();
            mtxtTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            radErkek = new RadioButton();
            radKadin = new RadioButton();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(155, 830);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(231, 44);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radOnBes);
            groupBox2.Controls.Add(radOnDort);
            groupBox2.Controls.Add(radOnIki);
            groupBox2.Controls.Add(radOnUc);
            groupBox2.Controls.Add(dtpTarih);
            groupBox2.Controls.Add(cboxPoliklinik);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 394);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(517, 407);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Bilgileri";
            // 
            // radOnBes
            // 
            radOnBes.AutoSize = true;
            radOnBes.Location = new Point(266, 332);
            radOnBes.Margin = new Padding(3, 4, 3, 4);
            radOnBes.Name = "radOnBes";
            radOnBes.Size = new Size(65, 24);
            radOnBes.TabIndex = 0;
            radOnBes.TabStop = true;
            radOnBes.Text = "15:00";
            radOnBes.UseVisualStyleBackColor = true;
            // 
            // radOnDort
            // 
            radOnDort.AutoSize = true;
            radOnDort.Location = new Point(85, 332);
            radOnDort.Margin = new Padding(3, 4, 3, 4);
            radOnDort.Name = "radOnDort";
            radOnDort.Size = new Size(65, 24);
            radOnDort.TabIndex = 0;
            radOnDort.TabStop = true;
            radOnDort.Text = "14:00";
            radOnDort.UseVisualStyleBackColor = true;
            // 
            // radOnIki
            // 
            radOnIki.AutoSize = true;
            radOnIki.Location = new Point(85, 253);
            radOnIki.Margin = new Padding(3, 4, 3, 4);
            radOnIki.Name = "radOnIki";
            radOnIki.Size = new Size(65, 24);
            radOnIki.TabIndex = 0;
            radOnIki.TabStop = true;
            radOnIki.Text = "12:00";
            radOnIki.UseVisualStyleBackColor = true;
            // 
            // radOnUc
            // 
            radOnUc.AutoSize = true;
            radOnUc.Location = new Point(266, 253);
            radOnUc.Margin = new Padding(3, 4, 3, 4);
            radOnUc.Name = "radOnUc";
            radOnUc.Size = new Size(65, 24);
            radOnUc.TabIndex = 0;
            radOnUc.TabStop = true;
            radOnUc.Text = "13:00";
            radOnUc.UseVisualStyleBackColor = true;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(168, 160);
            dtpTarih.Margin = new Padding(3, 4, 3, 4);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(205, 27);
            dtpTarih.TabIndex = 5;
            // 
            // cboxPoliklinik
            // 
            cboxPoliklinik.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxPoliklinik.FormattingEnabled = true;
            cboxPoliklinik.Items.AddRange(new object[] { "Acil", "Diş", "KGB", "Dahiliye" });
            cboxPoliklinik.Location = new Point(169, 88);
            cboxPoliklinik.Margin = new Padding(3, 4, 3, 4);
            cboxPoliklinik.Name = "cboxPoliklinik";
            cboxPoliklinik.Size = new Size(205, 28);
            cboxPoliklinik.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 93);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 3;
            label5.Text = "Poliklinik";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 169);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "Tarih";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(mtxtTelefon);
            groupBox1.Controls.Add(mtxtTC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(517, 373);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgileri";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(168, 108);
            txtAdSoyad.Margin = new Padding(3, 4, 3, 4);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(205, 27);
            txtAdSoyad.TabIndex = 5;
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(168, 163);
            mtxtTelefon.Margin = new Padding(3, 4, 3, 4);
            mtxtTelefon.Mask = "(999) 000-00-00";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(205, 27);
            mtxtTelefon.TabIndex = 4;
            // 
            // mtxtTC
            // 
            mtxtTC.Location = new Point(168, 56);
            mtxtTC.Margin = new Padding(3, 4, 3, 4);
            mtxtTC.Mask = "00000000000";
            mtxtTC.Name = "mtxtTC";
            mtxtTC.Size = new Size(205, 27);
            mtxtTC.TabIndex = 4;
            mtxtTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 168);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 113);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 61);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 3;
            label1.Text = "TC";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radErkek);
            groupBox3.Controls.Add(radKadin);
            groupBox3.Location = new Point(56, 211);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(378, 104);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cinsiyet";
            // 
            // radErkek
            // 
            radErkek.AutoSize = true;
            radErkek.Location = new Point(210, 56);
            radErkek.Margin = new Padding(3, 4, 3, 4);
            radErkek.Name = "radErkek";
            radErkek.Size = new Size(65, 24);
            radErkek.TabIndex = 0;
            radErkek.TabStop = true;
            radErkek.Text = "Erkek";
            radErkek.UseVisualStyleBackColor = true;
            // 
            // radKadin
            // 
            radKadin.AutoSize = true;
            radKadin.Location = new Point(71, 56);
            radKadin.Margin = new Padding(3, 4, 3, 4);
            radKadin.Name = "radKadin";
            radKadin.Size = new Size(68, 24);
            radKadin.TabIndex = 0;
            radKadin.TabStop = true;
            radKadin.Text = "Kadın";
            radKadin.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 880);
            Controls.Add(btnKaydet);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKaydet;
        private GroupBox groupBox2;
        private RadioButton radOnBes;
        private RadioButton radOnDort;
        private RadioButton radOnIki;
        private RadioButton radOnUc;
        private DateTimePicker dtpTarih;
        private ComboBox cboxPoliklinik;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtAdSoyad;
        private MaskedTextBox mtxtTelefon;
        private MaskedTextBox mtxtTC;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private RadioButton radErkek;
        private RadioButton radKadin;
    }
}