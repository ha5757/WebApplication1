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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select *from Empdata", con);
            DataSet Ds = new DataSet();
            adp.Fill(Ds, "E");
            DataRow R = Ds.Tables["E"].NewRow();
            R[0] = int.Parse(txtemployeeno.Text);
            R[1] = txtemployeename.Text;
            R[2] = txtjob.Text;
            R[3] = txtmanagerid.Text;
            R[4] = DateTime.Parse(txthiredate.Text);
            R[5] = int.Parse(txtsal.Text);
            R[6] = int.Parse(txtcommission.Text);
            R[7] = int.Parse(txtdeptno.Text);
            Ds.Tables["E"].Rows.Add(R);
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            adp.InsertCommand = cmb.GetInsertCommand();
            adp.Update(Ds, "E");
            Response.Write("<script>alert('1 row inserted')</script>");
        }
    }
}