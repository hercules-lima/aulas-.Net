<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 261px;
            width: 742px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
  
    
        <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="Fileira:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
     
            <asp:Label ID="Label3" runat="server" Text="Poltrona:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
      
        <div style="margin-left: 40px">
            <asp:Button ID="Button1" runat="server" Text="Comprar" Width="123px" PostBackUrl="~/Default2.aspx" />
        </div>
      
    </form>
</body>
</html>
