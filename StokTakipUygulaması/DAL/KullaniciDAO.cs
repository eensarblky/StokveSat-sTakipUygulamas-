using MySql.Data.MySqlClient;
using StokSatisTakip.Domain;
using System;
using System.Collections;
using System.Data;

namespace StokSatisTakip.DAL
{
    // 1. IRepository arayüzünü uyguladığımızı belirtiyoruz
    internal class KullaniciDAO : IRepository<Kullanici>
    {
        private string dbBaglanti = "Server=172.21.54.253;Database=26_132430012;User ID=26_132430012;Password=İnif123.;";

        // --- INTERFACE GEREKSİNİMLERİ (Zorunlu Metotlar) ---

        // Kaydetme Metodu (Eskiden KullaniciEkle idi, artık 'kaydet' ve nesne alıyor)
        public void kaydet(Kullanici k)
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                baglanti.Open();

                string sql = "INSERT INTO kullanicilar (KullaniciAdi, Sifre, Rol) VALUES (@kadi, @sifre, @rol)";

                MySqlCommand komut = new MySqlCommand(sql, baglanti);

                // Nesne içindeki verileri parametrelere atıyoruz
                komut.Parameters.AddWithValue("@kadi", k.KullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", k.Sifre);
                komut.Parameters.AddWithValue("@rol", k.Rol);

                komut.ExecuteNonQuery();
            }
        }

        // Silme Metodu
        public void sil(int id)
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                baglanti.Open();
                string sql = "DELETE FROM kullanicilar WHERE Id=@id";
                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
            }
        }

        // Listeleme Metodu (ArrayList döndüren)
        public ArrayList tumunuGetir()
        {
            ArrayList kullanicilar = new ArrayList();
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM kullanicilar", baglanti);
                MySqlDataReader okunan = komut.ExecuteReader();
                while (okunan.Read())
                {
                    Kullanici k = new Kullanici(
                        okunan["KullaniciAdi"].ToString(),
                        okunan["Sifre"].ToString(),
                        okunan["Rol"].ToString()
                    );
                    k.Id = Convert.ToInt32(okunan["Id"]);
                    kullanicilar.Add(k);
                }
            }
            return kullanicilar;
        }

        // --- DİĞER ÖZEL METOTLAR ---

        // Giriş Yapma (Login) Metodu
        public bool GirisYap(string kadi, string sifre)
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                baglanti.Open();
                string sql = "SELECT Id, KullaniciAdi, Rol FROM kullanicilar WHERE KullaniciAdi=@ad AND Sifre=@sifre";

                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@ad", kadi);
                komut.Parameters.AddWithValue("@sifre", sifre);

                MySqlDataReader oku = komut.ExecuteReader();

                if (oku.Read()) // Kayıt bulunduysa
                {
                    Domain.Oturum.KullaniciId = Convert.ToInt32(oku["Id"]);
                    Domain.Oturum.AdSoyad = oku["KullaniciAdi"].ToString();
                    Domain.Oturum.Rol = oku["Rol"].ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // DataGridView doldurmak için DataTable döndüren metot
        public DataTable KullanicilariGetir()
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                // Şifreleri güvenlik gereği listede göstermeyelim
                MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT Id, KullaniciAdi, Rol FROM kullanicilar", baglanti);
                DataTable tablo = new DataTable();
                adtr.Fill(tablo);
                return tablo;
            }
        }
    }
}