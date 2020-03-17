using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class COOKIEEX2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //fetch the data from cookies
            string s = Request.Cookies["user"].Value;
            string s1 = Request.Cookies["user1"].Value;
            Response.Write(s + "" + s1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("COOKIEEX3.aspx");
        }
    }
}