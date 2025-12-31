using StokSatisTakip.Domain;
using StokSatisTakip.Service;
using System;
using System.Collections.Generic;
using System.Drawing;  using System.Runtime.InteropServices;  using System.Windows.Forms;

namespace StokSatisTakip
{
    public partial class SatisForm : Form
    {
                 [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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
            this.BackColor = Color.FromArgb(244, 247, 252);
            this.StartPosition = FormStartPosition.CenterScreen;

                         Button btnKapat = new Button();
            btnKapat.Text = "X";
            btnKapat.Size = new Size(40, 40);
            btnKapat.Location = new Point(this.Width - 40, 0);
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.ForeColor = Color.Gray;
            btnKapat.Font = new Font("Verdana", 12, FontStyle.Bold);
            btnKapat.Click += (s, e) => { this.Close(); };
            btnKapat.MouseEnter += (s, e) => { btnKapat.BackColor = Color.Red; btnKapat.ForeColor = Color.White; };
            btnKapat.MouseLeave += (s, e) => { btnKapat.BackColor = Color.Transparent; btnKapat.ForeColor = Color.Gray; };
            this.Controls.Add(btnKapat);

                         Panel pnlHeader = new Panel();
            pnlHeader.Size = new Size(this.Width - 40, 40);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.MouseDown += Header_MouseDown;
            this.Controls.Add(pnlHeader);
        }

        private void TabloyuSusle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;          }

                 MusteriService musteriService = new MusteriService();
        UrunService urunService = new UrunService();
        SatisService satisService = new SatisService();

        List<SatisDetay> sepet = new List<SatisDetay>();

        class SepetGorunum
        {
            public int UrunId { get; set; }
            public string UrunAdi { get; set; }
            public int Adet { get; set; }
            public decimal BirimFiyat { get; set; }
            public decimal Toplam { get; set; }
        }
        List<SepetGorunum> sepetGorunumListesi = new List<SepetGorunum>();

        decimal genelToplam = 0;

        public SatisForm()
        {
            InitializeComponent();
        }

                 private void SatisForm_Load_1(object sender, EventArgs e)
        {
            ModernTasarimUygula();  
                         TabloyuSusle(gridSepet);

                         cmbMusteri.DataSource = musteriService.tumunuGetir();
            cmbUrun.DataSource = urunService.tumunuGetir();
        }

        private void btnSepetEkle_Click_1(object sender, EventArgs e)
        {
            if (cmbUrun.SelectedItem == null || string.IsNullOrWhiteSpace(txtAdet.Text))
            {
                MessageBox.Show("Lütfen ürün ve adet seçiniz.");
                return;
            }

            Urun secilenUrun = (Urun)cmbUrun.SelectedItem;
            int adet = Convert.ToInt32(txtAdet.Text);

            if (adet > secilenUrun.StokAdedi)
            {
                MessageBox.Show("Yetersiz Stok! Mevcut Stok: " + secilenUrun.StokAdedi);
                return;
            }

                         SatisDetay detay = new SatisDetay();
            detay.UrunId = secilenUrun.Id;
            detay.Adet = adet;
            detay.BirimFiyat = secilenUrun.Fiyat;
            sepet.Add(detay);

                         SepetGorunum gorunum = new SepetGorunum();
            gorunum.UrunId = secilenUrun.Id;
            gorunum.UrunAdi = secilenUrun.UrunAdi;
            gorunum.Adet = adet;
            gorunum.BirimFiyat = secilenUrun.Fiyat;
            gorunum.Toplam = adet * secilenUrun.Fiyat;
            sepetGorunumListesi.Add(gorunum);

                         gridSepet.DataSource = null;
            gridSepet.DataSource = sepetGorunumListesi;

                         if (gridSepet.Columns["UrunId"] != null) gridSepet.Columns["UrunId"].Visible = false;

            genelToplam += gorunum.Toplam;
            lblToplam.Text = genelToplam.ToString("N2") + " TL";

            txtAdet.Clear();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (sepet.Count == 0)
            {
                MessageBox.Show("Sepetiniz boş!");
                return;
            }

            if (cmbMusteri.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.");
                return;
            }

            try
            {
                Musteri secilenMusteri = (Musteri)cmbMusteri.SelectedItem;
                satisService.satisiTamamla(secilenMusteri.Id, genelToplam, sepet);

                MessageBox.Show("Satış başarıyla tamamlandı.");

                                 sepet.Clear();
                sepetGorunumListesi.Clear();
                gridSepet.DataSource = null;
                genelToplam = 0;
                lblToplam.Text = "0.00 TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}