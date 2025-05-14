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
    public partial class frmsatislistele : Form
    {
        public frmsatislistele()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        DataSet ds = new DataSet();
        private void satislistele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", bgl.baglanti());
            adtr.Fill(ds, "satis");
            dataGridView1.DataSource = ds.Tables["satis"];
           
            bgl.baglanti().Close();


        }
        private void frmsatislistele_Load(object sender, EventArgs e)
        {
            satislistele();
        }
    }
}
