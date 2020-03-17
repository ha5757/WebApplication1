using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MyMaster1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.Cookies["username"]==null) 
            //    Response.Redirect("login.aspx");
            //else
            //    Label1.Text = "WELCOME" + Request.Cookies["username"].Value;
            String S = Path.GetFileName(Request.Path);
            if (S != "WebForm10.aspx")
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("WebForm10.aspx");
                }
                else
                {
                    Label1.Text = "welcome" + Session["user"].ToString();
                }
            }
        }

      

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //if (Request.Cookies["username"] != null)
            //{
            //    HttpCookie acookie = HttpContext.Current.Request.Cookies["username"];
            //    acookie.Expires = DateTime.Now.AddDays(-1d);
            //    Response.Cookies.Add(acookie); 
            //   // Response.Cookies.Clear();
            //    Response.Redirect("login.aspx");
            //}
            if (Session["E"] != null)
            {
                Session.Abandon();
                Response.Redirect("login.aspx");
            }
        }
    }
}