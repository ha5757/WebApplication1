using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace WebApplication1
{
    public partial class CreateApplication : System.Web.UI.Page
    {
       
      
        List<Population1> list = new List<Population1>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["P"] != null)
                list = (List<Population1>)Session["P"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            db D = new db();
         
            Population1 p = new Population1();
            
            p.ApplicationId = db.getAppid();


            p.MemberID= list.Count + 1;
            p.Firstname = txtfirstname.Text;
            p.Middlename = txtmiddlename.Text;
            p.Lastname = txtmiddlename.Text;
            p.DOB = DateTime.Parse(txtdob.Text);
            p.Suffix = ddlsuffix.Text;
            
            
            if(rdbmale.Checked)
            {
                p.Gender = "male";
            }
           else 
            {
                p.Gender = "female";
            }
            list.Add(p);
            Session["P"] = list;
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            db d = new db();
           String s= d.SaveMembers(list);
            Session.Remove("P");
            Response.Redirect("WebForm11.aspx?s=" + s);

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }
    }
}