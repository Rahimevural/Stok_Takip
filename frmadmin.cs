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
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();


        private void frmadmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabaný baðlantýsýný aç
                SqlCommand komut = new SqlCommand("select * from admin where kullaniciadi=@kullaniciadi and sifre=@sifre", bgl.baglanti());
                komut.Parameters.AddWithValue("@kullaniciadi", txtkullaniciadi.Text);
                komut.Parameters.AddWithValue("@sifre", txtsifre.Text);

                SqlDataReader oku = komut.ExecuteReader();

                // Kullanýcý doðrulamasý
                if (oku.Read())
                {
                    frmsatis satis = new frmsatis();
                    satis.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı ya da şifre !");
                    txtkullaniciadi.Clear();
                    txtsifre.Clear();
                    txtkullaniciadi.Focus();
                }

                oku.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                
                if (bgl.baglanti() != null && bgl.baglanti().State == System.Data.ConnectionState.Open)
                {
                    bgl.baglanti().Close();
                }
            }
        }
    }
}
