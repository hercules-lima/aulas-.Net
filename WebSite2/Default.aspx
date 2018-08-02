<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script  runat="server">  protected void Button1_Click(object sender, EventArgs e)
    {
            Response.Write("locura");

    }
      

    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
