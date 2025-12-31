using System;
using System.Windows.Forms;
using StokSatisTakip.Service;
using System.Drawing;
using System.Runtime.InteropServices;

namespace StokSatisTakip
{
    public partial class RaporForm : Form
    {

        RaporService servis = new RaporService();

        public RaporForm()
        {
            InitializeComponent();
        }

        private void btnKritik_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = servis.KritikStokGetir();
            TabloyuSusle(dataGridView1);
        }

        private void btnKarZarar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servis.KarZararGetir();
            TabloyuSusle(dataGridView1);
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servis.AylikSatisGetir();
            TabloyuSusle(dataGridView1);
        }

        private void btnEnCok_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servis.EnCokSatanlariGetir();
            TabloyuSusle(dataGridView1);
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servis.MusteriCiroGetir();
            TabloyuSusle(dataGridView1);
        }

        // --- PENCERE SÜRÜKLEME KODLARI ---
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

        // --- MODERN GÖRÜNÜM AYARLARI ---
        private void ModernTasarim()
        {
            // Çerçeveyi kaldır ve arkaplanı boya
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(244, 247, 252);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Kapatma Butonu (Sağ Üst)
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

            // Sürükleme Paneli (Header)
            Panel pnlHeader = new Panel();
            pnlHeader.Size = new Size(this.Width - 40, 40);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.MouseDown += Header_MouseDown; // Sürükleme olayını bağladık
            this.Controls.Add(pnlHeader);
        }

        // --- TABLO (GRID) SÜSLEME ---
        private void TabloyuSusle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80); // Koyu Lacivert Başlık
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185); // Seçili Satır Rengi
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); // Bir açık bir koyu satır
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Sütunları ekrana yay
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void RaporForm_Load(object sender, EventArgs e)
        {
            // Verileri çek (Burası zaten sende vardı)
            dataGridView1.DataSource = servis.KritikStokGetir();

            // --- BU İKİ SATIRI EKLE ---
            ModernTasarim();
            TabloyuSusle(dataGridView1);
        }

        private void btnKritik_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servis.KritikStokGetir();
            TabloyuSusle(dataGridView1);
        }

        private void btnKarZarar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servis.KarZararGetir();
            TabloyuSusle(dataGridView1);
        }
    }

}