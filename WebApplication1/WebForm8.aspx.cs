using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        DemoEntities d = null;
        private void bind()
        {
            d = new DemoEntities();
            var v = from o in d.vreport1
                    select o;
            FormView1.DataSource = v.ToList();
            FormView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            //Formv1.DataSource = v.ToList();
            //Formv1.DataBind();
            bind();
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FormView1.PageIndex = e.NewPageIndex;
            this.bind();
        }
    }
}