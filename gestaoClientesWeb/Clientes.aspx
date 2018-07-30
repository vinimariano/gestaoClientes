<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="gestaoClientesWeb.Clientes" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContent">
    <h2>CLIENTES</h2>

    <br /><br />
    <a href="NovoCliente" class="btn btn-sm">Adicionar Cliente</a>

    <asp:GridView ID="GridView1" runat="server" Height="151px" Width="286px" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ButtonType="Button" HeaderText="Ações" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>

</asp:Content>
