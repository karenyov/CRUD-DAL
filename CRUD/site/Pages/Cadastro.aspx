<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
</head>
<body>
    <script src="../Scripts/jquery-1.9.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Cadastro de Cliente</h3>
                    <br />
                    Nome do Cliente:
                    <br />
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Por favor, difite o seu nome." ForeColor="Red" />
                    <br />
                    <br />
                    Endereço do Cliente:
                    <br />
                    <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residencial" Width="50%" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="requiredEndereco" runat="server" ControlToValidate="txtEndereco" ErrorMessage="Por favor, difite o seu endereço." ForeColor="Red" />
                    <br />
                    <br />
                    Email do Cliente:
                    <br />
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email Válido" Width="25%" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Por favor, difite o seu email." ForeColor="Red" />
                    <br />
                    <br />

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                    <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" OnClick="btnCadastrarCliente" />
                    <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
