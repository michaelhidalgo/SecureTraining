<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Function.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator
             ID="RegEx" runat="server"
             ErrorMessage="Email not valid" 
             ControlToValidate="TextBox1"
            ValidationExpression="^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$" EnableClientScript="False" Font-Bold="True" ForeColor="Red"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="btnSearch" runat="server" Text="Buscar correos"  CausesValidation="False" OnClick="btnSearch_Click"/>
        <br />
        <asp:Label ID="lblRsults" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="..."></asp:Label>
    </div>
    </form>
</body>
</html>
