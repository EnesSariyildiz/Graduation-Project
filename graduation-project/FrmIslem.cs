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
    public partial class Frmİslem : Form
    {
        public Frmİslem()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Isler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIsTanımla fr = new FrmIsTanımla();
            fr.Show();
            this.Hide();
        }

        private void BtnFiltreleme_Click(object sender, EventArgs e)
        {
            FrmIsFiltreleme fr = new FrmIsFiltreleme();
            fr.Show();
            this.Hide();
        }

        private void BtnSilme_Click(object sender, EventArgs e)
        {
            FrmSilme fr = new FrmSilme();
            fr.Show();
            this.Hide();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Isler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            MessageBox.Show("Kayıt listeleri güncellendi!");
            // Ekranda kayıt listelerinin güncellendiğine dair bilgi veriliyor.
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // Uygulamadan çıkış yapılıyor.
        }
    }
}
