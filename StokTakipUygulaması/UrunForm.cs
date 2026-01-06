using StokSatisTakip.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StokSatisTakip
{
    public partial class UrunForm : Form
    {
        private int secilenId = 0;

        UrunService servis = new UrunService();
        public UrunForm()
        {
            InitializeComponent();
        }



        private void UrunForm_Load(object sender, EventArgs e)
        {
            Listele();
            ModernTasarim();
            TabloyuSusle(dataGridView1);
        }
        void Listele()
        {
            dataGridView1.DataSource = servis.tumunuGetir();

            if (dataGridView1.Columns["Id"] != null) dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                servis.kaydet(txtAd.Text, txtBarkod.Text, txtFiyat.Text, txtStok.Text, txtKritik.Text, txtFiyatAlis.Text);
                MessageBox.Show("Ürün başarıyla eklendi.");
                Listele();


                txtAd.Clear(); txtBarkod.Clear(); txtFiyat.Clear(); txtStok.Clear(); txtKritik.Clear(); txtFiyatAlis.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int secilenId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                servis.sil(secilenId);
                MessageBox.Show("Ürün silindi.");
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir satır seçin.");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Seçilen ürünün ID'sini alıyoruz
                secilenId = Convert.ToInt32(row.Cells["Id"].Value);

                // Bilgileri kutucuklara dolduruyoruz
                txtAd.Text = row.Cells["UrunAdi"].Value.ToString();
                txtBarkod.Text = row.Cells["Barkod"].Value.ToString();
                txtFiyat.Text = row.Cells["Fiyat"].Value.ToString();
                txtStok.Text = row.Cells["StokAdedi"].Value.ToString();
                txtKritik.Text = row.Cells["KritikStok"].Value.ToString();
                txtFiyatAlis.Text = row.Cells["FiyatAlis"].Value.ToString();
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void ModernTasarim()
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
            pnlHeader.MouseDown += Header_MouseDown; this.Controls.Add(pnlHeader);
        }

        private void TabloyuSusle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80); dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185); dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowHeadersVisible = false; dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Lütfen listeden güncellenecek bir ürün seçin!");
                return;
            }

            try
            {
                // Servis üzerinden güncelleme yapıyoruz
                servis.guncelle(secilenId, txtAd.Text, txtBarkod.Text, txtFiyat.Text, txtStok.Text, txtKritik.Text, txtFiyatAlis.Text);

                MessageBox.Show("Ürün başarıyla güncellendi.");
                Listele(); // Listeyi yenile
                Temizle(); // Kutuları boşalt
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        void Temizle()
        {
            txtAd.Clear(); txtBarkod.Clear(); txtFiyat.Clear();
            txtStok.Clear(); txtKritik.Clear(); txtFiyatAlis.Clear();
            secilenId = 0;
        }
    }
}
