namespace C_StokTakip
{
    partial class frmmusterilistele
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
            btnguncelle = new Button();
            msktc = new MaskedTextBox();
            richtextboxadres = new RichTextBox();
            txtmail = new TextBox();
            txtadsoyad = new TextBox();
            msktelefon = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            txttcara = new TextBox();
            btnsil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnguncelle
            // 
            btnguncelle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnguncelle.Location = new Point(110, 526);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(141, 33);
            btnguncelle.TabIndex = 22;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // msktc
            // 
            msktc.Location = new Point(110, 156);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(220, 27);
            msktc.TabIndex = 21;
            msktc.ValidatingType = typeof(int);
            // 
            // richtextboxadres
            // 
            richtextboxadres.Location = new Point(110, 341);
            richtextboxadres.Name = "richtextboxadres";
            richtextboxadres.Size = new Size(223, 91);
            richtextboxadres.TabIndex = 20;
            richtextboxadres.Text = "";
            // 
            // txtmail
            // 
            txtmail.Location = new Point(110, 466);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(223, 27);
            txtmail.TabIndex = 19;
            // 
            // txtadsoyad
            // 
            txtadsoyad.Location = new Point(110, 215);
            txtadsoyad.Name = "txtadsoyad";
            txtadsoyad.Size = new Size(220, 27);
            txtadsoyad.TabIndex = 18;
            // 
            // msktelefon
            // 
            msktelefon.Location = new Point(113, 273);
            msktelefon.Mask = "(999) 000-0000";
            msktelefon.Name = "msktelefon";
            msktelefon.Size = new Size(220, 27);
            msktelefon.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label5.Location = new Point(22, 474);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 16;
            label5.Text = "E-mail : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label4.Location = new Point(30, 345);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 15;
            label4.Text = "Adres : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.Location = new Point(20, 281);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 14;
            label3.Text = "Telefon : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.Location = new Point(6, 223);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 13;
            label2.Text = "Ad Soyad : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label1.Location = new Point(51, 164);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 12;
            label1.Text = "TC : ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(835, 337);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(375, 51);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 24;
            label6.Text = "TC ARA : ";
            // 
            // txttcara
            // 
            txttcara.Location = new Point(476, 44);
            txttcara.Name = "txttcara";
            txttcara.Size = new Size(233, 27);
            txttcara.TabIndex = 25;
            txttcara.TextChanged += txttcara_TextChanged;
            // 
            // btnsil
            // 
            btnsil.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnsil.Location = new Point(1247, 154);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(94, 29);
            btnsil.TabIndex = 26;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // frmmusterilistele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 642);
            Controls.Add(btnsil);
            Controls.Add(txttcara);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(btnguncelle);
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
            Name = "frmmusterilistele";
            Text = "frmmusterilistele";
            Load += frmmusterilistele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnguncelle;
        private MaskedTextBox msktc;
        private RichTextBox richtextboxadres;
        private TextBox txtmail;
        private TextBox txtadsoyad;
        private MaskedTextBox msktelefon;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox txttcara;
        private Button btnsil;
    }
}