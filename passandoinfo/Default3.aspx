<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" PostBackUrl="Default4.aspx" />
    
    </div>
    </form>
</body>
</html>
