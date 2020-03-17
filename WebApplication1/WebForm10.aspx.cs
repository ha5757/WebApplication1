using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace WebApplication1//loginpage
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_validateLogin", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@U", txtUsername.Text);
            adp.SelectCommand.Parameters.AddWithValue("@P", txtPassword.Text);
            SqlParameter p = new SqlParameter("@C", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds, "L");
            if (p.Value.ToString() == "1")
            {
                Session["User"] = txtUsername.Text;
                Response.Redirect("addemp.aspx");
            }
            else
                lblMessage.Text = "INVALID CREDENTIALS";
            txtUsername.Focus();
        }
    }
}