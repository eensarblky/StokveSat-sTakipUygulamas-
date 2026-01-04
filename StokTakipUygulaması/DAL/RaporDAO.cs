using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace StokSatisTakip.DAL
{
    internal class RaporDAO
    {
        private string dbBaglanti = "Server=172.21.54.253;Database=26_132430012;User ID=26_132430012;Password=İnif123.;";

        public DataTable KritikStokGetir()
        {
            MySqlConnection baglanti = new MySqlConnection(dbBaglanti);
            string sql = "SELECT UrunAdi, StokAdedi, KritikStok FROM Urunler WHERE StokAdedi <= KritikStok";
            MySqlDataAdapter adtr = new MySqlDataAdapter(sql, baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            return tablo;
        }
        public DataTable KarZararGetir()
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                 

                string sql = @"
            SELECT 
                u.UrunAdi,
                SUM(sd.adet) as ToplamSatis,
                SUM(sd.adet * (sd.birimFiyat - u.FiyatAlis)) as ToplamKar
            FROM satisDetaylari sd
            JOIN Urunler u ON sd.ürünId = u.Id
            GROUP BY u.UrunAdi";

                MySqlDataAdapter adtr = new MySqlDataAdapter(sql, baglanti);
                DataTable tablo = new DataTable();
                adtr.Fill(tablo);
                return tablo;
            }
        }
        public DataTable AylikSatisGetir()
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                string sql = @"
                    SELECT 
                        DATE_FORMAT(Tarih, '%Y-%m') as Donem, 
                        COUNT(*) as ToplamIslem, 
                        SUM(ToplamTutar) as Ciro 
                    FROM satislar 
                    GROUP BY Donem 
                    ORDER BY Donem DESC";

                MySqlDataAdapter adtr = new MySqlDataAdapter(sql, baglanti);
                DataTable tablo = new DataTable();
                adtr.Fill(tablo);
                return tablo;
            }
        }

        public DataTable EnCokSatanlariGetir()
        { 
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                 
                string sql = @"
            SELECT 
                u.UrunAdi, 
                SUM(sd.adet) as ToplamSatilanAdet 
            FROM satisDetaylari sd
            JOIN Urunler u ON sd.ürünId = u.Id
            GROUP BY u.UrunAdi 
            ORDER BY ToplamSatilanAdet DESC 
            LIMIT 10";

                MySqlDataAdapter adtr = new MySqlDataAdapter(sql, baglanti);
                DataTable tablo = new DataTable();
                adtr.Fill(tablo);
                return tablo;
            }
        }



        public DataTable MusteriCiroGetir()
        {
            using (MySqlConnection baglanti = new MySqlConnection(dbBaglanti))
            {
                 

                string sql = @"
            SELECT 
                m.adSoyad as MusteriAdi, 
                SUM(s.toplamTutar) as ToplamHarcama 
            FROM satislar s
            JOIN musteriler m ON s.müsteriId = m.Id
            GROUP BY m.adSoyad 
            ORDER BY ToplamHarcama DESC";

                MySqlDataAdapter adtr = new MySqlDataAdapter(sql, baglanti);
                DataTable tablo = new DataTable();
                adtr.Fill(tablo);
                return tablo;
            }
        }

    }
    }

