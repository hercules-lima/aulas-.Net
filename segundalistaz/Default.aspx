<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="dolar" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="euro" />
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Converter" />
    </form>
</body>
</html>
