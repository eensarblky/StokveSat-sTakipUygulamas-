using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StokSatisTakip
{
    public partial class AnaMenu : Form
    {
        // --- SÜRÜKLEME İÇİN GEREKLİ DLL'LER ---
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Yapıcı Metot (Constructor)
        public AnaMenu()
        {
            InitializeComponent();
            ModernTasarimUygula(); // Tasarımı yükle
        }

        // --- SÜRÜKLEME OLAYI (ARTIK PANELE BAĞLI) ---
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        // --- MODERN TASARIM VE PANEL AYARLARI ---
        private void ModernTasarimUygula()
        {
            // 1. Formun Çerçevesini Kaldır
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(244, 247, 252);

            // 2. Üst Tarafa Sürükleme Paneli Ekle (Görünmez Şerit)
            Panel pnlBaslik = new Panel();
            pnlBaslik.Dock = DockStyle.Top; // En tepeye yapışsın
            pnlBaslik.Height = 40;          // Yüksekliği 40 piksel
            pnlBaslik.BackColor = Color.FromArgb(44, 62, 80); // Şeffaf olsun

            // Sürükleme olayını bu panele veriyoruz!
            pnlBaslik.MouseDown += Header_MouseDown;

            this.Controls.Add(pnlBaslik); // Paneli forma ekle

            // Mevcut btnKapat kodunu bununla değiştir:

            Button btnKapat = new Button();
            btnKapat.Text = "X";
            btnKapat.Size = new Size(40, 40);
            btnKapat.Location = new Point(this.Width - 40, 0);
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.FlatAppearance.BorderSize = 0;

            // NORMAL DURUMDAKİ RENGİ (Burayı değiştirdik)
            btnKapat.ForeColor = Color.Firebrick; // Daha şık bir kırmızı tonu
            btnKapat.BackColor = Color.Transparent;

            btnKapat.Font = new Font("Verdana", 12, FontStyle.Bold);
            btnKapat.Cursor = Cursors.Hand;

            // TIKLAMA OLAYI
            btnKapat.Click += (s, e) => { Application.Exit(); };

            // FARE ÜZERİNE GELİNCE (HOVER)
            btnKapat.MouseEnter += (s, e) =>
            {
                btnKapat.BackColor = Color.Red;       // Arkaplan kıpkırmızı olsun
                btnKapat.ForeColor = Color.White;     // Yazı beyaz olsun
            };

            // FARE ÜZERİNDEN GİDİNCE (ESKİ HALİ)
            btnKapat.MouseLeave += (s, e) =>
            {
                btnKapat.BackColor = Color.Transparent;
                btnKapat.ForeColor = Color.Firebrick; // Normal rengine dönsün
            };

            this.Controls.Add(btnKapat);
            btnKapat.BringToFront();



        }

        // --- BUTON TIKLAMA OLAYLARI (BUNLAR SİLİNİRSE HATA VERİR) ---

        private void btnUrunIslem_Click(object sender, EventArgs e)
        {
            UrunForm urun = new UrunForm();
            urun.ShowDialog();
        }

        private void btnMusteriIslem_Click(object sender, EventArgs e)
        {
            MusteriForm musteri = new MusteriForm();
            musteri.ShowDialog();
        }

        private void btnSatisIslem_Click(object sender, EventArgs e)
        {
            SatisForm satis = new SatisForm();
            satis.ShowDialog();
        }

        // Eğer Rapor butonunu tasarım ekranından (Toolbox) eklediysen ve adı 'btnRapor' ise:
        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporForm rapor = new RaporForm();
            rapor.ShowDialog();
        }

        // Eski çıkış butonu varsa hatayı önlemek için dursun
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRapor_Click_1(object sender, EventArgs e)
        {
            RaporForm rapor = new RaporForm();
            rapor.ShowDialog();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            
            this.Text = "Ana Menü - Hoşgeldin " + Domain.Oturum.AdSoyad;

            
            string rol = Domain.Oturum.Rol.Trim();

           
            btnKullaniciYonetim.Visible = false;

            
            if (rol == "Yönetici")
            {
                
                btnKullaniciYonetim.Visible = true;

                
                btnUrunIslem.Visible = true;
                btnSatisIslem.Visible = true;
                btnMusteriIslem.Visible = true;
                btnRapor.Visible = true;
            }
            else if (rol == "Satış Personeli")
            {
                
                btnSatisIslem.Visible = true;
                btnMusteriIslem.Visible = true;
                btnUrunIslem.Visible = true; 

               
                btnRapor.Visible = false;
            }
            else if (rol == "Depo Görevlisi")
            {
                
                btnUrunIslem.Visible = true;

               
                btnSatisIslem.Visible = false;
                btnMusteriIslem.Visible = false;
                btnRapor.Visible = false;
            }
        }

        private void btnKullaniciYonetim_Click(object sender, EventArgs e)
        {
        
            KullanıcıEkle form = new KullanıcıEkle();
            form.ShowDialog();
        }
    }
    
}