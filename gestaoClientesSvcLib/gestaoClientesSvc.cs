using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System.Configuration;

namespace gestaoClientesSvcLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class gestaoClientesSvc : IgestaoClientes
    {
        private string connection =
         "Data Source=localhost;Initial Catalog=gestaoClientes;Integrated Security=True;";

        public List<tipoCliente> ListTipoCliente()
        {
            using (IDbConnection db = new SqlConnection(connection))
            {
                string readSp = "listTipoCliente";
                return db.Query<tipoCliente>(readSp, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<situacaoCliente> ListSituacaoCliente()
        {
            using (IDbConnection db = new SqlConnection(connection))
            {
                string readSp = "listSituacaoCliente";
                return db.Query<situacaoCliente>(readSp, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<cliente> ListCliente()
        {
            using (IDbConnection db = new SqlConnection(connection))
            {
                string readSp = "listCliente";
                return db.Query<cliente>(readSp, commandType: CommandType.StoredProcedure).ToList();
            }
        }


    }
}
