 using System;
using System.Windows.Forms;
using StokSatisTakip.DAL;
using StokSatisTakip.Domain;  
namespace StokSatisTakip
{
    public partial class KullanıcıEkle : Form
    {   

        KullaniciDAO dao = new KullaniciDAO();

        public KullanıcıEkle()
        {
            InitializeComponent();
        }


        private void KullanıcıEkle_Load(object sender, EventArgs e)
        {
            Listele();


            if (cmbRol.Items.Count == 0)
            {
                cmbRol.Items.Add("Yönetici");
                cmbRol.Items.Add("Satis Personeli");
                cmbRol.Items.Add("Depo Gorevlisi");
            }
        }


        void Listele()
        {

            dgvKullanicilar.DataSource = dao.KullanicilariGetir();
        }
        private int seciliId = 0;

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtKadi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir rol seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Kullanici yeniPersonel = new Kullanici();
            yeniPersonel.KullaniciAdi = txtKadi.Text;
            yeniPersonel.Sifre = txtSifre.Text;
            yeniPersonel.Rol = cmbRol.Text;


            try
            {
                dao.kaydet(yeniPersonel);
                MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtAdSoyad.Clear();
                txtKadi.Clear();
                txtSifre.Clear();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKullanicilar.Rows[e.RowIndex];


                seciliId = Convert.ToInt32(row.Cells["Id"].Value);


                txtKadi.Text = row.Cells["KullaniciAdi"].Value.ToString();
                txtSifre.Text = row.Cells["Sifre"].Value.ToString();
                cmbRol.Text = row.Cells["Rol"].Value.ToString();


                txtAdSoyad.Text = row.Cells["KullaniciAdi"].Value.ToString();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliId == 0) { MessageBox.Show("Lütfen listeden bir kullanıcı seçin!"); return; }

            Kullanici guncellenecek = new Kullanici();
            guncellenecek.Id = seciliId;
            guncellenecek.KullaniciAdi = txtKadi.Text;
            guncellenecek.Sifre = txtSifre.Text;
            guncellenecek.Rol = cmbRol.Text;

            try
            {
                dao.guncelle(guncellenecek);
                MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliId == 0) { MessageBox.Show("Lütfen listeden bir kullanıcı seçin!"); return; }

            DialogResult sonuc = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    dao.sil(seciliId);
                    MessageBox.Show("Kullanıcı silindi.");
                    Listele();
                    Temizle();
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            }
        }


        void Temizle()
        {
            txtAdSoyad.Clear();
            txtKadi.Clear();
            txtSifre.Clear();
            cmbRol.SelectedIndex = -1;
            seciliId = 0;
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (seciliId == 0) { MessageBox.Show("Lütfen listeden bir kullanıcı seçin!"); return; }

            DialogResult sonuc = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    dao.sil(seciliId);
                    MessageBox.Show("Kullanıcı silindi.");
                    Listele();
                    Temizle();
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            }
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (seciliId == 0) { MessageBox.Show("Lütfen listeden bir kullanıcı seçin!"); return; }

            Kullanici guncellenecek = new Kullanici();
            guncellenecek.Id = seciliId;
            guncellenecek.KullaniciAdi = txtKadi.Text;
            guncellenecek.Sifre = txtSifre.Text;
            guncellenecek.Rol = cmbRol.Text;

            try
            {
                dao.guncelle(guncellenecek);
                MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }
    }
}