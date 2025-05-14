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
    public partial class frmkategori : Form
    {
        public frmkategori()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        bool durum;
        private void kategorikontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (txtkategori.Text == dr["kategori"].ToString() || txtkategori.Text == "")
                {
                    durum = false;
                    MessageBox.Show("Bu Kategori Zaten Var...");
                }
                bgl.baglanti().Close();
            }
        }
        private void frmkategori_Load(object sender, EventArgs e)
        {

        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + txtkategori.Text + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kategori Eklendi...");

            }
            else { 
                MessageBox.Show("Bu Kategori Zaten Var...");

            }
            txtkategori.Text = "";
            


        }

      
    }
}
