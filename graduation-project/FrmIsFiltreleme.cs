using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace graduation_project
{
    public partial class FrmIsFiltreleme : Form
    {
        public FrmIsFiltreleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmİslem fr = new Frmİslem();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutFiltrele = new SqlCommand("SELECT * FROM Tbl_Isler WHERE Durum = @durum and IsTipi=@isTipi and Baslik=@baslik and Proje=@proje and SorumluKullanici=@sorumluKullanici and OlusturmaTarihi=@olusturmaTarihi and GuncellemeTarihi=@guncellemeTarihi and TeslimTarihi=@teslimTarihi ", bgl.baglanti());
            komutFiltrele.Parameters.AddWithValue("@durum", CmbDurum.SelectedItem.ToString());
            komutFiltrele.Parameters.AddWithValue("@isTipi", CmbIsTipi.SelectedItem.ToString());
            komutFiltrele.Parameters.AddWithValue("@baslik",TxtBaslik.Text.ToString());
            komutFiltrele.Parameters.AddWithValue("@proje", TxtProje.Text.ToString());
            komutFiltrele.Parameters.AddWithValue("@sorumluKullanici", CmbSorumlu.Text.ToString());
            komutFiltrele.Parameters.AddWithValue("olusturmaTarihi",DtpOlusturmaTarih.Value);
            komutFiltrele.Parameters.AddWithValue("guncellemeTarihi",DtpGuncellemeTarih.Value);
            komutFiltrele.Parameters.AddWithValue("teslimTarihi",DtpTeslimTarih.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(komutFiltrele);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void FrmIsFiltreleme_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Isler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnListeyiGuncelle_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Isler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
