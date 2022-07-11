using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;

namespace YazOkulu
{
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int OgrenciID = int.Parse(Request.QueryString["OGRID"]);
            Response.Write(OgrenciID);

            EntityOgrenci entityOgrenci = new EntityOgrenci();
            entityOgrenci.OgrenciId = OgrenciID;
            BLLOgrenci.OgrenciSilBLL(entityOgrenci.OgrenciId);
            Response.Redirect("ogrenciListesi.aspx");
        }
    }
}