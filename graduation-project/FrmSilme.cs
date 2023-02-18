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
    public partial class FrmSilme : Form
    {
        public FrmSilme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmSilme_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Isler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnKaydıSil_Click(object sender, EventArgs e)
        {
            //string queryDelete = "DELETE FROM Tbl_Isler WHERE Id = @ID";
            //SqlCommand commandDelete = new SqlCommand(queryDelete, bgl.baglanti());
            SqlCommand commandDelete = new SqlCommand("DELETE FROM Tbl_Isler WHERE Id = @ID", bgl.baglanti());
            commandDelete.Parameters.AddWithValue("@ID", TxtId.Text);
            commandDelete.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt silinidi!", "Uyarı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmİslem fr = new Frmİslem();
            fr.Show();
            this.Hide();
        }

        private void BtnListeGüncelle_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Isler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            MessageBox.Show("Kayıt listeleri güncellendi!");
        }
    }
}
