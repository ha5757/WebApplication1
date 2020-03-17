using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
   
    public partial class WebForm6 : System.Web.UI.Page
    {
        DemoEntities d = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DemoEntities();
            if (!IsPostBack)
            {
                txtstart.Enabled = false;
                txtend.Enabled = false;
                ddldeptno.Enabled = false;
                var h = from e1 in d.DEPTDATAs
                        select e1;
                List<DEPTDATA> i = h.ToList();
                ddldeptno.DataSource =i;
                ddldeptno.DataTextField = "dname";
                ddldeptno.DataValueField = "deptno";
                ddldeptno.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbdeptno.Checked)
            {
                int dno = int.Parse(ddldeptno.SelectedValue);
                var E = from E1 in d.EMPDATAs
                        where E1.DEPTNO == dno
                        select E1;
                List<EMPDATA> f = E.ToList();
                gvdata.DataSource = f;
                gvdata.DataBind();
            }
            else if (rdbhiredate.Checked)
            {
                DateTime d1 = DateTime.Parse(txtstart.Text);
                DateTime d2 = DateTime.Parse(txtend.Text);
                var E = from E1 in d.EMPDATAs
                        where E1.HIREDATE >= d1 && E1.HIREDATE <= d2
                        select E1;
                List<EMPDATA> f2 = E.ToList();
                gvdata.DataSource = f2;
                gvdata.DataBind();

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
    }
}