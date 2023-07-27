<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPasswordPage.aspx.cs" Inherits="LoginApplication.ForgotPasswordPage" %>

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
            width: 160px;
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h1>Forgot Password</h1>
            <br />
            <div>
                <label>Enter UserName:</label>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Enter EmailId:</label>
                <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Enter Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <label>Confirm Password:</label>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="button-container">
                <asp:Button ID="BtnLogin" Text="Login" runat="server" Width="100px" OnClick="BtnLogin_click" />
                <asp:Button ID="BtnSubmit" Text="Submit" runat="server" Width="100px" OnClick="BtnSubmit_click" />
            </div>
        </div>
    </form>
</body>
</html>
