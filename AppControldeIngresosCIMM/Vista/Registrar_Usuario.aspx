<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar_Usuario.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.Registrar_Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Formulario de Registro</title>
    <style>
        body {
            background-image: url('https://th.bing.com/th/id/OIP.6cJkSCCsCVrafNq50AVwTQHaFn?pid=ImgDet&w=980&h=744&rs=1');
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }

        .container {
            background-color: rgba(255, 255, 255, 0.8);
            padding: 20px;
            border-radius: 10px;
            width: 80%;
            max-width: 500px;
        }

        .form-label {
            margin-top: 10px;
        }

        .submit-btn {
            margin-top: 20px;
        }
    </style>
</head>
<body>
            <form runat="server">
    <div class="container">
        <h2 class="mb-4">Formulario de Registro</h2>
 <div class="form-group">
                <asp:Label ID="Label1" runat="server" CssClass="form-label" Text="Documento"></asp:Label>
                <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div class="form-group">
                <asp:Label ID="Label2" runat="server" CssClass="form-label" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" CssClass="form-label" Text="Apellido"></asp:Label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" CssClass="form-label" Text="Correo"></asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" CssClass="form-label" Text="Clave"></asp:Label>
                <asp:TextBox ID="txtClave" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" CssClass="form-label" Text="Telefono"></asp:Label>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <!-- Repite la estructura para los otros campos -->

            <div class="form-check">
                <asp:Label ID="Label8" runat="server" CssClass="form-label" Text="Guarda Seguridad"></asp:Label>
                <asp:RadioButton ID="RadioButton2" runat="server" CssClass="form-check-input" GroupName="roleGroup" />
            </div>
            <br />
            <div class="form-check">
                <asp:Label ID="Label9" runat="server" CssClass="form-label" Text="Coordinador"></asp:Label>
                <asp:RadioButton ID="RadioButton1" runat="server" CssClass="form-check-input" GroupName="roleGroup" />
            </div>


            <!-- Repite la estructura para el otro checkbox -->
            <br />
            <asp:Button ID="btnRegiostrar" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btnRegiostrar_Click" />

      
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
        </form>
  
</body>
</html>
