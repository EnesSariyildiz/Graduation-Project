using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

            LblGirisHakki.Visible = false;
            // Form yüklendiği zaman giriş hakkı sayısının ekranda gözükmesini istemediğim için
            // visible özelliğini false yapıyoruz. Daha sonra yanlış değer girişi yapıldığı zaman 
            // visible özelliğini true olarak değiştireceğiz.
        }
        string Id = "admin";
        // Id adını global olarak tanımlıyoruz.

        int Password = 1234;
        // Password'uda global olarak tanımlıyoruz.

        int loginCount = 3;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Frmİslem fr = new Frmİslem();
            // Giriş işlemi başarılı olursa açılacak olan formu tanımlıyoruz.

            if (TxtId.Text == "admin" && TxtPassword.Text == "1234")
            {
                fr.Show();
                this.Hide();
                //Eğer id ve password doğru girilmişse, sisteme giriş yapılıyor.
            }
            else if (TxtId.Text != "admin" && TxtPassword.Text != "1234")
            {
                loginCount--;
                // Eğer id ve password yanlış girilmişse giriş hakkı sayısını bir bir düşürüyor.

                LblGirisHakki.Text = "Kalan giriş hakkı" + " " + loginCount.ToString();
                // Kalan giriş hakkkını ekranda yazdırıyoruz.

                LblGirisHakki.Visible = true;
                // Kullanıcı yanlış giriş yaptığı için giriş hakkı yazılı olan label'ın visible özelliğini true
                // yapıyoruz.
            }
            if (loginCount == 0)
            {
                MessageBox.Show("Giriş hakkınız kalmadı lütfen daha sonra tekrar deneyiniz.");
                // 3 defa yanlış id ve password girildiği takdirde ekrana kullanıcıyı uyaran bir pencere çıkıyor.

                TxtId.Enabled = false;
                TxtPassword.Enabled = false;
                BtnLogin.Enabled = false;

                // Eğer giriş hakkı 0 ise, kullanıcının giriş yapmasını engelliyoruz.
            }

        }

        private void ChkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            switch (ChkRememberMe.Checked)
            {
                case true:
                    TxtId.Text = "admin";
                    TxtPassword.Text = "1234";
                    break;
                // Eğer remember checkbox kontorlü işaretlenirse otomatik olarak değerleri getiriyor.

                default:
                    TxtId.Text = "";
                    TxtPassword.Text = "";
                    break;
                    // Eğer remember checkbox kontorlü işaretlenmemişse değerleri ekrandan kaldırıyor.
            }

        }
    }
}
