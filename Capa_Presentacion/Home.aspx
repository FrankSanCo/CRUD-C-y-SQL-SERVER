<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Capa_Presentacion.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Bienvenido</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

</head>
<body>
    <form id="form1" runat="server">
        
        <div class="container p-4">
            <div class="row">
                <div class="col-md-10">
                    <div class="card text-center">
                        <div class="card-header">
                            <h1>Productos</h1>
                        </div>
                        <div class="card-body">
                            <div class="form-group">
                                <asp:TextBox ID="txtIdProducto" runat="server" placeholder="ID Producto" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtNombreProducto" runat="server" placeholder="Nombre Producto" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtPrecio" runat="server" placeholder="Precio Producto" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtEstado" runat="server" placeholder="Estado" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-secondary" OnClick="btnBuscar_Click"></asp:Button>
                                <asp:Button ID="btnCrear" runat="server" Text="Crear" CssClass="btn btn-success" OnClick="btnCrear_Click"></asp:Button>
                                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-primary"></asp:Button>
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger"></asp:Button>

                            </div>
                            <hr />
                            <asp:Label ID="lblMensaje" runat="server" CssClass="text-danger"></asp:Label>
                            <hr />
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField  HeaderText="ID Producto" DataField="IdProducto"/>
                                    <asp:BoundField  HeaderText="Nombre" DataField="NomProducto"/>
                                    <asp:BoundField  HeaderText="Precio" DataField="Precio"/>
                                     <asp:BoundField  HeaderText="Estado" DataField="Estado"/>

                                                    
                                </Columns>
                                <FooterStyle BackColor="#CCCC99" />
                                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                <RowStyle BackColor="#F7F7DE" />
                                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                                <SortedAscendingHeaderStyle BackColor="#848384" />
                                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                                <SortedDescendingHeaderStyle BackColor="#575357" />
                            </asp:GridView>
                        </div>

                    </div>
                </div>

            </div>
        </div>

    </form>
</body>
</html>
