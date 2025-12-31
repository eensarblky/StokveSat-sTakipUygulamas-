namespace StokSatisTakip.Domain
{
    public class Satis : BaseEntity
    {
        public Satis()
        { }

        public Satis(int gMusteriId, DateTime gTarih, decimal gToplamTutar)
        {
            this.MusteriId = gMusteriId;
            this.Tarih = gTarih;
            this.ToplamTutar = gToplamTutar;
        }

         
        public int MusteriId { get; set; }
        public DateTime Tarih { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}