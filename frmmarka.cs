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
    public partial class frmmarka : Form
    {
        public frmmarka()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        bool durum;
        private void markakontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("select * from markabilgileri ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (cmbkategori.Text==dr["kategori"].ToString()&&txtmarka.Text == dr["marka"].ToString() || txtmarka.Text == "" || cmbkategori.Text=="")
                {
                    durum = false;
                    MessageBox.Show("Bu Kategori Zaten Var...");
                }
                bgl.baglanti().Close();
            }
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('" + cmbkategori.Text + "','" + txtmarka.Text + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();


                MessageBox.Show("Marka Eklendi...");
            }
            else
            {
                MessageBox.Show("Bu Kategori ve Marka Zaten Var...");
            }
            cmbkategori.Text = "";
            txtmarka.Text = "";

        }

        private void frmmarka_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }
      
        private void KategoriGetir()
        {
            SqlCommand komut = new SqlCommand("select kategori from kategoribilgileri", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbkategori.Items.Add(dr["kategori"].ToString());
            }
            bgl.baglanti().Close();
        }
    }
}
