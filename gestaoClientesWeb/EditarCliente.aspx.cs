using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gestaoClientesWeb
{
    public partial class EditarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["clienteid"];

            gestaoClientesService.IgestaoClientesClient api
                   = new gestaoClientesService.IgestaoClientesClient();

            gestaoClientesService.cliente cliente = api.GetCliente(int.Parse(id));

            if (!IsPostBack)
            {
                label1.Text = cliente.id.ToString();
                TextBox1.Text = cliente.nome;
                TextBox2.Text = cliente.cpf;
                RadioButtonList1.SelectedValue =
                    (cliente.masculino ? "Masculino" : "Feminino");
                DropDownList1.SelectedValue = cliente.situacaoClienteId.ToString();
                DropDownList2.SelectedValue = cliente.tipoClienteId.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            gestaoClientesService.cliente cliente =
                new gestaoClientesService.cliente
                {
                    id = int.Parse(label1.Text),
                    nome = TextBox1.Text,
                    cpf = TextBox2.Text,
                    masculino =
                   RadioButtonList1.SelectedValue == "Masculino",
                    situacaoClienteId = int.Parse(DropDownList2.SelectedValue),
                    tipoClienteId = int.Parse(DropDownList1.SelectedValue)
                };

            gestaoClientesService.IgestaoClientesClient api
                = new gestaoClientesService.IgestaoClientesClient();

            try
            {
                api.UpdateCliente(cliente);
                Response.Redirect("Clientes.aspx");
            }
            catch (Exception ex)
            {
                LabelError.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Clientes.aspx");
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}