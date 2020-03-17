using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class COOKIEEX1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length!=0)
            {
                //create cookie variable
                Response.Cookies["User"].Value = TextBox1.Text;
                //second type
                HttpCookie H = new HttpCookie("user1");
                H.Value = TextBox1.Text;
                Response.Cookies.Add(H);


                Response.Cookies["User"].Expires = DateTime.Now.AddSeconds(10);
                Response.Redirect("COOKIEEX2.aspx");
            }
        }
    }
}