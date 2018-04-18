using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Poor_Cookie_Authentication__17_4_2018_
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserId"]?.Value == null)
            {
                lbLogout.Visible = false;
            }
            else
            {
                hlLogin.Visible = false;
            }
        }

        protected void lbLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["UserId"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Default.aspx");
        }
    }
}