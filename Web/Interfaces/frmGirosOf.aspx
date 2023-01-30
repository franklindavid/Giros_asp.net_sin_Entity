<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGirosOf.aspx.cs" Inherits="Web.Interfaces.frmGirosOf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>GIROS OFICINA</h1>
        <table style="width: 100%">   
             <tr>
                <td style="width: 50%" colspan="2">
                  
                      <asp:Label ID="lblMensajeGir" runat="server" style="color: #FF3300; font-weight: 700"></asp:Label>
                  
                </td>
            </tr>
            <tr>
                <td style="width: 50%" colspan="2">
                    <asp:GridView ID="GridViewGirXOf" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="No se encontraron registros"  OnRowDataBound="OnRowDataBound">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField HeaderText="OFICINA" DataField="OFI_NOMBRE" />
                            <asp:BoundField HeaderText="GIR_GIRO_ID" DataField="GIR_GIRO_ID" />
                            <asp:BoundField HeaderText="GIR_RECIBO" DataField="GIR_RECIBO" />
                            <asp:BoundField HeaderText="SUMA DE LOS DIGITOS DEL CAMPO GIR_GIRO_ID" DataField="GIR_GIRO_ID" />
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
