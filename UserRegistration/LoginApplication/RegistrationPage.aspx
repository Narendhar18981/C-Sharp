<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="LoginApplication.RegistrationPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style >
         body {
            text-align: center;
            padding: 20px;
            background-color: #f2f2f2;
        }
        form {
            border: 2px solid #ccc;
            padding: 20px;
            display: inline-block;
            background-color: #ffffff;
        }
        label {
            display: inline-block;
            width: 150px;
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
            margin-left: 40px;
        }
        #btnLogin {
            background-color: #007bff;
            color: #fff;
        }
        #btnRegister {
            background-color: #28a745;
            color: #fff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Registration Page</h1>

        <div >
            <label>Email Id:</label>
            <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>UserName:</label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <label>ReEnter Password:</label>
            <asp:TextBox ID="txtRePassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        
        <div class="button-container">
            <asp:Button ID="BtnLogin" Text="Login" OnClick="BtnLogin_click" runat="server" Width="100px" />
            <asp:Button ID="BtnRegister" Text="Register" OnClick="BtnRegister_click" runat="server" Width="100px" />
        </div>
    </form>
</body>
</html>
