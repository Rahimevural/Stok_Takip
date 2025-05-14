namespace C_StokTakip
{
    partial class frmsatis
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            msktc = new MaskedTextBox();
            msktelefon = new MaskedTextBox();
            txtadsoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txturunadi = new TextBox();
            txttoplamfiyat = new TextBox();
            txtsatisfiyati = new TextBox();
            txtmiktar = new TextBox();
            txtbarkodno = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnekle = new Button();
            btnsil = new Button();
            btnsatisiptal = new Button();
            btnsatisyap = new Button();
            label9 = new Label();
            lblgeneltoplam = new Label();
            panel1 = new Panel();
            btnmarka = new Button();
            btnkategori = new Button();
            btnsatislistele = new Button();
            btnurunlistele = new Button();
            btnurunekle = new Button();
            btnmusterilistele = new Button();
            btnmusteriekle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(449, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(703, 335);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(msktc);
            groupBox1.Controls.Add(msktelefon);
            groupBox1.Controls.Add(txtadsoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 219);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // msktc
            // 
            msktc.Location = new Point(117, 46);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(216, 27);
            msktc.TabIndex = 6;
            msktc.ValidatingType = typeof(int);
            msktc.MaskInputRejected += msktc_MaskInputRejected;
            // 
            // msktelefon
            // 
            msktelefon.Location = new Point(117, 141);
            msktelefon.Mask = "(999) 000-0000";
            msktelefon.Name = "msktelefon";
            msktelefon.Size = new Size(216, 27);
            msktelefon.TabIndex = 5;
            // 
            // txtadsoyad
            // 
            txtadsoyad.Location = new Point(117, 91);
            txtadsoyad.Name = "txtadsoyad";
            txtadsoyad.Size = new Size(216, 27);
            txtadsoyad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.Location = new Point(35, 149);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 2;
            label3.Text = "Telefon : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.Location = new Point(21, 99);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label1.Location = new Point(66, 47);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 0;
            label1.Text = "TC : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txturunadi);
            groupBox2.Controls.Add(txttoplamfiyat);
            groupBox2.Controls.Add(txtsatisfiyati);
            groupBox2.Controls.Add(txtmiktar);
            groupBox2.Controls.Add(txtbarkodno);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 364);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 308);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // txturunadi
            // 
            txturunadi.Location = new Point(145, 87);
            txturunadi.Name = "txturunadi";
            txturunadi.Size = new Size(188, 27);
            txturunadi.TabIndex = 10;
            // 
            // txttoplamfiyat
            // 
            txttoplamfiyat.Location = new Point(145, 228);
            txttoplamfiyat.Name = "txttoplamfiyat";
            txttoplamfiyat.Size = new Size(188, 27);
            txttoplamfiyat.TabIndex = 9;
            // 
            // txtsatisfiyati
            // 
            txtsatisfiyati.Location = new Point(145, 178);
            txtsatisfiyati.Name = "txtsatisfiyati";
            txtsatisfiyati.Size = new Size(188, 27);
            txtsatisfiyati.TabIndex = 8;
            txtsatisfiyati.TextChanged += txtsatisfiyati_TextChanged;
            // 
            // txtmiktar
            // 
            txtmiktar.Location = new Point(145, 133);
            txtmiktar.Name = "txtmiktar";
            txtmiktar.Size = new Size(188, 27);
            txtmiktar.TabIndex = 7;
            txtmiktar.Text = "1";
            txtmiktar.TextAlign = HorizontalAlignment.Center;
            txtmiktar.TextChanged += txtmiktar_TextChanged;
            // 
            // txtbarkodno
            // 
            txtbarkodno.Location = new Point(145, 33);
            txtbarkodno.Name = "txtbarkodno";
            txtbarkodno.Size = new Size(188, 27);
            txtbarkodno.TabIndex = 5;
            txtbarkodno.TextChanged += txtbarkodno_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label8.Location = new Point(14, 236);
            label8.Name = "label8";
            label8.Size = new Size(120, 19);
            label8.TabIndex = 4;
            label8.Text = "Toplam Fiyat : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label7.Location = new Point(26, 186);
            label7.Name = "label7";
            label7.Size = new Size(108, 19);
            label7.TabIndex = 3;
            label7.Text = "Satış Fiyatı : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label6.Location = new Point(58, 141);
            label6.Name = "label6";
            label6.Size = new Size(76, 19);
            label6.TabIndex = 2;
            label6.Text = "Miktar : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label5.Location = new Point(44, 91);
            label5.Name = "label5";
            label5.Size = new Size(90, 19);
            label5.TabIndex = 1;
            label5.Text = "Ürün Adı : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label4.Location = new Point(35, 41);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 0;
            label4.Text = "Barkod No :";
            // 
            // btnekle
            // 
            btnekle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnekle.Location = new Point(449, 493);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(112, 29);
            btnekle.TabIndex = 3;
            btnekle.Text = "Ekle";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // btnsil
            // 
            btnsil.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnsil.Location = new Point(1187, 120);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(94, 29);
            btnsil.TabIndex = 4;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // btnsatisiptal
            // 
            btnsatisiptal.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnsatisiptal.Location = new Point(1187, 188);
            btnsatisiptal.Name = "btnsatisiptal";
            btnsatisiptal.Size = new Size(129, 46);
            btnsatisiptal.TabIndex = 5;
            btnsatisiptal.Text = "Satış İptal";
            btnsatisiptal.UseVisualStyleBackColor = true;
            btnsatisiptal.Click += btnsatisiptal_Click;
            // 
            // btnsatisyap
            // 
            btnsatisyap.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnsatisyap.Location = new Point(1029, 486);
            btnsatisyap.Name = "btnsatisyap";
            btnsatisyap.Size = new Size(123, 36);
            btnsatisyap.TabIndex = 6;
            btnsatisyap.Text = "Satış Yap";
            btnsatisyap.UseVisualStyleBackColor = true;
            btnsatisyap.Click += btnsatisyap_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(676, 493);
            label9.Name = "label9";
            label9.Size = new Size(127, 23);
            label9.TabIndex = 7;
            label9.Text = "Genel Toplam";
            // 
            // lblgeneltoplam
            // 
            lblgeneltoplam.AutoSize = true;
            lblgeneltoplam.Location = new Point(842, 498);
            lblgeneltoplam.Name = "lblgeneltoplam";
            lblgeneltoplam.Size = new Size(0, 20);
            lblgeneltoplam.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnmarka);
            panel1.Controls.Add(btnkategori);
            panel1.Controls.Add(btnsatislistele);
            panel1.Controls.Add(btnurunlistele);
            panel1.Controls.Add(btnurunekle);
            panel1.Controls.Add(btnmusterilistele);
            panel1.Controls.Add(btnmusteriekle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1415, 97);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // btnmarka
            // 
            btnmarka.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnmarka.Location = new Point(1187, 28);
            btnmarka.Name = "btnmarka";
            btnmarka.Size = new Size(145, 40);
            btnmarka.TabIndex = 6;
            btnmarka.Text = "Marka";
            btnmarka.UseVisualStyleBackColor = true;
            btnmarka.Click += btnmarka_Click;
            // 
            // btnkategori
            // 
            btnkategori.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnkategori.Location = new Point(992, 28);
            btnkategori.Name = "btnkategori";
            btnkategori.Size = new Size(160, 40);
            btnkategori.TabIndex = 5;
            btnkategori.Text = "Kategori";
            btnkategori.UseVisualStyleBackColor = true;
            btnkategori.Click += btnkategori_Click;
            // 
            // btnsatislistele
            // 
            btnsatislistele.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnsatislistele.Location = new Point(781, 28);
            btnsatislistele.Name = "btnsatislistele";
            btnsatislistele.Size = new Size(174, 40);
            btnsatislistele.TabIndex = 4;
            btnsatislistele.Text = "Satışları Listele";
            btnsatislistele.UseVisualStyleBackColor = true;
            btnsatislistele.Click += btnsatislistele_Click;
            // 
            // btnurunlistele
            // 
            btnurunlistele.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnurunlistele.Location = new Point(567, 28);
            btnurunlistele.Name = "btnurunlistele";
            btnurunlistele.Size = new Size(190, 40);
            btnurunlistele.TabIndex = 3;
            btnurunlistele.Text = "Ürün Listeleme";
            btnurunlistele.UseVisualStyleBackColor = true;
            btnurunlistele.Click += btnurunlistele_Click;
            // 
            // btnurunekle
            // 
            btnurunekle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnurunekle.Location = new Point(389, 28);
            btnurunekle.Name = "btnurunekle";
            btnurunekle.Size = new Size(172, 40);
            btnurunekle.TabIndex = 2;
            btnurunekle.Text = "Ürün Ekleme ";
            btnurunekle.UseVisualStyleBackColor = true;
            btnurunekle.Click += btnurunekle_Click;
            // 
            // btnmusterilistele
            // 
            btnmusterilistele.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnmusterilistele.Location = new Point(181, 28);
            btnmusterilistele.Name = "btnmusterilistele";
            btnmusterilistele.Size = new Size(188, 40);
            btnmusterilistele.TabIndex = 1;
            btnmusterilistele.Text = "Müşteri Listeleme";
            btnmusterilistele.UseVisualStyleBackColor = true;
            btnmusterilistele.Click += btnmusterilistele_Click;
            // 
            // btnmusteriekle
            // 
            btnmusteriekle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnmusteriekle.Location = new Point(3, 28);
            btnmusteriekle.Name = "btnmusteriekle";
            btnmusteriekle.Size = new Size(163, 40);
            btnmusteriekle.TabIndex = 0;
            btnmusteriekle.Text = "Müşteri Ekleme ";
            btnmusteriekle.UseVisualStyleBackColor = true;
            btnmusteriekle.Click += btnmusteriekle_Click;
            // 
            // frmsatis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 754);
            Controls.Add(panel1);
            Controls.Add(lblgeneltoplam);
            Controls.Add(label9);
            Controls.Add(btnsatisyap);
            Controls.Add(btnsatisiptal);
            Controls.Add(btnsil);
            Controls.Add(btnekle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "frmsatis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Sayfası";
            Load += frmsatis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txttelefon;
        private TextBox txtadsoyad;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txttoplamfiyat;
        private TextBox txtsatisfiyati;
        private TextBox txtmiktar;
        private TextBox textBox5;
        private TextBox txtbarkodno;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private MaskedTextBox msktelefon;
        private MaskedTextBox msktc;
        private Button btnekle;
        private Button btnsil;
        private Button btnsatisiptal;
        private Button btnsatisyap;
        private TextBox txturunadi;
        private Label label9;
        private Label lblgeneltoplam;
        private Panel panel1;
        private Button btnsatislistele;
        private Button btnurunlistele;
        private Button btnurunekle;
        private Button btnmusterilistele;
        private Button btnmusteriekle;
        private Button btnkategori;
        private Button btnmarka;
    }
}
