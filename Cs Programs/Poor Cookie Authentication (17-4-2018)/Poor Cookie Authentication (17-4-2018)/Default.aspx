<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Poor_Cookie_Authentication__17_4_2018_.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink runat="server" ID="hlLogin" Text="Login" NavigateUrl="~/Login.aspx"></asp:HyperLink>
            <asp:LinkButton runat="server" ID="lbLogout" Text="Logout" OnClick="lbLogout_Click"></asp:LinkButton>
        </div>
    </form>
</body>
</html>
