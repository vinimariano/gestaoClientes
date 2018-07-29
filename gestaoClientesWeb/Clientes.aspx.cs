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
    }
}