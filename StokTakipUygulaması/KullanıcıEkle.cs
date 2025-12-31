using System;
using System.Windows.Forms;
using StokSatisTakip.DAL;
using StokSatisTakip.Domain; // <-- İŞTE EKSİK OLAN VE HATAYI ÇÖZEN SATIR BU!

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

                // Temizlik
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
    }
}