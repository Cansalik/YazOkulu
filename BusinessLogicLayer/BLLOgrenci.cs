using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci entityOgrenci)
        {
            if (entityOgrenci.OgrenciAd != null && entityOgrenci.Ogrencisoyad != null && entityOgrenci.OgrenciNumara != null && entityOgrenci.Ogrencisifre != null && entityOgrenci.OgrenciFotograf != null)
            {
                return DALOgrenci.OgrenciEkle(entityOgrenci);
            }
            return -1;
        }
        public static List<EntityOgrenci> BLLListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int OgrID)
        {
            if (OgrID != null)
            {
                return DALOgrenci.OgrenciSil(OgrID);
            }
            return false;
        }
    }
}
