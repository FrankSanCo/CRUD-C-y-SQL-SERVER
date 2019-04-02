<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Capa_Presentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Iniciar Sesion</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container p-4">
            <div class="row">
                <div class="col-md-4 mx-auto">
                    <div class="card text-center">
                        <div class="card-header">
                            <h1>Iniciar Sesion</h1>
                        </div>
                        <div class="card-body">
                            <div class="form-group">
                                <asp:TextBox ID="txtUser" runat="server" CssClass="form-control" placeholder="Username"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Button ID="btnIniciar" runat="server" CssClass="form-control btn btn-block btn-success" Text="Iniciar Sesion" OnClick="btnIniciar_Click"></asp:Button>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblMensaje" runat="server" CssClass="text-danger"></asp:Label>
                            </div>
                        </div>

                    </div>

                </div>

            </div>
        </div>
    </form>
    <div class="form-group text-center">
        <p>Aun no estas registrado!<a href="#"> Registrate Aqui!</a></p>
    </div>
</body>
</html>
