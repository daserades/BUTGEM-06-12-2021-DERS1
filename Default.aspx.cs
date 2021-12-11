using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_Kullanici_Giris_Paneli
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kadi = TextBox1.Text;
            string sfr = TextBox2.Text;
            Response.Redirect("urunler.aspx?prm=" + kadi + "&prm1=" + sfr);
        }
    }
}