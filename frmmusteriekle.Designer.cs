﻿namespace C_StokTakip
{
    partial class frmmusteriekle
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
            label4 = new Label();
            label5 = new Label();
            msktelefon = new MaskedTextBox();
            txtadsoyad = new TextBox();
            txtmail = new TextBox();
            richtextboxadres = new RichTextBox();
            msktc = new MaskedTextBox();
            btnekle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label1.Location = new Point(64, 49);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 0;
            label1.Text = "TC : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.Location = new Point(19, 108);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.Location = new Point(33, 166);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 2;
            label3.Text = "Telefon : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label4.Location = new Point(43, 230);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 3;
            label4.Text = "Adres : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label5.Location = new Point(35, 359);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 4;
            label5.Text = "E-mail : ";
            // 
            // msktelefon
            // 
            msktelefon.Location = new Point(126, 158);
            msktelefon.Mask = "(999) 000-0000";
            msktelefon.Name = "msktelefon";
            msktelefon.Size = new Size(220, 27);
            msktelefon.TabIndex = 5;
            // 
            // txtadsoyad
            // 
            txtadsoyad.Location = new Point(123, 100);
            txtadsoyad.Name = "txtadsoyad";
            txtadsoyad.Size = new Size(220, 27);
            txtadsoyad.TabIndex = 7;
            // 
            // txtmail
            // 
            txtmail.Location = new Point(123, 351);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(223, 27);
            txtmail.TabIndex = 8;
            // 
            // richtextboxadres
            // 
            richtextboxadres.Location = new Point(123, 226);
            richtextboxadres.Name = "richtextboxadres";
            richtextboxadres.Size = new Size(223, 91);
            richtextboxadres.TabIndex = 9;
            richtextboxadres.Text = "";
            // 
            // msktc
            // 
            msktc.Location = new Point(123, 41);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(220, 27);
            msktc.TabIndex = 10;
            msktc.ValidatingType = typeof(int);
            // 
            // btnekle
            // 
            btnekle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnekle.Location = new Point(126, 425);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(141, 33);
            btnekle.TabIndex = 11;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // frmmusteriekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 531);
            Controls.Add(btnekle);
            Controls.Add(msktc);
            Controls.Add(richtextboxadres);
            Controls.Add(txtmail);
            Controls.Add(txtadsoyad);
            Controls.Add(msktelefon);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmmusteriekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekleme Sayfası ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox msktelefon;
        private TextBox txtadsoyad;
        private TextBox txtmail;
        private RichTextBox richtextboxadres;
        private MaskedTextBox msktc;
        private Button btnekle;
    }
}