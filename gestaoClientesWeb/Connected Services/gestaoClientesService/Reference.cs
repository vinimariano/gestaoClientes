﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gestaoClientesWeb.gestaoClientesService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tipoCliente", Namespace="http://schemas.datacontract.org/2004/07/gestaoClientesSvcLib")]
    [System.SerializableAttribute()]
    public partial class tipoCliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descricao {
            get {
                return this.descricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.descricaoField, value) != true)) {
                    this.descricaoField = value;
                    this.RaisePropertyChanged("descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="situacaoCliente", Namespace="http://schemas.datacontract.org/2004/07/gestaoClientesSvcLib")]
    [System.SerializableAttribute()]
    public partial class situacaoCliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descricao {
            get {
                return this.descricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.descricaoField, value) != true)) {
                    this.descricaoField = value;
                    this.RaisePropertyChanged("descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="cliente", Namespace="http://schemas.datacontract.org/2004/07/gestaoClientesSvcLib")]
    [System.SerializableAttribute()]
    public partial class cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cpfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool masculinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int situacaoClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int tipoClienteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cpf {
            get {
                return this.cpfField;
            }
            set {
                if ((object.ReferenceEquals(this.cpfField, value) != true)) {
                    this.cpfField = value;
                    this.RaisePropertyChanged("cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool masculino {
            get {
                return this.masculinoField;
            }
            set {
                if ((this.masculinoField.Equals(value) != true)) {
                    this.masculinoField = value;
                    this.RaisePropertyChanged("masculino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int situacaoCliente {
            get {
                return this.situacaoClienteField;
            }
            set {
                if ((this.situacaoClienteField.Equals(value) != true)) {
                    this.situacaoClienteField = value;
                    this.RaisePropertyChanged("situacaoCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int tipoCliente {
            get {
                return this.tipoClienteField;
            }
            set {
                if ((this.tipoClienteField.Equals(value) != true)) {
                    this.tipoClienteField = value;
                    this.RaisePropertyChanged("tipoCliente");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="gestaoClientesService.IgestaoClientes")]
    public interface IgestaoClientes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgestaoClientes/ListTipoCliente", ReplyAction="http://tempuri.org/IgestaoClientes/ListTipoClienteResponse")]
        gestaoClientesWeb.gestaoClientesService.tipoCliente[] ListTipoCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgestaoClientes/ListTipoCliente", ReplyAction="http://tempuri.org/IgestaoClientes/ListTipoClienteResponse")]
        System.Threading.Tasks.Task<gestaoClientesWeb.gestaoClientesService.tipoCliente[]> ListTipoClienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgestaoClientes/ListSituacaoCliente", ReplyAction="http://tempuri.org/IgestaoClientes/ListSituacaoClienteResponse")]
        gestaoClientesWeb.gestaoClientesService.situacaoCliente[] ListSituacaoCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgestaoClientes/ListSituacaoCliente", ReplyAction="http://tempuri.org/IgestaoClientes/ListSituacaoClienteResponse")]
        System.Threading.Tasks.Task<gestaoClientesWeb.gestaoClientesService.situacaoCliente[]> ListSituacaoClienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgestaoClientes/ListCliente", ReplyAction="http://tempuri.org/IgestaoClientes/ListClienteResponse")]
        gestaoClientesWeb.gestaoClientesService.cliente[] ListCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgestaoClientes/ListCliente", ReplyAction="http://tempuri.org/IgestaoClientes/ListClienteResponse")]
        System.Threading.Tasks.Task<gestaoClientesWeb.gestaoClientesService.cliente[]> ListClienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgestaoClientes/CreateCliente", ReplyAction="http://tempuri.org/IgestaoClientes/CreateClienteResponse")]
        void CreateCliente(gestaoClientesWeb.gestaoClientesService.cliente novoCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgestaoClientes/CreateCliente", ReplyAction="http://tempuri.org/IgestaoClientes/CreateClienteResponse")]
        System.Threading.Tasks.Task CreateClienteAsync(gestaoClientesWeb.gestaoClientesService.cliente novoCliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IgestaoClientesChannel : gestaoClientesWeb.gestaoClientesService.IgestaoClientes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IgestaoClientesClient : System.ServiceModel.ClientBase<gestaoClientesWeb.gestaoClientesService.IgestaoClientes>, gestaoClientesWeb.gestaoClientesService.IgestaoClientes {
        
        public IgestaoClientesClient() {
        }
        
        public IgestaoClientesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IgestaoClientesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IgestaoClientesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IgestaoClientesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public gestaoClientesWeb.gestaoClientesService.tipoCliente[] ListTipoCliente() {
            return base.Channel.ListTipoCliente();
        }
        
        public System.Threading.Tasks.Task<gestaoClientesWeb.gestaoClientesService.tipoCliente[]> ListTipoClienteAsync() {
            return base.Channel.ListTipoClienteAsync();
        }
        
        public gestaoClientesWeb.gestaoClientesService.situacaoCliente[] ListSituacaoCliente() {
            return base.Channel.ListSituacaoCliente();
        }
        
        public System.Threading.Tasks.Task<gestaoClientesWeb.gestaoClientesService.situacaoCliente[]> ListSituacaoClienteAsync() {
            return base.Channel.ListSituacaoClienteAsync();
        }
        
        public gestaoClientesWeb.gestaoClientesService.cliente[] ListCliente() {
            return base.Channel.ListCliente();
        }
        
        public System.Threading.Tasks.Task<gestaoClientesWeb.gestaoClientesService.cliente[]> ListClienteAsync() {
            return base.Channel.ListClienteAsync();
        }
        
        public void CreateCliente(gestaoClientesWeb.gestaoClientesService.cliente novoCliente) {
            base.Channel.CreateCliente(novoCliente);
        }
        
        public System.Threading.Tasks.Task CreateClienteAsync(gestaoClientesWeb.gestaoClientesService.cliente novoCliente) {
            return base.Channel.CreateClienteAsync(novoCliente);
        }
    }
}