using System;
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

        //[FaultContract(typeof(AppException))]
        [OperationContract]
        void CreateCliente(cliente novoCliente);

        [OperationContract]
        cliente GetCliente(int id);

        [OperationContract]
        void UpdateCliente(cliente novoCliente);

        [OperationContract]
        void DeleteCliente(int id);
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
        public string nome { get; set; }
        [DataMember]
        public string cpf { get; set; }
        [DataMember]
        public bool masculino { get; set; }
        [DataMember]
        public int tipoClienteId { get; set; }
        [DataMember]
        public int situacaoClienteId { get; set; }
    }

    //[DataContract]
    //public class AppException : System.Exception
    //{
    //    private string strMessage = "Um erro inesperado ocorreu. Tente mais tarde.";

    //    /// <summary>
    //    /// Creates a new instance of a App Exception
    //    /// </summary>
    //    public AppException()
    //    { }

    //    /// <summary>
    //    /// Creates a new instance of a App Exception
    //    /// </summary>
    //    /// <param name="Message">Message to send as exception</param>
    //    public AppException(string Message)
    //    { strMessage = Message; }

    //    public override string Message
    //    { get { return strMessage; } }
    //}

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
