using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class delete : System.Web.UI.Page
    {
        DemoEntities d = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DemoEntities();
        }

        protected void txtempno_TextChanged(object sender, EventArgs e)
        {

            int eno = int.Parse(txtempno.Text);
            var E = from E1 in d.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            string hd = DateTime.Parse(emp.HIREDATE.ToString()).ToString("yyyy-MM-dd");
            txtename.Text = emp.ENAME;
            txtjob.Text = emp.JOB;
            txtmgr.Text = emp.MGR.ToString();
            txtsal.Text = emp.SAL.ToString();
            txthiredate.Text = hd;
            txtcomm.Text = emp.COMM.ToString();
            txtdeptno.Text = emp.DEPTNO.ToString();
        }

        protected void txtbutton_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtempno.Text);
            var E = from E1 in d.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            d.EMPDATAs.Remove(emp);

            d.SaveChanges();
        }
    }
}