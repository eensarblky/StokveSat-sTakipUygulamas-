namespace StokSatisTakip.Domain
{
    public class Kullanici : BaseEntity
    {
        public Kullanici()
        { }

        public Kullanici(string gKullaniciAdi, string gSifre, string gRol)
        {
            this.KullaniciAdi = gKullaniciAdi;
            this.Sifre = gSifre;
            this.Rol = gRol;
        }

         
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }

        public override string ToString()
        {
            return this.KullaniciAdi;
        }
    }
}