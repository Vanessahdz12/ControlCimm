<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro_Articulo.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.Registro_Articulo" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" />
    <style>
        .custom-container {
            border: 1px solid purple;
            box-shadow: 4px 4px 8px rgba(0, 0, 0, 0.2);
            padding: 20px;
            border-radius: 10px;
            margin-top: 50px;
        }
    </style>
    <title>Formulario ASPX</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="custom-container">
                <div class="mb-3">
                    <label for="campo1" class="form-label">Nombre del Articulo a Ingresar</label>
                    <asp:TextBox ID="txtNobre_Articulo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
      
            <div class="mb-3">
                <label for="campo2" class="form-label">Descripcion</label>
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="campo3" class="form-label">Cantidad</label>
                <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="campo4" class="form-label">Tipo de Articulo</label>
                <asp:TextBox ID="txtTìpo_Articulo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             
            <div runat="server" id="ddlArticulos">
                            <label>Seleccione el Usuario</label>
                            <asp:DropDownList ID="ddlArticulo" runat="server"
                                AppendDataBound="true"
                                Visible="True">
                            </asp:DropDownList>
                        </div>
            <div class="mb-3">
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary"  OnClick="btnEnviar_Click"/>
                </div>
            </div>
                  </div>
    

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>

</body>
</html>