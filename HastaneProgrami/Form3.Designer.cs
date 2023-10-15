namespace HastaneProgrami
{
    partial class Form3
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
            lstRandevuBilgileri = new ListBox();
            SuspendLayout();
            // 
            // lstRandevuBilgileri
            // 
            lstRandevuBilgileri.FormattingEnabled = true;
            lstRandevuBilgileri.ItemHeight = 20;
            lstRandevuBilgileri.Location = new Point(12, 17);
            lstRandevuBilgileri.Name = "lstRandevuBilgileri";
            lstRandevuBilgileri.Size = new Size(609, 564);
            lstRandevuBilgileri.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 587);
            Controls.Add(lstRandevuBilgileri);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstRandevuBilgileri;
    }
}