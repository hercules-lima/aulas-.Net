<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manutenção laboratório</title>
    <style type="text/css">
        #form1 {
            height: 500px;
            width: 1002px;
            background-color:azure;
        }
    </style>
</head>
<body style="height: 499px; width: 722px">
    <form id="form1" runat="server">

    
        <asp:Label ID="Label4" runat="server" Text="Equipamentos" Font-Size="X-Large" ForeColor="#00CCFF"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" BorderColor="#66CCFF" BorderStyle="Solid"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox2" runat="server" BorderColor="#66CCFF" BorderStyle="Solid"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;
      
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Adicionar" BackColor="#99FFCC" BorderColor="#33CCCC" BorderStyle="Solid" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Atualizar" BackColor="#99FFCC" BorderColor="#33CCCC" BorderStyle="Solid" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Deletar" BackColor="#99FFCC" BorderColor="#33CCCC" BorderStyle="Solid" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Buscar" Width="62px" BackColor="#99FFCC" BorderColor="#33CCCC" BorderStyle="Solid" />
       
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelERRO" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
&nbsp;<asp:Label ID="Label10" runat="server" Text="Manutenção" Font-Size="X-Large" ForeColor="#00CCFF"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label11" runat="server" Text="Codigo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" BorderColor="#66CCFF" BorderStyle="Solid"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:Label ID="Label12" runat="server" Text="Equpamento"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server" BorderColor="#66CCFF" BorderStyle="Solid"></asp:TextBox>
&nbsp;<asp:Label ID="Label17" runat="server" Font-Size="Smaller" Text="CODIGO"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;<asp:Label ID="Label13" runat="server" Text="Data"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox9" runat="server" BorderColor="#66CCFF" BorderStyle="Solid"></asp:TextBox>
&nbsp;<asp:Label ID="Label18" runat="server" Font-Size="Smaller" Text="ANO-MES-DIA"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label14" runat="server" Text="Estado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox10" runat="server" BorderColor="#66CCFF" BorderStyle="Solid"></asp:TextBox>
&nbsp;<asp:Label ID="Label16" runat="server" Font-Size="Smaller" Text="0 FINALIZADO, 1 EM MANUTENÇÃO"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label15" runat="server" Text="Anotações"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox11" runat="server" BorderColor="#66CCFF" BorderStyle="Solid"></asp:TextBox>
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click1" Text="Adicionar" Width="82px" BackColor="#99FFCC" BorderColor="#33CCCC" BorderStyle="Solid" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Atualizar" BackColor="#99FFCC" BorderColor="#33CCCC" BorderStyle="Solid" />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Deletar" BackColor="#99FFCC" BorderColor="#33CCCC" BorderStyle="Solid" />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Buscar" BackColor="#99FFCC" BorderColor="#33CCCC" BorderStyle="Solid" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="LabelERRO2" runat="server" ForeColor="Red"></asp:Label>
        <br />
       
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" Text="Desenvolvedores: Lucas José da Silva, Diego Barbosa Pereira, Jonathan Marques Barbosa"></asp:Label>
       
    </form>
</body>
</html>
