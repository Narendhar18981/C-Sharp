using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using UserRegistration.BusinessModel;
using UserRegistration.BusinessLayer;
using System.Net.Security;

namespace LoginApplication
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void BtnSubmit_click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };

            BALFactory fact = new BALFactory();
            IBAL Ibal = fact.GetBALAuthObject();
            string result = Ibal.Login(user);

            if (result.Equals(StringLiterals.loginSuccess))
            {
                Response.Redirect("HomePage.aspx");
            }
            Response.Write("<script>alert('" + result + "');</script>");

        }
        protected void BtnRegister_click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrationPage.aspx");
        }
    }
}