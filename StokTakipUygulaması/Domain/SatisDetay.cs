namespace StokSatisTakip.Domain
{
    public class SatisDetay : BaseEntity
    {
        public SatisDetay()
        { }

        public SatisDetay(int gSatisId, int gUrunId, int gAdet, decimal gBirimFiyat)
        {
            this.SatisId = gSatisId;
            this.UrunId = gUrunId;
            this.Adet = gAdet;
            this.BirimFiyat = gBirimFiyat;
        }

         
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
    }
}