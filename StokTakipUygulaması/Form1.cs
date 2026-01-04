using StokSatisTakip;
using StokSatisTakip.Domain;
using StokSatisTakip.Service;
using System.Runtime.InteropServices;

namespace StokTakipUygulaması
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciService servis = new KullaniciService();

             
            bool sonuc = servis.GirisKontrol(txtKullaniciAdi.Text, txtSifre.Text);

            if (sonuc == true)
            {
                 
                MessageBox.Show("Hoşgeldiniz: " + StokSatisTakip.Domain.Oturum.AdSoyad);

                AnaMenu menu = new AnaMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.DimGray;
        }
    }
}