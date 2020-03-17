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
    public partial class SearchApplication : System.Web.UI.Page
    {
        static SqlConnection con = null;
        static SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
            if (!IsPostBack)
                LoadGridData();
        }
        private void LoadGridData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from PopulationCensus where Firstname=@fn or Lastname=@ln or Dob=@dob or ApplicationID=@appid", con);
            if (TextBox1.Text != null)
                adp.SelectCommand.Parameters.AddWithValue("@fn", TextBox1.Text);
            else
                adp.SelectCommand.Parameters.AddWithValue("@fn", string.Empty);
            if (TextBox2.Text != null)
                adp.SelectCommand.Parameters.AddWithValue("@ln", TextBox2.Text);
            else
                adp.SelectCommand.Parameters.AddWithValue("@ln", string.Empty);
            if (TextBox3.Text != null)
                adp.SelectCommand.Parameters.AddWithValue("@dob", TextBox3.Text);
            else
                adp.SelectCommand.Parameters.AddWithValue("@dob", string.Empty);
            if (TextBox4.Text != null)
                adp.SelectCommand.Parameters.AddWithValue("@appid", TextBox4.Text);
            else
                adp.SelectCommand.Parameters.AddWithValue("@appid", string.Empty);
            DataSet ds = new DataSet();
            adp.Fill(ds, "P");
            GridView1.DataSource = ds.Tables["P"];
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            LoadGridData();
            //string str = null;
            //str = "select *from Populationcensus";
            //if (TextBox1.Text.Length != 0)
            //    str = str + "where Firstname like" + TextBox1.Text + "";
            //else if (TextBox4.Text.Length != 0)
            //    str = str + "where Applicationid=" + int.Parse(TextBox4.Text);
            //cmd = new SqlCommand(str, con);
            //GridView1.DataSource =str;
            //GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadGridData();
        }
    }
}