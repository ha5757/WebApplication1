using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class QSEX2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string S = Request.QueryString["A"];
            string S1 = Request.QueryString["B"];
            string S2 = Request.QueryString["C"];
            Response.Write(S + " " + S1+" "+S2);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("QSEX3.aspx");
        }
    }
}