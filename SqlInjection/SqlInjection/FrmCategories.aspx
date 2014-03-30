<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCategories.aspx.cs" Inherits="SqlInjection.FrmCategories" %>
<script src="Scripts/bootstrap.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="table-hover">
    <div style="text-align: center">
        <div class="warning">
  <h1>Categorías</h1>
</div>
        <asp:GridView  ID="dgCategorias" runat="server" AutoGenerateColumns="False" CellPadding="4" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" HorizontalAlign="Center" CellSpacing="2" ForeColor="Black" Width="541px" CssClass="table">
            <Columns>
                <asp:BoundField DataField="CategoryName" HeaderText="Category Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:HyperLinkField DataNavigateUrlFields="CategoryID" DataNavigateUrlFormatString="FrmProducts.aspx?Categoria={0}" DataTextField="CategoryID" Text="Ir" >
                <ControlStyle Width="20px" />
                </asp:HyperLinkField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="Gray" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
