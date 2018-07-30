<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeletarCliente.aspx.cs" Inherits="gestaoClientesWeb.DeletarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div>  
            <p>Tem certeza que deseja deletar o cliente <asp:Label ID="Label1" runat="server"></asp:Label>? </p>
            <table class="auto-style1">                
                <tr>  
                    <td>  
                        <asp:Button ID="Button1" runat="server" Text="Deletar" OnClick="Button1_Click" />  
                        <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
                    </td>  
                </tr>  
            </table>  
        </div>  

</asp:Content>
