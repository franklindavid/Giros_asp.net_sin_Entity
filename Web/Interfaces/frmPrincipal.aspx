<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPrincipal.aspx.cs" Inherits="Web.Interfaces.frmPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <h1>CORRESPONSAL</h1>
        <table style="width: 100%">
            <tr>
                <td style="width: 50%">ID:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtIdCor" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%">NOMBRE:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtNomCor" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
            </tr>
            <tr>
                <td style="width: 50%" colspan="2">
                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultarCor_Click" />
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnCrearCor_Click" />
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificarCor_Click" />
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminarCor_Click" />
                </td>
            </tr>
             <tr>
                <td style="width: 50%" colspan="2">
                  
                    <asp:Label ID="lblMensajeCor" runat="server" style="color: #FF3300; font-weight: 700"></asp:Label>
                  
                </td>
            </tr>
            <tr>
                <td style="width: 50%" colspan="2">
                    <asp:GridView ID="gvwDatos" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="No se encontraron registros">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField HeaderText="ID" DataField="COR_CORRESPONSAL_ID" />
                            <asp:BoundField HeaderText="NOMBRE" DataField="COR_NOMBRE" />
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
        <h1>OFICINA</h1>
        <%--OFICINA--%> 
        <table style="width: 100%">
            <tr>
                <td style="width: 50%">ID:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtIdOf" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%">NOMBRE:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtNomOf" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%">ID CORRESPONSAL:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtIdCorOf" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="btnConsultarOf_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Ingresar" OnClick="btnCrearOf_Click" />
                    <asp:Button ID="Button3" runat="server" Text="Modificar" OnClick="btnModificarOf_Click" />
                    <asp:Button ID="Button4" runat="server" Text="Eliminar" OnClick="btnEliminarOf_Click" />
                </td>
            </tr>
             <tr>
                <td style="width: 50%" colspan="2">
                  
                    <asp:Label ID="lblMensajeOf" runat="server" style="color: #FF3300; font-weight: 700"></asp:Label>
                  
                </td>
            </tr>
            <tr>
                <td style="width: 50%" colspan="2">
                    <asp:GridView ID="GridViewOf" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="No se encontraron registros">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField HeaderText="ID" DataField="OFI_OFICINA_ID" />
                            <asp:BoundField HeaderText="NOMBRE" DataField="OFI_NOMBRE" />
                            <asp:BoundField HeaderText="ID CORRESPONSAL" DataField="OFI_CORRESPONSAL_ID" />
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
        <h1>GIRO</h1>
         <%--GIRO--%> 
        <table style="width: 100%">
            <tr>
                <td style="width: 50%">ID:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtIdGir" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%">NOMBRE:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtNomGir" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%">ID OFICINA:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtIdOfGir" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%" colspan="2">
                    <asp:Button ID="Button5" runat="server" Text="Consultar" OnClick="btnConsultarGir_Click" />
                    <asp:Button ID="Button6" runat="server" Text="Ingresar" OnClick="btnCrearGir_Click" />
                    <asp:Button ID="Button7" runat="server" Text="Modificar" OnClick="btnModificarGir_Click" />
                    <asp:Button ID="Button8" runat="server" Text="Eliminar" OnClick="btnEliminarGir_Click" />
                </td>
            </tr>
             <tr>
                <td style="width: 50%" colspan="2">
                  
                      <asp:Label ID="lblMensajeGir" runat="server" style="color: #FF3300; font-weight: 700"></asp:Label>
                  
                </td>
            </tr>
            <tr>
                <td style="width: 50%" colspan="2">
                    <asp:GridView ID="GridViewGir" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="No se encontraron registros">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField HeaderText="ID" DataField="GIR_GIRO_ID" />
                            <asp:BoundField HeaderText="NOMBRE" DataField="GIR_RECIBO" />
                            <asp:BoundField HeaderText="ID OFICINA" DataField="GIR_OFICINA_ID" />
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
        <h1>GIROS POR OFICINA</h1>
        <table style="width: 100%">           
            <tr>
                <td style="width: 50%" colspan="2">
                    <asp:GridView ID="GridViewGirXOf" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="No se encontraron registros">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="NOMBRE DE LA OFICINA">
                                <ItemTemplate>
                                    <div class="text-center">
                                        <asp:LinkButton Font-Underline="true" ID="linkPaymentMethods" Font-Size="9.5" ClientIDMode="Static" runat="server" Text='<%#Eval("OFI_NOMBRE")%>' PostBackUrl='<%#"frmGirosOf.aspx?OFI_OFICINA_ID=" + Eval("OFI_OFICINA_ID").ToString()%>' />
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="NOMBRE DEL CORRESPONSAL" DataField="COR_NOMBRE" />
                            <asp:BoundField HeaderText="NUMERO DE GIROS" DataField="giros" />
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
