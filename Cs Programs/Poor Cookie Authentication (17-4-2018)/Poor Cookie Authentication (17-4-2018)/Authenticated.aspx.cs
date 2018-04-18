using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Poor_Cookie_Authentication__17_4_2018_
{
    public partial class Authenticated : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserId"]?.Value == null)
            {
                Response.Redirect("Login.aspx");
            }

            var userId = int.Parse(Request.Cookies["UserId"].Value);
            var user = Models.User.Users[userId];
            litUserName.Text = user.Username;
        }
    }
}
