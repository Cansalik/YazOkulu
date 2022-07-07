using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci entityOgrenci)
        {
            SqlCommand Com1 = new SqlCommand("insert into TBLOGRENCI (OGRAD,OGRSOYAD,OGRNUMARA,OGRMAIL,OGRSIFRE) values (@P1,@P2,@P3,@P4,@P5)",Baglanti.bgl);
            if (Com1.Connection.State != ConnectionState.Open)
            {
                Com1.Connection.Open();
            }
            Com1.Parameters.AddWithValue("@P1", entityOgrenci.Ad);
            Com1.Parameters.AddWithValue("@P1", entityOgrenci.Ogrencisoyad);
            Com1.Parameters.AddWithValue("@P1", entityOgrenci.Numara);
            Com1.Parameters.AddWithValue("@P1", entityOgrenci.Fotograf);
            Com1.Parameters.AddWithValue("@P1", entityOgrenci.Ogrencisifre);
            return Com1.ExecuteNonQuery();
        }
    }
}
