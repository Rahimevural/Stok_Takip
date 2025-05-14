namespace C_StokTakip
{
    partial class frmkategori
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
            txtkategori = new TextBox();
            btnekle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(26, 68);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 0;
            label1.Text = "Kategori : ";
            // 
            // txtkategori
            // 
            txtkategori.Location = new Point(123, 60);
            txtkategori.Name = "txtkategori";
            txtkategori.Size = new Size(250, 27);
            txtkategori.TabIndex = 1;
            // 
            // btnekle
            // 
            btnekle.Location = new Point(141, 140);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(127, 37);
            btnekle.TabIndex = 2;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // frmkategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 287);
            Controls.Add(btnekle);
            Controls.Add(txtkategori);
            Controls.Add(label1);
            Name = "frmkategori";
            Text = "frmkategori";
            Load += frmkategori_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtkategori;
        private Button btnekle;
    }
}