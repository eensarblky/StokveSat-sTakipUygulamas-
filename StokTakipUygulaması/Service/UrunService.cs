using StokSatisTakip.DAL;
using StokSatisTakip.Domain;
using System.Collections;

namespace StokSatisTakip.Service
{
    public class UrunService 
    {
        public void kaydet(string ad, string barkod, string fiyat, string stok, string kritikStok, string FiyatAlis)
        {
            decimal dFiyat = Convert.ToDecimal(fiyat);
            decimal dAlisFiyat = Convert.ToDecimal(FiyatAlis);
            int iStok = Convert.ToInt32(stok);
            int iKritik = Convert.ToInt32(kritikStok);

            Urun u = new Urun(ad, barkod, dFiyat, iStok, iKritik,dAlisFiyat);
            (new UrunDAO()).kaydet(u);
        }

        public ArrayList tumunuGetir()
        {
            return (new UrunDAO()).tumunuGetir();
        }

        public void sil(int id)
        {
            (new UrunDAO()).sil(id);
        }

        public void stokDus(int urunId, int dusulecekAdet, int _önemsiz)
        {
            ArrayList tumUrunler = (new UrunDAO()).tumunuGetir();
            Urun bulunan = null;

            foreach (Urun u in tumUrunler)
            {
                if (u.Id == urunId)
                {
                    bulunan = u;
                    break;
                }
            }

            if (bulunan != null)
            {
                int yeniStok = bulunan.StokAdedi - dusulecekAdet;

                (new UrunDAO()).stokGuncelle(urunId, yeniStok);
            }

        }
        public void guncelle(int id, string ad, string barkod, string fiyat, string stok, string kritik, string alis)
        {
            Urun u = new Urun();
            u.Id = id;
            u.UrunAdi = ad;
            u.Barkod = barkod;
            u.Fiyat = Convert.ToDecimal(fiyat);
            u.StokAdedi = Convert.ToInt32(stok);
            u.KritikStok = Convert.ToInt32(kritik);
            u.FiyatAlis = Convert.ToDecimal(alis);

            UrunDAO dao = new UrunDAO();
            dao.guncelle(u);
        }
    }
}