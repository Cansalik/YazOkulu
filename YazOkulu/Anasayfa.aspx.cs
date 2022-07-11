using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;


namespace YazOkulu
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnOgrenci_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                EntityOgrenci entityOgrenci = new EntityOgrenci();
                entityOgrenci.OgrenciAd = txtOgrenci_Ad.Text;
                entityOgrenci.Ogrencisoyad = txtOgrenci_Soyad.Text;
                entityOgrenci.OgrenciNumara = txtOgrenci_Numara.Text;
                entityOgrenci.Ogrencisifre = txtOgrenci_Sifre.Text;
                entityOgrenci.OgrenciFotograf = txtOgrenci_Fotograf.Text;
                BLLOgrenci.OgrenciEkleBLL(entityOgrenci);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}