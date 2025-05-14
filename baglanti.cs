using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_StokTakip
{
    public class Sqlbaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-KQ3BHV1\SQLEXPRESS01;Initial Catalog=Stok_Takip;TrustServerCertificate=True;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
