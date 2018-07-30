using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System.Configuration;
using System.ServiceModel;

namespace gestaoClientesSvcLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class gestaoClientesSvc : IgestaoClientes
    {
        private string connection =           
            ConfigurationManager.ConnectionStrings["gestaoClientes"].ConnectionString;           

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

        public void CreateCliente(cliente novoCliente)
        {
           
                if (!Validacao.IsCpf(novoCliente.cpf))
                {
                    throw new Exception("Cpf Inválido");
                }
                else if (ListCliente().Where(t => t.cpf.Trim().Replace("-", "").Replace(".", "")
                 == novoCliente.cpf.Trim().Replace("-", "").Replace(".", "")
                ).Any())
                {
                    throw new Exception("Cpf já existente no sistema.");
                }
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    string readSp = "addCliente";
                    db.Execute(readSp, new
                    {
                        nome = novoCliente.nome,
                        cpf = novoCliente.cpf,
                        masculino = novoCliente.masculino,
                        tipoClienteId = novoCliente.tipoClienteId,
                        situacaoClienteId = novoCliente.situacaoClienteId
                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao executar essa operação.");
            }
        }

        public cliente GetCliente(int id)
        {
            using (IDbConnection db = new SqlConnection(connection))
            {
                string readSp = "getCliente";
                return db.Query<cliente>(readSp, new {id = id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public void UpdateCliente(cliente novoCliente)
        {
           
                if (!Validacao.IsCpf(novoCliente.cpf))
                {
                    throw new Exception("Cpf Inválido");
                }
                else if (ListCliente().Where(t => t.cpf.Trim().Replace("-", "").Replace(".", "")
                              == novoCliente.cpf.Trim().Replace("-", "").Replace(".", "")
                            ).Any())
                {
                    if(ListCliente().Where(t => t.cpf.Trim().Replace("-", "").Replace(".", "")
                              == novoCliente.cpf.Trim().Replace("-", "").Replace(".", "")
                            ).FirstOrDefault().id != novoCliente.id)
                        throw new Exception("Cpf já existente no sistema.");
                }

            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    string readSp = "updateCliente";
                    db.Execute(readSp, new
                    {
                        id = novoCliente.id,
                        nome = novoCliente.nome,
                        cpf = novoCliente.cpf,
                        masculino = novoCliente.masculino,
                        tipoClienteId = novoCliente.tipoClienteId,
                        situacaoClienteId = novoCliente.situacaoClienteId
                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao executar essa operação.");
            }
        }

        public void DeleteCliente(int id)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    string readSp = "deleteCliente";
                    db.Execute(readSp, new { id = id }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao executar essa operação.");
            }
        }


    }
}
