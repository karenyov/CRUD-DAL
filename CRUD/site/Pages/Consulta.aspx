<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
</head>
<body>
    <script src="../Scripts/jquery-1.9.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Consulta de Pessoas</h3>
                    <asp:GridView ID="gridClientes" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#ccffcc">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="Código" />
                            <asp:BoundField DataField="nome" HeaderText="Nome" />
                            <asp:BoundField DataField="endereco" HeaderText="Endereço" />
                            <asp:BoundField DataField="email" HeaderText="Email" />
                        </Columns>
                        <RowStyle CssClass="cursor-pointer" />
                    </asp:GridView>

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                    <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
