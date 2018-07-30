<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="gestaoClientesWeb.Clientes" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContent">
    <h2>CLIENTES</h2>

    <br /><br />
    <a href="NovoCliente" class="btn btn-primary active">Adicionar Cliente</a>
     <br /><br />
    <asp:GridView ID="GridView1" runat="server" Height="151px" Width="286px" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="nome" HeaderText="Nome" ReadOnly="True" SortExpression="nome" />
            <asp:BoundField DataField="cpf" HeaderText="CPF" ReadOnly="True" SortExpression="cpf" />
            <asp:BoundField DataField="sexo" HeaderText="Sexo" ReadOnly="True" SortExpression="sexo" />
            <asp:BoundField DataField="tipo" HeaderText="Tipo" ReadOnly="True" SortExpression="tipo" />
            <asp:BoundField DataField="situacao" HeaderText="Situação" ReadOnly="True" SortExpression="situacao" />
            <asp:CommandField ButtonType="Button" HeaderText="Ações" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" >
            <ControlStyle CssClass="btn btn-default" />
            </asp:CommandField>
        </Columns>
    </asp:GridView>

</asp:Content>
