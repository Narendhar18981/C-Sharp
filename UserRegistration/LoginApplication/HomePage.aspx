<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="LoginApplication.LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script>alert('Login Successfull');</script>
    <form id="form1" runat="server">
        <div align="center">
            <h3>Hii their<br />Welcome</h3>
            <asp:Button ID="BtnLogout" Text="Logout" OnClick="BtnLogout_onclick" runat="server" Width="100px" />
        </div>
    </form>
</body>
</html>
