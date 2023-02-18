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

        public void Temizle()
        {
            TxtBaslik.Text = "";
            TxtProje.Text = "";
            CmbDurum.Text = "";
            CmbIsTipi.Text = "";
            CmbSorumlu.Text = "";
            RchAciklama.Text = "";
        }

        private void BtnTanımla_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Isler (Durum, IsTipi,Baslik,Aciklama,Proje,SorumluKullanici,OlusturmaTarihi,GuncellemeTarihi,TeslimTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            //@p = parametrenin p harfi kullanılıyor, isteğe göre farklı değer ataması yapılabilir.
            komut.Parameters.AddWithValue("@p1", CmbDurum.Text);
            komut.Parameters.AddWithValue("@p2", CmbIsTipi.Text);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", RchAciklama.Text);
            komut.Parameters.AddWithValue("@p5", TxtProje.Text);
            komut.Parameters.AddWithValue("@p6", CmbSorumlu.Text);
            komut.Parameters.AddWithValue("@p7", DtpOlusturmaTarih.MinDate);
            komut.Parameters.AddWithValue("@p8", DtpGuncellemeTarih.MinDate);
            komut.Parameters.AddWithValue("@p9", DtpTeslimTarih.MinDate);

            komut.ExecuteNonQuery();
            //Executenonquery = sorguyu çalıştır.

            bgl.baglanti().Close();
            //Bağlantı kapatılıyor.

            MessageBox.Show("Kayıt Eklendi!");
        }

        private void BtnIslemDon_Click(object sender, EventArgs e)
        {
            Frmİslem fr = new Frmİslem();
            fr.Show();
            this.Hide();
        }


        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
