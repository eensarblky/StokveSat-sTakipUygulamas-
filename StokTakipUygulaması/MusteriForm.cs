using StokSatisTakip.Domain;
using StokSatisTakip.Service;
using System;
using System.Windows.Forms;

namespace StokSatisTakip
{
    public partial class MusteriForm : Form
    {
        
        MusteriService servis = new MusteriService();

        public MusteriForm()
        {
            InitializeComponent();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            Listele();
            
        
            ModernTasarimUygula();              Listele();
            TabloyuSusle(dataGridView1);          
            
            if (cmbTur.Items.Count > 0) cmbTur.SelectedIndex = 0;
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
                
                servis.kaydet(txtAdSoyad.Text, txtTelefon.Text, cmbTur.SelectedIndex);

                MessageBox.Show("Müşteri eklendi.");
                Listele();

               
                txtAdSoyad.Clear();
                txtTelefon.Clear();
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
                MessageBox.Show("Müşteri silindi.");
                Listele();
            }
            else
            {
                MessageBox.Show("Seçim yapmalısınız.");
            }
        }

    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtAdSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();

                
                int tur = Convert.ToInt32(row.Cells["Tur"].Value);
                cmbTur.SelectedIndex = tur;
            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
                {
                    MessageBox.Show("Lütfen Müşteri Adı ve Soyadı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                
                
                if (string.IsNullOrWhiteSpace(txtTelefon.Text))
                {
                    MessageBox.Show("Lütfen Telefon numarası giriniz!");
                    return;
                }
                
               
                servis.kaydet(txtAdSoyad.Text, txtTelefon.Text, cmbTur.SelectedIndex);

                MessageBox.Show("Müşteri eklendi.");
                Listele();

               
                txtAdSoyad.Clear();
                txtTelefon.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int secilenId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                servis.sil(secilenId);
                MessageBox.Show("Müşteri silindi.");
                Listele();
            }
            else
            {
                MessageBox.Show("Seçim yapmalısınız.");
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

                 private void ModernTasarimUygula()
        {
                         this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(244, 247, 252);
            this.StartPosition = FormStartPosition.CenterScreen;

                         Button btnKapat = new Button();
            btnKapat.Text = "X";
            btnKapat.Size = new Size(40, 40);
            btnKapat.Location = new Point(this.Width - 40, 0);              btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.ForeColor = Color.Gray;
            btnKapat.Font = new Font("Verdana", 12, FontStyle.Bold);
            btnKapat.Click += (s, e) => { this.Close(); };                                                                          btnKapat.MouseEnter += (s, e) => { btnKapat.BackColor = Color.Red; btnKapat.ForeColor = Color.White; };
            btnKapat.MouseLeave += (s, e) => { btnKapat.BackColor = Color.Transparent; btnKapat.ForeColor = Color.Gray; };
            this.Controls.Add(btnKapat);

                         Panel pnlHeader = new Panel();
            pnlHeader.Size = new Size(this.Width - 40, 40);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.MouseDown += Header_MouseDown;              this.Controls.Add(pnlHeader);
        }

                 private void TabloyuSusle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);              dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);              dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowHeadersVisible = false;              dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);          }
    }
}
