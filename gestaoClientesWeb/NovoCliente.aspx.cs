using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gestaoClientesWeb
{
    public partial class NovoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            gestaoClientesService.cliente cliente =
                new gestaoClientesService.cliente
                {
                    nome = TextBox1.Text,
                    cpf = TextBox2.Text,
                    masculino =
                   RadioButtonList1.SelectedValue == "Masculino",
                    situacaoCliente = int.Parse(DropDownList1.SelectedValue),
                    tipoCliente = int.Parse(DropDownList2.SelectedValue)
                };

            gestaoClientesService.IgestaoClientesClient api
                = new gestaoClientesService.IgestaoClientesClient();

            api.CreateCliente(cliente);
            Response.Redirect("Clientes.aspx");
        }


        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}