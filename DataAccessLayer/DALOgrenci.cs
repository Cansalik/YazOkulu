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
            SqlCommand Com1 = new SqlCommand("insert into TBLOGRENCI (OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTO,OGRSIFRE) values (@P1,@P2,@P3,@P4,@P5)",Baglanti.bgl);
            if (Com1.Connection.State != ConnectionState.Open)
            {
                Com1.Connection.Open();
            }
            Com1.Parameters.AddWithValue("@P1", entityOgrenci.OgrenciAd);
            Com1.Parameters.AddWithValue("@P2", entityOgrenci.Ogrencisoyad);
            Com1.Parameters.AddWithValue("@P3", entityOgrenci.OgrenciNumara);
            Com1.Parameters.AddWithValue("@P4", entityOgrenci.OgrenciFotograf);
            Com1.Parameters.AddWithValue("@P5", entityOgrenci.Ogrencisifre);
            return Com1.ExecuteNonQuery();
        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> entities = new List<EntityOgrenci>();
            SqlCommand command = new SqlCommand("select * from TBLOGRENCI", Baglanti.bgl);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader Dr = command.ExecuteReader();
            while (Dr.Read())
            {
                EntityOgrenci entityOgrenci = new EntityOgrenci();
                entityOgrenci.OgrenciId = int.Parse(Dr["OGRID"].ToString());
                entityOgrenci.OgrenciAd =Dr["OGRAD"].ToString();
                entityOgrenci.Ogrencisoyad = Dr["OGRSOYAD"].ToString();
                entityOgrenci.OgrenciNumara = Dr["OGRNUMARA"].ToString();
                entityOgrenci.OgrenciFotograf = Dr["OGRFOTO"].ToString();
                entityOgrenci.Ogrencisifre = Dr["OGRSIFRE"].ToString();
                entityOgrenci.OgrenciBakiye = double.Parse(Dr["OGRBAKIYE"].ToString());
                entities.Add(entityOgrenci);
            }
            Dr.Close();
            return entities;
        }

        public static bool OgrenciSil(int OgrenciID)
        {
            SqlCommand command = new SqlCommand("delete from TBLOGRENCI where OGRID = @P1",Baglanti.bgl);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", OgrenciID);
            return command.ExecuteNonQuery() > 0;
        }

    }
}
