using Microsoft.Data.SqlClient;
using System.Data;

namespace C_StokTakip
{
    public partial class frmsatis : Form
    {
        public frmsatis()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        DataSet ds = new DataSet();
        private void sepetlistele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", bgl.baglanti());
            adtr.Fill(ds, "sepet");
            dataGridView1.DataSource = ds.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            bgl.baglanti().Close();


        }
        private void hesapla()
        {
            try
            {
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet", bgl.baglanti());
                lblgeneltoplam.Text = komut.ExecuteScalar() + " TL";
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                ;
            }

        }

        private void btnsatislistele_Click(object sender, EventArgs e)
        {
            frmsatislistele sl = new frmsatislistele();
            sl.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            frmmusteriekle me = new frmmusteriekle();
            me.ShowDialog();
        }

        private void btnmusterilistele_Click(object sender, EventArgs e)
        {
            frmmusterilistele ml = new frmmusterilistele();
            ml.ShowDialog();
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            frmurunekle ue = new frmurunekle();
            ue.ShowDialog();
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            frmkategori kategori = new frmkategori();
            kategori.ShowDialog();
        }

        private void btnmarka_Click(object sender, EventArgs e)
        {
            frmmarka marka = new frmmarka();
            marka.ShowDialog();
        }

        private void btnurunlistele_Click(object sender, EventArgs e)
        {
            frmurunlistele ul = new frmurunlistele();
            ul.ShowDialog();
        }

        private void frmsatis_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (msktc.Text == "")
            {
                txtadsoyad.Text = "";
                msktelefon.Text = "";
            }

            SqlCommand komut = new SqlCommand("select * from musteri where tc like '" + msktc.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtadsoyad.Text = dr["adsoyad"].ToString();
                msktelefon.Text = dr["telefon"].ToString();

            }

            bgl.baglanti().Close();


        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + txtbarkodno.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txturunadi.Text = dr["urunadi"].ToString();
                txtsatisfiyati.Text = dr["satisfiyati"].ToString();

            }
            bgl.baglanti().Close();
        }

        private void Temizle()
        {
            if (txtbarkodno.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtmiktar)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("select * from sepet", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (txtbarkodno.Text == dr["barkodno"].ToString())
                {
                    durum = false;

                }
                bgl.baglanti().Close();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO sepet (tc, adsoyad, telefon, barkodno, urunadi, miktar, satisfiyati, toplamfiyati, tarih) VALUES (@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktar, @satisfiyati, @toplamfiyati, @tarih)", bgl.baglanti());
                komut.Parameters.AddWithValue("@tc", msktc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", msktelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@urunadi", txturunadi.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(txtmiktar.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsatisfiyati.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txttoplamfiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            else
            {
                // miktar güncelleme
                SqlCommand komut2 = new SqlCommand("UPDATE sepet SET miktar = miktar + @miktar WHERE barkodno = @barkodno", bgl.baglanti());
                komut2.Parameters.AddWithValue("@miktar", int.Parse(txtmiktar.Text));
                komut2.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                komut2.ExecuteNonQuery();

                // toplamfiyati güncelleme
                SqlCommand komut3 = new SqlCommand("UPDATE sepet SET toplamfiyati = miktar * satisfiyati WHERE barkodno = @barkodno", bgl.baglanti());
                komut3.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                komut3.ExecuteNonQuery();

                bgl.baglanti().Close();
            }


            // Alan temizleme ve liste yenileme
            txtmiktar.Text = "1";
            ds.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox && item != txtmiktar)
                {
                    item.Text = "";
                }
            }
        }


        private void txtmiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtsatisfiyati.Text) * double.Parse(txtmiktar.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }

        }

        private void txtsatisfiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtsatisfiyati.Text) * double.Parse(txtmiktar.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Silme Ýþlemi Gerçekleþti...");
            ds.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnsatisiptal_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from sepet ", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Satýþ Ýptali Gerçekleþti...");
            ds.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <dataGridView1.Rows.Count-1; i++)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO satis (tc, adsoyad, telefon, barkodno, urunadi, miktar, satisfiyati, toplamfiyati, tarih) VALUES (@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktar, @satisfiyati, @toplamfiyati, @tarih)", bgl.baglanti());
                komut.Parameters.AddWithValue("@tc", msktc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", msktelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktar", int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                SqlCommand komut2 = new SqlCommand("update urun set miktar=miktar-'" + int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", bgl.baglanti());
               
                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

              
                
            }

            SqlCommand komut3 = new SqlCommand("delete from sepet ", bgl.baglanti());
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();

            ds.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }
    }
}
