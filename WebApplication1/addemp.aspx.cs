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
    public partial class addemp : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
            Response.Write(Session["user"].ToString());

           
        }

        protected void txtbutton_Click(object sender, EventArgs e)
        {

            adp = new SqlDataAdapter("sp_insertprocedure", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno",int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@ename", txtename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@job", txtjob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@mgr", int.Parse(txtmgr.Text));
            adp.SelectCommand.Parameters.AddWithValue("@hiredate",DateTime.Parse(txthiredate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@sal", int.Parse(txtsal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@comm",int.Parse(txtcomm.Text));
            adp.SelectCommand.Parameters.AddWithValue("@deptno",int.Parse(txtdeptno.Text));
            SqlParameter p = new SqlParameter("@result", SqlDbType.NVarChar,25);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds, "L");
             
                lblMessage.Text =p.Value.ToString();
            txtempno.Text = "";
            txtename.Text = "";
            txtjob.Text = "";
            txtsal.Text = "";
            txtmgr.Text = "";
            txthiredate.Text = "";
            txtcomm.Text = "";
            txtdeptno.Text = "";


            
        }
    }
}