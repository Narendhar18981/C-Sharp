using System;
using UserRegistration.BusinessLayer;
using UserRegistration.BusinessModel;

namespace LoginApplication
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        protected void BtnRegister_click(object sender, EventArgs e)
        {
            User user = new User
            {
                EmailID = txtEmailId.Text,
                Name = txtName.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                ConfirmPassword = txtRePassword.Text
            };

            BALFactory fact = new BALFactory();
            IBAL Ibal = fact.GetBALAuthObject();

            string result=Ibal.Register(user);

            Response.Write("<script>alert('"+result+"')</script>");
            
            if (result.Equals(StringLiterals.successfull))
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
        protected void BtnLogin_click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}