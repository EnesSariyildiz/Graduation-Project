using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace graduation_project
{
    public partial class FrmIsTanımla : Form
    {
        public FrmIsTanımla()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnTanımla_Click(object sender, EventArgs e)
        {
            /*
             * 
             * örnek veri tabanı ekleme bloğu
            //Bağlantı açılıyor.
            SqlCommand komut = new SqlCommand("insert into Tbl_Islem (PerAd, PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            //@p = parametrenin p harfi kullanılıyor, isteğe göre farklı değer ataması yapılabilir.
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", MskMaas.Text);
            komut.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);


            komut.ExecuteNonQuery();
            //Executenonquery = sorguyu çalıştır.
            bgl.baglanti.Close();
            //Bağlantı kapatılıyor.
            MessageBox.Show("Personel Eklendi!");
            */
        }


        private void BtnIslemDon_Click(object sender, EventArgs e)
        {
            Frmİslem fr = new Frmİslem();
            fr.Show();
            this.Hide();
        }
    }
}
