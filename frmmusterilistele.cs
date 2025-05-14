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
    public partial class frmmusterilistele : Form
    {
        public frmmusterilistele()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        DataSet ds = new DataSet();
        private void frmmusterilistele_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
        }
        private void Kayit_Goster()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select * from musteri", bgl.baglanti());
            adtr.Fill(ds, "musteri");
            dataGridView1.DataSource = ds.Tables["musteri"];
            bgl.baglanti().Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            msktc.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            msktelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            richtextboxadres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update musteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", msktc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", msktelefon.Text);
            komut.Parameters.AddWithValue("@adres", richtextboxadres.Text);
            komut.Parameters.AddWithValue("@email", txtmail.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            ds.Tables["musteri"].Clear();
            Kayit_Goster();

            MessageBox.Show("Kayıt Güncellendi...");

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from musteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            ds.Tables["musteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("Kayıt Silindi...");
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from musteri where tc like '%" + txttcara.Text + "%'", bgl.baglanti());
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bgl.baglanti().Close();


        }
    }
}
