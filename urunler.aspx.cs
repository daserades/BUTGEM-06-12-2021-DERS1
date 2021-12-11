using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_Kullanici_Giris_Paneli
{
    public partial class urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string prm, prm1;
            prm = Request.QueryString[0];
            prm1 = Request.QueryString[1];
            if ((prm=="butgem")&&(prm1=="1234"))
            {
                Response.Write("Hoşgeldiniz");
            }
            else
            {
                Response.Write("Kullanıcı adı veya şifre hatalı");
            }
        }
    }
}