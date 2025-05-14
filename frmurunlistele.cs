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
    public partial class frmurunlistele : Form
    {
        public frmurunlistele()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        DataSet ds = new DataSet();
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
        private void frmurunlistele_Load(object sender, EventArgs e)
        {
            urunlistele();
            KategoriGetir();
        }

        private void urunlistele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun", bgl.baglanti());
            adtr.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbarkodnovar.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            txtkategorivar.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txtmarkavar.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txturunadivar.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txtmiktarvar.Text = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            txtalisfiyativar.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            txtsatisfiyativar.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi,miktar=@miktar,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", bgl.baglanti());
            komut.Parameters.AddWithValue("@barkodno", txtbarkodnovar.Text);
            komut.Parameters.AddWithValue("@urunadi", txturunadivar.Text);
            komut.Parameters.AddWithValue("@miktar", int.Parse(txtmiktarvar.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtalisfiyativar.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsatisfiyativar.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            ds.Tables["urun"].Clear();
            urunlistele();
            MessageBox.Show("Güncelleme Yapıldı...");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnmarkaguncelle_Click(object sender, EventArgs e)
        {
            if (txtbarkodnovar.Text != "")
            {
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", bgl.baglanti());
                komut.Parameters.AddWithValue("@barkodno", txtbarkodnovar.Text);
                komut.Parameters.AddWithValue("@kategori", cmbkategori.Text);
                komut.Parameters.AddWithValue("@marka", cmbmarka.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                ds.Tables["urun"].Clear();
                urunlistele();
                MessageBox.Show("Güncelleme Yapıldı...");
            }
            else
            {
                MessageBox.Show("Lütfen Barkod Numarasını Seçiniz...");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
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

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            ds.Tables["urun"].Clear();
            urunlistele();
            MessageBox.Show("Kayıt Silindi...");
        }

        private void txtbarkodnoara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun where barkodno like '%" + txtbarkodnoara.Text + "%'", bgl.baglanti());
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bgl.baglanti().Close();
        }
    }
}
