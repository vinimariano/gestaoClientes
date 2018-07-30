<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="gestaoClientesWeb.EditarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div>  
            <asp:Label ID="LabelError" style="color:red" runat="server"></asp:Label>
            <table class="auto-style1">  
              <tr>  
                    <td>Id :</td>  
                    <td>  
                        <asp:Label ID="label1" runat="server"></asp:Label>  
                    </td>  
  
               </tr> 
                <tr>  
                    <td>Nome :</td>  
                    <td>  
                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" MaxLength="100" Width="240px"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>CPF</td>  
                     <td> <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" MaxLength="20"></asp:TextBox></td>  
                </tr> 
                <tr>  
                    <td>Tipo</td>  
                    <td>  
                        <asp:DropDownList  CssClass="form-control" ID="DropDownList1" runat="server">  
                            <asp:ListItem Text="VIP" Value="1" Selected="True"></asp:ListItem>  
                            <asp:ListItem Text="Standard" Value="2"></asp:ListItem>  
                            <asp:ListItem Text="Gold" Value="3"></asp:ListItem>  
                        </asp:DropDownList>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Sexo</td>  
                    <td>  
                         <asp:RadioButtonList   ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">  
                            <asp:ListItem Selected="True">Masculino</asp:ListItem>  
                            <asp:ListItem>Feminino</asp:ListItem>
                        </asp:RadioButtonList>  
                    </td>  
               </tr>
                 <tr>  
                    <td>Situação</td>  
                    <td>  
                        <asp:DropDownList CssClass="form-control" ID="DropDownList2" runat="server">  
                            <asp:ListItem Text="Adimplente" Value="1" Selected="True"></asp:ListItem>  
                            <asp:ListItem Text="Inadimplente" Value="2"></asp:ListItem>  
                            <asp:ListItem Text="Bloqueado" Value="3"></asp:ListItem>  
                        </asp:DropDownList>  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                         <asp:Button ID="Button1" CssClass="btn" runat="server" Text="Salvar" OnClick="Button1_Click" />  
                    </td> 
                   <td style="margin-top:10px">  
                        <asp:Button ID="Button2" CssClass="btn" runat="server" Text="Cancelar" OnClick="Button2_Click" />  
                    </td>  
                </tr>  
            </table>  
        </div>  

</asp:Content>
