using System.Collections;

namespace StokSatisTakip.DAL
{
     
    public interface IRepository<T>
    {
        void kaydet(T entity);
        void sil(int id);
        ArrayList tumunuGetir();
    }
}