using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace C_StokTakip
{
    public partial class frmmusteriekle : Form
    {
        public frmmusteriekle()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into musteri (tc,adsoyad,telefon,adres,email) values (@tc,@adsoyad,@telefon,@adres,@email)",bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", msktc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", msktelefon.Text);
            komut.Parameters.AddWithValue("@adres", richtextboxadres.Text);
            komut.Parameters.AddWithValue("@email", txtmail.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Eklendi...");

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }
    }
}
