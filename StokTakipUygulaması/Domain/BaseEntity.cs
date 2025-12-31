namespace StokSatisTakip.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
    }
}