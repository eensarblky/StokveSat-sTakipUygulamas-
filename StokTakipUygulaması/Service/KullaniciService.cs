using StokSatisTakip.DAL;

namespace StokSatisTakip.Service
{
    public class KullaniciService
    {
        KullaniciDAO dao = new KullaniciDAO();

        
        public bool GirisKontrol(string kadi, string sifre)
        {
          
            return dao.GirisYap(kadi, sifre);
        }
    }
}