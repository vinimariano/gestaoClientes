<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NovoCliente.aspx.cs" Inherits="gestaoClientesWeb.NovoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div>  
            <table class="auto-style1">  
                <tr>  
                    <td>Nome :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>CPF</td>  
                     <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>  
                </tr> 
                <tr>  
                    <td>Tipo</td>  
                    <td>  
                        <asp:DropDownList ID="DropDownList1" runat="server">  
                            <asp:ListItem Text="Selecione o Tipo" Value="select" Selected="True"></asp:ListItem>  
                            <asp:ListItem Text="VIP" Value="1"></asp:ListItem>  
                            <asp:ListItem Text="Standard" Value="2"></asp:ListItem>  
                            <asp:ListItem Text="Gold" Value="3"></asp:ListItem>  
                        </asp:DropDownList>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Sexo</td>  
                    <td>  
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">  
                            <asp:ListItem>Masculino</asp:ListItem>  
                            <asp:ListItem>Feminino</asp:ListItem>
                            <asp:ListItem>Outro</asp:ListItem> 
                        </asp:RadioButtonList>  
                    </td>  
               </tr>
                 <tr>  
                    <td>Tipo</td>  
                    <td>  
                        <asp:DropDownList ID="DropDownList2" runat="server">  
                            <asp:ListItem Text="Selecione a Situação" Value="select" Selected="True"></asp:ListItem>  
                            <asp:ListItem Text="Adimplente" Value="1"></asp:ListItem>  
                            <asp:ListItem Text="Inadimplente" Value="2"></asp:ListItem>  
                            <asp:ListItem Text="Bloqueado" Value="3"></asp:ListItem>  
                        </asp:DropDownList>  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click" />  
                    </td>  
                </tr>  
            </table>  
        </div>  

</asp:Content>
