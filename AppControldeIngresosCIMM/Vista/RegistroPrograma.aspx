<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Site1.Master" AutoEventWireup="true" CodeBehind="RegistroPrograma.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.RegistroPrograma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Formulario de Registro</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        body {
            background-image: url('https://th.bing.com/th/id/OIP.Oq60RR_s8gdgEZOBR6xT5wHaGA?pid=ImgDet&rs=1');
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
           /* display: flex;*/
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
    <div class="container">
        <h2 class="mb-4">Formulario de Registro</h2>
        <div runat="server">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" CssClass="form-label" Text="Nombre Programa"></asp:Label>
                <asp:TextBox ID="TxtPrograma" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div class="form-group">
                <asp:Label ID="Label2" runat="server" CssClass="form-label" Text="Ficha"></asp:Label>
                <asp:TextBox ID="txtFicha" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" CssClass="form-label" Text="Descripcion"></asp:Label><br />
                <textarea id="txtDescripcion" runat="server" cols="58" rows="4"></textarea>
            </div>
            <br />
            <!-- Repite la estructura para el otro checkbox -->

            <button id="BtnRegistrar" runat="server" type="submit" class="btn btn-primary submit-btn" onserverclick="BtnRegistrar_ServerClick" >Registrar</button>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>
