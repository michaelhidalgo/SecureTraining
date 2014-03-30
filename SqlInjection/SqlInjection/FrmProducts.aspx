<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmProducts.aspx.cs" Inherits="SqlInjection.FrmProducts" %>
<script src="Scripts/bootstrap.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
       <div class="alert-info" style="width: 1035px">
        <asp:Label ID="Label1"  runat="server" Font-Bold="True" Font-Size="Medium" Text="lblTotalrows"></asp:Label>
           </div>
        <asp:GridView CssClass="table" ID="dgProduct" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" >
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="alert-success" NavigateUrl="FrmCategories.aspx">Volver</asp:HyperLink>
        <br />
    
    </div>
        &nbsp;</form>
</body>
</html>
