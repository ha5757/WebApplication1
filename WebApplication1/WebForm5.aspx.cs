using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new DemoEntities();
        }

        protected void txtbutton_Click(object sender, EventArgs e)
        {
            try
            {
                EMPDATA E = new EMPDATA();
                E.EMPNO = int.Parse(txtempno.Text);
                E.ENAME = txtename.Text;
                E.JOB = txtjob.Text;
                E.MGR = int.Parse(txtmgr.Text);
                E.HIREDATE = DateTime.Parse(txthiredate.Text);
                E.SAL = int.Parse(txtsal.Text);
                E.COMM = int.Parse(txtcomm.Text);
                E.DEPTNO = int.Parse(txtdeptno.Text);
                D.EMPDATAs.Add(E);
                D.SaveChanges();
            }
            catch(DbUpdateException E)
            {
                SqlException ex = E.GetBaseException() as SqlException;
                if (ex.Message.Contains("EMP_K"))
                    lblMessage.Text = "no duplicate errors";
                else if (ex.Message.Contains("FK__EmpDept"))
                    lblMessage.Text = "no deptno";
                else
                lblMessage.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtempno.Text);
            String en = txtename.Text;
            String j = txtjob.Text;
            int m = int.Parse(txtmgr.Text);
            DateTime d = DateTime.Parse(txthiredate.Text);
            int s = int.Parse(txtsal.Text);
            int c = int.Parse(txtcomm.Text);
            int dt = int.Parse(txtdeptno.Text);
            ObjectParameter ob = new ObjectParameter("result", typeof(string));
            D.sp_insertprocedure(eno, en, j, m, d, s, c, dt, ob);
            lblMessage.Text = ob.Value.ToString();
        }
    }
}