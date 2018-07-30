using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gestaoClientesWeb
{
    public partial class Clientes : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            gestaoClientesService.IgestaoClientesClient api
                = new gestaoClientesService.IgestaoClientesClient();

            List<gestaoClientesService.cliente> clienteList
                = api.ListCliente().ToList();

            List<gestaoClientesService.situacaoCliente> situacaoClienteList
                = api.ListSituacaoCliente().ToList();

            List<gestaoClientesService.tipoCliente> tipoClienteList
                = api.ListTipoCliente().ToList();

            List<dynamic> tableList = new List<dynamic>();

            foreach(var cliente in clienteList)
            {
                tableList.Add(
                    new {
                        id = cliente.id,
                        nome = cliente.nome,
                        cpf = cliente.cpf,
                        sexo = cliente.masculino ? "Masculino" : "Feminino",
                        tipo = tipoClienteList
                            .Where(t => t.id == cliente.tipoClienteId).FirstOrDefault().descricao,
                        situacao = situacaoClienteList
                            .Where(t => t.id == cliente.situacaoClienteId).FirstOrDefault().descricao
                    });
            }

            GridView1.DataSource = tableList;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = e.NewEditIndex;
            GridViewRow row = (GridViewRow)GridView1.Rows[id];
            id = int.Parse(row.Cells[0].Text);

            Response.Redirect("EditarCliente.aspx?clienteid=" + id);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = e.RowIndex;
            GridViewRow row = (GridViewRow)GridView1.Rows[id];
            id = int.Parse(row.Cells[0].Text);

            Response.Redirect("DeletarCliente.aspx?clienteid=" + id);
        }
    }
}