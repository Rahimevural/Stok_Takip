﻿namespace C_StokTakip
{
    partial class frmadmin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtkullaniciadi = new TextBox();
            txtsifre = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(100, 40);
            label1.Name = "label1";
            label1.Size = new Size(241, 26);
            label1.TabIndex = 0;
            label1.Text = "STOK TAKİP SİSTEMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(148, 19);
            label2.TabIndex = 1;
            label2.Text = "KULLANICI ADI : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.Location = new Point(88, 182);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 2;
            label3.Text = "ŞİFRE : ";
            // 
            // txtkullaniciadi
            // 
            txtkullaniciadi.Location = new Point(166, 107);
            txtkullaniciadi.Name = "txtkullaniciadi";
            txtkullaniciadi.Size = new Size(205, 27);
            txtkullaniciadi.TabIndex = 3;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(166, 174);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(205, 27);
            txtsifre.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(242, 248);
            button1.Name = "button1";
            button1.Size = new Size(129, 42);
            button1.TabIndex = 5;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 348);
            Controls.Add(button1);
            Controls.Add(txtsifre);
            Controls.Add(txtkullaniciadi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmadmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmadmin";
            Load += frmadmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtkullaniciadi;
        private TextBox txtsifre;
        private Button button1;
    }
}