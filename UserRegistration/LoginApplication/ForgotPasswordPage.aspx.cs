using System;
using UserRegistration.BusinessLayer;
using UserRegistration.BusinessModel;

namespace LoginApplication
{
    public partial class ForgotPasswordPage : System.Web.UI.Page
    {
        protected void BtnSubmit_click(object sender, EventArgs e)
        {
            User user = new User
            {
                EmailID = txtEmailId.Text,
                Password = txtPassword.Text,
                UserName = txtUserName.Text,
                ConfirmPassword = txtConfirmPassword.Text
            };

            BALFactory fact = new BALFactory();
            IBAL Ibal = fact.GetBALAuthObject();

            string result = Ibal.UpdatePassword(user);

            Response.Write("<script>alert('" + result + "')</script>");

            //if (result.Equals(StringLiterals.successfullyUpdated))
            //{
            //    Response.Redirect("LoginPage.aspx");
            //}
        }
        protected void BtnLogin_click(object sender,EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}