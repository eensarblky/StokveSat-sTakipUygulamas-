using MySql.Data.MySqlClient;
using StokSatisTakip.Domain;
using System;
using System.Collections;

namespace StokSatisTakip.DAL
{
     
    internal class SatisDAO : IRepository<Satis>
    {
        private string dbBaglanti = "Server=172.21.54.253;Database=26_132430012;User ID=26_132430012;Password=İnif123.;";

       

        public void kaydet(Satis s)
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                baglanti.Open();

                string tarihFormat = s.Tarih.ToString("yyyy-MM-dd HH:mm:ss");

             
                string sql = "INSERT INTO satislar (müsteriId, tarih, toplamTutar) VALUES (@mId, @tarih, @tutar)";
                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@mId", s.MusteriId);
                komut.Parameters.AddWithValue("@tarih", tarihFormat);
                komut.Parameters.AddWithValue("@tutar", s.ToplamTutar); 

                komut.ExecuteNonQuery();

                
                komut.CommandText = "SELECT LAST_INSERT_ID()";
                s.Id = Convert.ToInt32(komut.ExecuteScalar());
            }
        }

        public void sil(int id)
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                baglanti.Open();
               
                new MySqlCommand("DELETE FROM satisDetaylari WHERE satisId=" + id, baglanti).ExecuteNonQuery();
                new MySqlCommand("DELETE FROM satislar WHERE Id=" + id, baglanti).ExecuteNonQuery();
            }
        }

        public ArrayList tumunuGetir()
        {
          
            return new ArrayList();
        }

         

        
        public void detayKaydet(SatisDetay sd)
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                baglanti.Open();
                string sql = "INSERT INTO satisDetaylari (satisId, ürünId, adet, birimFiyat) VALUES (@sId, @uId, @adet, @fiyat)";
                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@sId", sd.SatisId);
                komut.Parameters.AddWithValue("@uId", sd.UrunId);
                komut.Parameters.AddWithValue("@adet", sd.Adet);
                komut.Parameters.AddWithValue("@fiyat", sd.BirimFiyat);

                komut.ExecuteNonQuery();
            }
        }
    }
}