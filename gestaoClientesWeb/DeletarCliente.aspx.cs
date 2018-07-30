using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gestaoClientesWeb
{
    public partial class DeletarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["clienteid"];

            gestaoClientesService.IgestaoClientesClient api
                   = new gestaoClientesService.IgestaoClientesClient();

            gestaoClientesService.cliente cliente = api.GetCliente(int.Parse(id));

            if (!IsPostBack)
            {
                Label1.Text = cliente.nome;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            gestaoClientesService.IgestaoClientesClient api
                = new gestaoClientesService.IgestaoClientesClient();

            api.DeleteCliente(int.Parse(Request.QueryString["clienteid"]));
            Response.Redirect("Clientes.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {           
            Response.Redirect("Clientes.aspx");
        }
    }
}