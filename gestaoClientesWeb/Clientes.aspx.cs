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

          List<gestaoClientesService.cliente> clientes
                = api.ListCliente().ToList();

            GridView1.DataSource = clientes;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = e.NewEditIndex;
            GridViewRow row = (GridViewRow)GridView1.Rows[id];
            id = int.Parse(row.Cells[2].Text);

            Response.Redirect("EditarCliente.aspx?clienteid=" + id);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = e.RowIndex;
            GridViewRow row = (GridViewRow)GridView1.Rows[id];
            id = int.Parse(row.Cells[2].Text);

            Response.Redirect("DeletarCliente.aspx?clienteid=" + id);
        }
    }
}