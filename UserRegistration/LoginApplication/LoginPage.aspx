<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginApplication.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            text-align: center;
            padding: 20px;
        }
        form {
            border: 2px solid #ccc;
            padding: 20px;
            display: inline-block;
        }
        label {
            display: inline-block;
            width: 120px;
            text-align: right;
            margin-right: 10px;
        }
        input[type="text"],
        input[type="password"] {
            width: 200px;
            padding: 5px;
            margin-bottom: 10px;
        }
        .button-container {
            margin-top: 20px;
        }
        #btnLogin {
            margin-left: 150px;
        }
        #linkForgetPassword{
            margin-left:275px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h1>Login Page</h1>
            <div>
                <label>UserName:</label>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="BtnRegister_click" Width="100px"></asp:Button>
                <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnSubmit_click" Width="100px"></asp:Button>
                <br />
                <asp:HyperLink ID="linkForgetPassword" runat="server" Text="Forget Password" NavigateUrl="~/ForgotPasswordPage.aspx" align="right"></asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
