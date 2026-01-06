using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StokSatisTakip
{
    public partial class AnaMenu : Form
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public AnaMenu()
        {
            InitializeComponent();
            ModernTasarimUygula();
        }


        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }


        private void ModernTasarimUygula()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(244, 247, 252);


            Panel pnlBaslik = new Panel();
            pnlBaslik.Dock = DockStyle.Top;
            pnlBaslik.Height = 40;
            pnlBaslik.BackColor = Color.FromArgb(44, 62, 80);


            pnlBaslik.MouseDown += Header_MouseDown;

            this.Controls.Add(pnlBaslik);



            Button btnKapat = new Button();
            btnKapat.Text = "X";
            btnKapat.Size = new Size(40, 40);
            btnKapat.Location = new Point(this.Width - 40, 0);
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.FlatAppearance.BorderSize = 0;


            btnKapat.ForeColor = Color.Firebrick;
            btnKapat.BackColor = Color.Transparent;

            btnKapat.Font = new Font("Verdana", 12, FontStyle.Bold);
            btnKapat.Cursor = Cursors.Hand;


            btnKapat.Click += (s, e) => { Application.Exit(); };


            btnKapat.MouseEnter += (s, e) =>
            {
                btnKapat.BackColor = Color.Red;
                btnKapat.ForeColor = Color.White;
            };


            btnKapat.MouseLeave += (s, e) =>
            {
                btnKapat.BackColor = Color.Transparent;
                btnKapat.ForeColor = Color.Firebrick;
            };

            this.Controls.Add(btnKapat);
            btnKapat.BringToFront();



        }



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


        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporForm rapor = new RaporForm();
            rapor.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Oturum Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {

                StokTakipUygulaması.Form1 girisFormu = new StokTakipUygulaması.Form1();
                girisFormu.Show();

                StokSatisTakip.Domain.Oturum.KullaniciId = 0;
                StokSatisTakip.Domain.Oturum.AdSoyad = "";
                StokSatisTakip.Domain.Oturum.Rol = "";

                this.Close();
            }
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
            lblAdSoyadBilgi.Text = Domain.Oturum.AdSoyad;
            lblRolBilgi.Text = "Yetki: " + Domain.Oturum.Rol;

            KritikStokKontrol();
        }

        private void btnKullaniciYonetim_Click(object sender, EventArgs e)
        {

            KullanıcıEkle form = new KullanıcıEkle();
            form.ShowDialog();
        }

        private void KritikStokKontrol()
        {
            try
            {

                StokSatisTakip.Service.UrunService urunServis = new StokSatisTakip.Service.UrunService();
                System.Collections.ArrayList urunListesi = urunServis.tumunuGetir();

                int kritikAdet = 0;

                foreach (StokSatisTakip.Domain.Urun urun in urunListesi)
                {

                    if (urun.StokAdedi <= urun.KritikStok)
                    {
                        kritikAdet++;
                    }
                }


                lblKritikStok.Text = "Kritik Stok Uyarısı: " + kritikAdet + " Ürün";


                if (kritikAdet > 0)
                    lblKritikStok.ForeColor = Color.Red;
                else
                    lblKritikStok.ForeColor = Color.LightGreen;
            }
            catch (Exception)
            {
                lblKritikStok.Text = "Stok bilgisi alınamadı.";
            }
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }

}