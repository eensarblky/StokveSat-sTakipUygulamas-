namespace StokSatisTakip.Domain
{
    public class Musteri : BaseEntity
    {
        public Musteri()
        { }

        public Musteri(string gAdSoyad, string gTelefon, int gTur)
        {
            this.AdSoyad = gAdSoyad;
            this.Telefon = gTelefon;
            this.Tur = gTur;
        }

         
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public int Tur { get; set; }

        public override string ToString()
        {
            return this.AdSoyad;
        }
    }
}