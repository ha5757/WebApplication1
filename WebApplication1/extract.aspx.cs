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
    public partial class extract : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
     

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
            adp = new SqlDataAdapter("sp_ExtractDept", con);
            if (!IsPostBack)
            {
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                adp.Fill(ds, "L");
                ddlDeptno.DataSource = ds.Tables["L"];
                ddlDeptno.DataTextField = "dname";
                ddlDeptno.DataValueField = "deptno";
                ddlDeptno.DataBind();
            }
        }

        protected void ddlDeptno_SelectedIndexChanged(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_getDeptDetails", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Deptno", ddlDeptno.SelectedValue);
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            gvData.DataSource = ds.Tables["E"];
            gvData.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}