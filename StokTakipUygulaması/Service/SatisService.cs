using StokSatisTakip.DAL;
using StokSatisTakip.Domain;
using System;
using System.Collections.Generic; 

namespace StokSatisTakip.Service
{
    public class SatisService
    {
        private SatisDAO dao = new SatisDAO();
        private UrunService urunService = new UrunService();

        public void satisiTamamla(int musteriId, decimal toplamTutar, List<SatisDetay> sepet)
        {
            Satis s = new Satis();
            s.MusteriId = musteriId;
            s.Tarih = DateTime.Now;
            s.ToplamTutar = toplamTutar;

            dao.kaydet(s);

           
            int satisId = s.Id;

            foreach (SatisDetay detay in sepet)
            {
                detay.SatisId = satisId;
                dao.detayKaydet(detay);

               
                urunService.stokDus(detay.UrunId, detay.Adet, 0);
            }
        }
    }
}