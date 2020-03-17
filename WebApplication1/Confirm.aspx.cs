using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["E"] != null)
            {
                EMPDATA E = (EMPDATA)Session["E"];
                lblEmpno.Text = E.EMPNO.ToString();
                lblEname.Text = E.ENAME;
                lblJob.Text = E.JOB;
                lblHiredate.Text = E.HIREDATE.ToString();
                lblSalary.Text = E.SAL.ToString();
                lblCommission.Text = E.COMM.ToString();
                lblDeptno.Text = E.DEPTNO.ToString();
                Session.Remove("E");
            }
            else
            {
               
                Response.Redirect("login.aspx");
            }
        }
    }
}