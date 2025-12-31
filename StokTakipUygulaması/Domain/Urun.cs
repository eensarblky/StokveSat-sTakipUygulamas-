namespace StokSatisTakip.Domain
{
    public class Urun : BaseEntity
    {
        public Urun()
        { }

        public Urun(string gUrunAdi, string gBarkod, decimal gFiyat, int gStokAdedi, int gKritikStok , decimal gFiyatAlis)
        {
            this.UrunAdi = gUrunAdi;
            this.Barkod = gBarkod;
            this.Fiyat = gFiyat;
            this.FiyatAlis = gFiyatAlis;
            this.StokAdedi = gStokAdedi;
            this.KritikStok = gKritikStok;
        }

        
        public string UrunAdi { get; set; }
        public string Barkod { get; set; }
        public decimal Fiyat { get; set; }
        public decimal FiyatAlis { get; set; }
        public int StokAdedi { get; set; }
        public int KritikStok { get; set; }

        public override string ToString()
        {
            return this.UrunAdi;
        }
    }
}