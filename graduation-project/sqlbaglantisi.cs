using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace graduation_project
{
    internal class sqlbaglantisi
        //sqlbaglantisi Sınıf adi
    {
        public SqlConnection baglanti()
            //baglanti metot adi
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-T54ECK5;Initial Catalog=GraduationProject;Integrated Security=True");
            //baglan adresi tutan nesnenin adi
            baglan.Open();
            return baglan;
        }
    }
}
