<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Poor_Cookie_Authentication__17_4_2018_.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal runat="server" ID="litError"></asp:Literal><br />
            Username: <asp:TextBox runat="server" ID="txtUsername" TextMode="Email"></asp:TextBox><br />
            Password: <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox><br />
            <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
