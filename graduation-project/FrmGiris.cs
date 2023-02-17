using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graduation_project
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Frmİslem fr = new Frmİslem();
            //Proje sonunda bu if bloğu açılacak.
            //if (TxtId.Text == "admin" &&  TxtPassword.Text=="1234")
            //{
                
            //    fr.Show();
            //    this.Hide();
            //}
            fr.Show();
            this.Hide();
        }
    }
}
