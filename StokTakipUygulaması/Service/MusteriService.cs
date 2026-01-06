using StokSatisTakip.DAL;
using StokSatisTakip.Domain;
using System.Collections;

namespace StokSatisTakip.Service
{
    public class MusteriService
    {
        public void kaydet(string adSoyad, string telefon, int tur)
        {
            Musteri m = new Musteri(adSoyad, telefon, tur);
            (new MusteriDAO()).kaydet(m);
        }

        public ArrayList tumunuGetir()
        {
            return (new MusteriDAO()).tumunuGetir();
        }

        public void sil(int id)
        {
            (new MusteriDAO()).sil(id);
        }
        public void guncelle(int id, string adSoyad, string telefon, int tur)
        {
            Musteri m = new Musteri(adSoyad, telefon, tur);
            m.Id = id;
            new MusteriDAO().guncelle(m);
        }
    }
}