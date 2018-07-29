﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace gestaoClientesSvcLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IgestaoClientes
    {
        [OperationContract]
        List<tipoCliente> ListTipoCliente();

        [OperationContract]
        List<situacaoCliente> ListSituacaoCliente();

        [OperationContract]
        List<cliente> ListCliente();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "gestaoClientesSvcLib.ContractType".
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class cliente
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string cpf { get; set; }
        [DataMember]
        public bool masculino { get; set; }
        [DataMember]
        public int tipoCliente { get; set; }
        [DataMember]
        public int situacaoCliente { get; set; }
    }

    [DataContract]
    public class tipoCliente
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string descricao { get; set; }
    }

    [DataContract]
    public class situacaoCliente
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string descricao { get; set; }
    }
}