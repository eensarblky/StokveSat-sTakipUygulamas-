using MySql.Data.MySqlClient;
using StokSatisTakip.Domain;
using System.Collections;

namespace StokSatisTakip.DAL
{
    internal class MusteriDAO : IRepository<Musteri>
    {
        private string dbBaglanti = "Server=172.21.54.253;Database=26_132430012;User ID=26_132430012;Password=İnif123.;";

        public void kaydet(Musteri m)
        {
            MySqlConnection baglanti = new MySqlConnection(dbBaglanti);
            baglanti.Open();

            string sql = "insert into musteriler (adSoyad, telefon, tür) values ('" + m.AdSoyad + "','" + m.Telefon + "'," + m.Tur + ")";
            new MySqlCommand(sql, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        public ArrayList tumunuGetir()
        {
            ArrayList musteriler = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection(dbBaglanti);
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from musteriler", baglanti);
            MySqlDataReader okunan = komut.ExecuteReader();
            while (okunan.Read())
            {
                Musteri m = new Musteri();
                m.Id = Convert.ToInt32(okunan["Id"]);
                m.AdSoyad = okunan["adSoyad"].ToString();
                m.Telefon = okunan["telefon"].ToString();
                m.Tur = Convert.ToInt32(okunan["tür"]); musteriler.Add(m);
            }
            baglanti.Close();
            return musteriler;
        }

        public void sil(int id)
        {
            MySqlConnection baglanti = new MySqlConnection(dbBaglanti);
            baglanti.Open();
            new MySqlCommand("delete from musteriler where Id=" + id, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }
        public void guncelle(Musteri m)
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                baglanti.Open();
                 
                string sql = "UPDATE musteriler SET adSoyad=@ad, telefon=@tel, tür=@tur WHERE Id=@id";

                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@ad", m.AdSoyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@tur", m.Tur);
                komut.Parameters.AddWithValue("@id", m.Id);

                komut.ExecuteNonQuery();
            }
        }
    }
}