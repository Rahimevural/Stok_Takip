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
    public partial class frmurunekle : Form
    {
        public frmurunekle()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("select * from urun ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (txtbarkodno.Text == dr["barkodno"].ToString() || txtbarkodno.Text=="")
                {
                    durum = false;
                   /* MessageBox.Show("Bu Kategori Zaten Var...");*/
                }
                bgl.baglanti().Close();
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
        private void frmurunekle_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmarka.Items.Clear();
            cmbmarka.Text = "";
            SqlCommand komut = new SqlCommand("select kategori,marka from markabilgileri where kategori='" + cmbkategori.SelectedItem + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbmarka.Items.Add(dr["marka"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if(durum== true)
            {
                SqlCommand komut = new SqlCommand("insert into urun (barkodno,kategori,marka,urunadi,miktar,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktar,@alisfiyati,@satisfiyati,@tarih)", bgl.baglanti());
                komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@kategori", cmbkategori.Text);
                komut.Parameters.AddWithValue("@marka", cmbmarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txturunadi.Text);
                komut.Parameters.AddWithValue("@miktar", txturunmiktari.Text);
                komut.Parameters.AddWithValue("@alisfiyati", txtalisfiyati.Text);
                komut.Parameters.AddWithValue("@satisfiyati", txtsatisfiyati.Text);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün Eklendi...");

            }
            else
            {
                MessageBox.Show("Bu Barkod No Zaten Var...");
            }


                cmbmarka.Items.Clear();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }



        }

        private void txtbarkodnovar_TextChanged(object sender, EventArgs e)
        {
            if (txtbarkodnovar.Text == "")
            {
                lblmiktari.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }

                }

            }
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + txtbarkodnovar.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtkategorivar.Text = dr["kategori"].ToString();
                txtmarkavar.Text = dr["marka"].ToString();
                txturunadivar.Text = dr["urunadi"].ToString();
                lblmiktari.Text = dr["miktar"].ToString();
                txtalisfiyativar.Text = dr["alisfiyati"].ToString();
                txtsatisfiyativar.Text = dr["satisfiyati"].ToString();
                bgl.baglanti().Close();
            }
        }

        private void btnvarolanaekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update urun set miktar=miktar+'"+txtmiktarvar.Text+"' where barkodno='"+txtbarkodnovar.Text+"'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı...");
        }
    }
}
