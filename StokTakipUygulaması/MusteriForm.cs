using StokSatisTakip.Domain;
using StokSatisTakip.Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StokSatisTakip
{
    public partial class MusteriForm : Form
    {

        MusteriService servis = new MusteriService();
        private int secilenId = 0;

        public MusteriForm()
        {
            InitializeComponent();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            Listele();
            ModernTasarimUygula();
            TabloyuSusle(dataGridView1);

            if (cmbTur.Items.Count > 0) cmbTur.SelectedIndex = 0;
        }


        void Listele()
        {
            dataGridView1.DataSource = servis.tumunuGetir();
            if (dataGridView1.Columns["Tur"] != null)
                dataGridView1.Columns["Tur"].Visible = false;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                if (row.Cells["Id"].Value != null)
                {
                    secilenId = Convert.ToInt32(row.Cells["Id"].Value);


                    txtAdSoyad.Text = row.Cells["AdSoyad"].Value?.ToString();
                    txtTelefon.Text = row.Cells["Telefon"].Value?.ToString();


                    if (row.Cells["Tur"].Value != null)
                    {
                        int turIndex = Convert.ToInt32(row.Cells["Tur"].Value);
                        if (turIndex < cmbTur.Items.Count) cmbTur.SelectedIndex = turIndex;
                    }
                }
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
                {
                    MessageBox.Show("Lütfen Ad Soyad giriniz!", "Uyarı");
                    return;
                }

                servis.kaydet(txtAdSoyad.Text, txtTelefon.Text, cmbTur.SelectedIndex);
                MessageBox.Show("Müşteri başarıyla eklendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Lütfen listeden güncellenecek bir müşteri seçin!");
                return;
            }

            try
            {
                servis.guncelle(secilenId, txtAdSoyad.Text, txtTelefon.Text, cmbTur.SelectedIndex);
                MessageBox.Show("Müşteri bilgileri güncellendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        // SİL BUTONU
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Lütfen silinecek müşteriyi listeden seçin.");
                return;
            }

            DialogResult onay = MessageBox.Show("Bu müşteriyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                servis.sil(secilenId);
                MessageBox.Show("Müşteri silindi.");
                Listele();
                Temizle();
            }
        }


        void Temizle()
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            cmbTur.SelectedIndex = 0;
            secilenId = 0;
        }

        #region Modern Tasarım Kodları

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
        }

        #endregion
    }
}