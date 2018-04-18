using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Poor_Cookie_Authentication__17_4_2018_
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Username"] != null && Request.QueryString["Password"] != null)
            {
                var username = Request.QueryString["Username"];
                var password = Request.QueryString["Password"];
                doLogin(username, password);
            }

            if (Request.Cookies["UserId"]?.Value != null)
            {
                Response.Redirect("Authenticated.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            doLogin(username, password);
        }

        private void doLogin(string username, string password)
        {
            var user = Models.User.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user != null)
            {
                Response.Cookies.Add(new HttpCookie("UserId", Models.User.Users.ToList().IndexOf(user).ToString()) { Expires = DateTime.Now.AddHours(8) });
                Response.Redirect("Authenticated.aspx");
            }

            litError.Text = "The username/password combination you entered does not exist.";
        }
    }
}