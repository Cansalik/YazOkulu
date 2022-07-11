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
    public partial class ogrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> entityOgrencis = BLLOgrenci.BLLListele();
            Repeater1.DataSource = entityOgrencis;
            Repeater1.DataBind();
        }
    }
}