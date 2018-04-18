<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authenticated.aspx.cs" Inherits="Poor_Cookie_Authentication__17_4_2018_.Authenticated" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello <asp:Literal runat="server" ID="litUserName"></asp:Literal>!
        </div>
        <div>
            This page is only available to authenticated users.
        </div>
    </form>
</body>
</html>
