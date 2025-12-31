using MySql.Data.MySqlClient;
using StokSatisTakip.Domain;
using System.Collections;

namespace StokSatisTakip.DAL
{
    internal class UrunDAO : IRepository<Urun>
    {
        private string dbBaglanti = "Server=172.21.54.253;Database=26_132430012;User ID=26_132430012;Password=İnif123.;";

        public void kaydet(Urun u)
        {
            MySqlConnection baglanti = new MySqlConnection(dbBaglanti);
            baglanti.Open();

            string sql = "insert into Urunler (UrunAdi, barkod, Fiyat, StokAdedi, KritikStok, FiyatAlis) values ('" +
             u.UrunAdi + "','" +
             u.Barkod + "'," +
             u.Fiyat.ToString().Replace(',', '.') + "," +
             u.StokAdedi + "," +       
             u.KritikStok + "," +     
             u.FiyatAlis.ToString().Replace(',', '.') + ")";

            new MySqlCommand(sql, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        public ArrayList tumunuGetir()
        {
            ArrayList urunler = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection(dbBaglanti);
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from Urunler", baglanti);
            MySqlDataReader okunan = komut.ExecuteReader();
            while (okunan.Read())
            {
                Urun u = new Urun();
                u.Id = Convert.ToInt32(okunan["Id"]);
                u.UrunAdi = okunan["UrunAdi"].ToString();
                u.Barkod = okunan["barkod"].ToString();
                u.Fiyat = Convert.ToDecimal(okunan["Fiyat"]);
                u.StokAdedi = Convert.ToInt32(okunan["StokAdedi"]);
                u.KritikStok = Convert.ToInt32(okunan["KritikStok"]);
                u.FiyatAlis = Convert.ToDecimal(okunan["FiyatAlis"]);
                urunler.Add(u);
            }
            baglanti.Close();
            return urunler;
        }

        public void sil(int id)
        {
            MySqlConnection baglanti = new MySqlConnection(dbBaglanti);
            baglanti.Open();
            new MySqlCommand("delete from Urunler where Id=" + id, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }

        public void stokGuncelle(int urunId, int yeniStok)
        {
            MySqlConnection baglanti = new MySqlConnection(dbBaglanti);
            baglanti.Open();
            new MySqlCommand("update Urunler set StokAdedi=" + yeniStok + " where Id=" + urunId, baglanti).ExecuteNonQuery();
            baglanti.Close();
        }
    }
}