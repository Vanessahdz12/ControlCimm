<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Site1.Master" AutoEventWireup="true" CodeBehind="RecuperarContraseñaa.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.RecuperarContraseñaa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/Estilos_recuperaContraseña.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <div class="logo-container">
            Recuperar Contraseña
        </div>

        <div class="form">
            <div class="form-group">
                <label for="email">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="input" placeholder="Ingrese su corre" required=""></asp:TextBox>
            </div>

            <button id="btnEnviar" runat="server" name="enviar" class="form-submit-btn" type="submit" onserverclick="btnEnviar_ServerClick">Recuperar</button>
        </div>
    </div>
</asp:Content>
