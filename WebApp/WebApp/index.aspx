<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="dashboard" runat="server" OnClick="Button1_Click" Text="Ver DashBoard" />
        <br />
        <br />
        <asp:Button ID="adminMensajes" runat="server" Text="Administrar Mensajes" />
        <br />
        <br />
        <asp:Button ID="Reportes" runat="server" Text="Ver Reportes" />
    
    </div>
    </form>
</body>
</html>
