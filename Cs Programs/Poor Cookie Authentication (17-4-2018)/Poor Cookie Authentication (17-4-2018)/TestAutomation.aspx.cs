using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Poor_Cookie_Authentication__17_4_2018_
{
    public partial class TestAutomation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Method 1
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Cookie", "UserId=1");
                litResponseData1.Text = wc.DownloadString("http://localhost:60078/Authenticated.aspx");
            }

            // Method 2
            var cookieContainer = new CookieContainer();
            var req = WebRequest.CreateHttp("http://localhost:60078/Login.aspx?Username=ebrown@example.com&Password=1234");
            req.CookieContainer = cookieContainer;
            req.GetResponse(); // We don't need to do anything with the response

            req = WebRequest.CreateHttp("http://localhost:60078/Authenticated.aspx");
            req.CookieContainer = cookieContainer;
            var response = (HttpWebResponse)req.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                litResponseData2.Text = sr.ReadToEnd();
            }
        }
    }
}
