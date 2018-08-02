<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p style="width: 169px; margin-left: 120px">
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <div style="width: 181px; margin-left: 120px">
            <asp:Label ID="Label2" runat="server" Text="Telefone"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <p style="width: 162px; margin-left: 120px">
            <asp:Label ID="Label3" runat="server" Text="email"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <div style="margin-left: 120px">
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </div>
        <div style="margin-left: 120px">
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </div>
        <div style="margin-left: 120px">
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
