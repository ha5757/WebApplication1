using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());

            if (!IsPostBack)
            {
                txtstart.Enabled = false;
                txtend.Enabled = false;
                ddldeptno.Enabled = false;
                adp = new SqlDataAdapter("sp_ExtractDept", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                adp.Fill(ds, "L");
                ddldeptno.DataSource = ds.Tables["L"];
                ddldeptno.DataTextField = "dname";
                ddldeptno.DataValueField = "deptno";
                ddldeptno.DataBind();
            }
        }

        protected void rdbhiredate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbhiredate.Checked)
            {
                txtstart.Enabled = true;
                txtend.Enabled = true;
                ddldeptno.Enabled = false;
            }
        }

        protected void rdbdeptno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbdeptno.Checked)
            {
                txtstart.Enabled = false;
                txtend.Enabled = false;
                ddldeptno.Enabled = true;
            }
        }

        protected void ddldeptno_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbdeptno.Checked)
            {
                adp = new SqlDataAdapter("sp_getDeptDetails", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Deptno", ddldeptno.SelectedValue);
                DataSet ds = new DataSet();
                adp.Fill(ds, "E");
                gvdata.DataSource = ds.Tables["E"];
                gvdata.DataBind();
            }
            else if (rdbhiredate.Checked)
            {
                adp = new SqlDataAdapter("sp_getdates", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@fd", txtstart.Text);
                adp.SelectCommand.Parameters.AddWithValue("@ld", txtend.Text);
                DataSet ds = new DataSet();
                adp.Fill(ds, "E");
                gvdata.DataSource = ds.Tables["E"];
                gvdata.DataBind();
            }
        }
    }
}