<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 846px;
        }
    </style>
</head>
<body ) style="background-color:blueviolet">
    <form id="form1" runat="server">
        <p style="padding: inherit; width: 1333px; height: 1316px; margin-left: 0px; font-family: 'Arial Black'; font-size: x-small; margin-top: auto; background-repeat: repeat-y; background-attachment: inherit;">
            <asp:Label ID="Label1" runat="server" Text="Login:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 1px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" BackColor="#6600CC" ForeColor="#9900FF" Width="87px" />
        </p>
    </form>
</body>
</html>
