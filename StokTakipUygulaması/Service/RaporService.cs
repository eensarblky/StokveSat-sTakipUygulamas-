using System.Data;
using StokSatisTakip.DAL; 

namespace StokSatisTakip.Service
{
    public class RaporService
    {
        
        RaporDAO dao = new RaporDAO();

        public DataTable KritikStokGetir()
        {
            
            return dao.KritikStokGetir();
        }

        public DataTable KarZararGetir()
        {
            return dao.KarZararGetir();
        }
    
        public DataTable AylikSatisGetir()
        {
            return dao.AylikSatisGetir();
        }
        public DataTable EnCokSatanlariGetir()
        {
            return dao.EnCokSatanlariGetir();
        }

        
        public DataTable MusteriCiroGetir()
        {
            return dao.MusteriCiroGetir();
        }
    }
}