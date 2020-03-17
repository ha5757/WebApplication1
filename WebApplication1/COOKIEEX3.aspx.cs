using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class COOKIEEX3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string s = Request.Cookies["user"].Value;
                string s1 = Request.Cookies["user1"].Value;
                Response.Write(s + "" +s1);

            }
            catch(NullReferenceException E)
            {
                Response.Redirect("COOKIEEX1.aspx");
            }
        }
    }
}