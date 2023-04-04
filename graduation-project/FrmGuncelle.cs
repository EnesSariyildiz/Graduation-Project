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
using System.Runtime.InteropServices;

namespace graduation_project
{
    public partial class FrmGuncelle : Form
    {
        public FrmGuncelle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        // Sql bağlantısını yapıyoruz.
        private void FrmDuzenle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Isler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Isler Set Durum=@a1, IsTipi=@a2, Baslik=@a3, Aciklama=@a4,Proje=@a5,SorumluKullanici=@a6,OlusturmaTarihi=@a7, GuncellemeTarihi=@a8,TeslimTarihi=@a9 Where Id=@a10",bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@a1",CmbDurum.Text);
            komutGuncelle.Parameters.AddWithValue("@a2", CmbIsTipi.Text);
            komutGuncelle.Parameters.AddWithValue("@a3", TxtBaslik.Text);
            komutGuncelle.Parameters.AddWithValue("@a4", RchAciklama.Text);
            komutGuncelle.Parameters.AddWithValue("@a5", TxtProje.Text);
            komutGuncelle.Parameters.AddWithValue("@a6", CmbSorumlu.Text);
            komutGuncelle.Parameters.AddWithValue("@a7", DtpOlusturmaTarih.Value);
            komutGuncelle.Parameters.AddWithValue("@a8", DtpGuncellemeTarih.Value);
            komutGuncelle.Parameters.AddWithValue("@a9", DtpTeslimTarih.Value);
            komutGuncelle.Parameters.AddWithValue("@a10",TxtId.Text);

            komutGuncelle.ExecuteNonQuery();



            // Kayıt silindikten sonra tabloyu güncelle
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Isler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            MessageBox.Show("Kayıt Güncellendi");
            // Seçilen kayıdın güncellendiğine dair bilgi veriyor.



        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenDeger = dataGridView1.SelectedCells[0].RowIndex;

            TxtId.Text = dataGridView1.Rows[secilenDeger].Cells[0].Value.ToString();       
            CmbDurum.Text = dataGridView1.Rows[secilenDeger].Cells[1].Value.ToString();
            CmbIsTipi.Text = dataGridView1.Rows[secilenDeger].Cells[2].Value.ToString();
            TxtBaslik.Text = dataGridView1.Rows[secilenDeger].Cells[3].Value.ToString();
            RchAciklama.Text = dataGridView1.Rows[secilenDeger].Cells[4].Value.ToString();
            TxtProje.Text = dataGridView1.Rows[secilenDeger].Cells[5].Value.ToString();
            CmbSorumlu.Text = dataGridView1.Rows[secilenDeger].Cells[6].Value.ToString();
            DtpOlusturmaTarih.Text = dataGridView1.Rows[secilenDeger].Cells[7].Value.ToString();
            DtpGuncellemeTarih.Text = dataGridView1.Rows[secilenDeger].Cells[7].Value.ToString();
            DtpTeslimTarih.Text = dataGridView1.Rows[secilenDeger].Cells[7].Value.ToString();


        }

        private void BtnIslemDon_Click(object sender, EventArgs e)
        {
            Frmİslem fr = new Frmİslem();
            fr.Show();
            this.Hide();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtBaslik.Text = "";
            TxtProje.Text = "";
            CmbDurum.Text = "";
            CmbIsTipi.Text = "";
            CmbSorumlu.Text = "";
            RchAciklama.Text = "";
            DtpOlusturmaTarih.Value = DateTime.Now;
            DtpGuncellemeTarih.Value = DateTime.Now;
            DtpTeslimTarih.Value = DateTime.Now;
        }
    }
}
