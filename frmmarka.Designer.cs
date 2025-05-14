namespace C_StokTakip
{
    partial class frmmarka
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
            txtmarka = new TextBox();
            cmbkategori = new ComboBox();
            btnekle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(29, 48);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 0;
            label1.Text = "Kategori : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(45, 107);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Marka : ";
            // 
            // txtmarka
            // 
            txtmarka.Location = new Point(136, 103);
            txtmarka.Name = "txtmarka";
            txtmarka.Size = new Size(217, 27);
            txtmarka.TabIndex = 2;
            // 
            // cmbkategori
            // 
            cmbkategori.FormattingEnabled = true;
            cmbkategori.Location = new Point(136, 43);
            cmbkategori.Name = "cmbkategori";
            cmbkategori.Size = new Size(217, 28);
            cmbkategori.TabIndex = 3;
            // 
            // btnekle
            // 
            btnekle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnekle.Location = new Point(148, 170);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(123, 32);
            btnekle.TabIndex = 4;
            btnekle.Text = "EKLE ";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // frmmarka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 295);
            Controls.Add(btnekle);
            Controls.Add(cmbkategori);
            Controls.Add(txtmarka);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmmarka";
            Text = "frmmarka";
            Load += frmmarka_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtmarka;
        private ComboBox cmbkategori;
        private Button btnekle;
    }
}