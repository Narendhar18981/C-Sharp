using System;

namespace LoginApplication
{
    public partial class LandingPage : System.Web.UI.Page
    {
        protected void BtnLogout_onclick(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}