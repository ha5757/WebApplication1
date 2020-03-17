using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class VSEx1 : System.Web.UI.Page
    {
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["V"] == null)
                ViewState["V"] = 10;
            else
                ViewState["V"] = (int)ViewState["V"] + 1;
            i = 10;
            TextBox1.Text = (++i).ToString();
            TextBox2.Text = ViewState["V"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("VSEX2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}