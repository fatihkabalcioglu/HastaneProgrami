﻿namespace HastaneProgrami
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            randevuOluşturToolStripMenuItem = new ToolStripMenuItem();
            randevularToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { randevuOluşturToolStripMenuItem, randevularToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(569, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // randevuOluşturToolStripMenuItem
            // 
            randevuOluşturToolStripMenuItem.Name = "randevuOluşturToolStripMenuItem";
            randevuOluşturToolStripMenuItem.Size = new Size(131, 24);
            randevuOluşturToolStripMenuItem.Text = "Randevu Oluştur";
            randevuOluşturToolStripMenuItem.Click += randevuOluşturToolStripMenuItem_Click;
            // 
            // randevularToolStripMenuItem
            // 
            randevularToolStripMenuItem.Name = "randevularToolStripMenuItem";
            randevularToolStripMenuItem.Size = new Size(97, 24);
            randevularToolStripMenuItem.Text = "Randevular";
            randevularToolStripMenuItem.Click += randevularToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 442);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Ana Menü";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem randevuOluşturToolStripMenuItem;
        private ToolStripMenuItem randevularToolStripMenuItem;
    }
}