﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientTest.ServiceReferenceInovix {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RetornoChamada", Namespace="http://schemas.datacontract.org/2004/07/INOVIX")]
    [System.SerializableAttribute()]
    public partial class RetornoChamada : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceInovix.IInovixService")]
    public interface IInovixService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInovixService/SolicitaPortabilidade", ReplyAction="http://tempuri.org/IInovixService/SolicitaPortabilidadeResponse")]
        ClientTest.ServiceReferenceInovix.RetornoChamada SolicitaPortabilidade(ModeloCanonico.Custumer custumer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInovixService/SolicitaPortabilidade", ReplyAction="http://tempuri.org/IInovixService/SolicitaPortabilidadeResponse")]
        System.Threading.Tasks.Task<ClientTest.ServiceReferenceInovix.RetornoChamada> SolicitaPortabilidadeAsync(ModeloCanonico.Custumer custumer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInovixService/BeginObterRespostaAnatel", ReplyAction="http://tempuri.org/IInovixService/BeginObterRespostaAnatelResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ClientTest.ServiceReferenceInovix.RetornoChamada))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ModeloCanonico.Custumer))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ModeloCanonico.Acount))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.AsyncCallback))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.MulticastDelegate))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Delegate))]
        object BeginObterRespostaAnatel(ModeloCanonico.Custumer customer, ModeloCanonico.Acount conta, System.AsyncCallback callback, object state);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInovixService/BeginObterRespostaAnatel", ReplyAction="http://tempuri.org/IInovixService/BeginObterRespostaAnatelResponse")]
        System.Threading.Tasks.Task<object> BeginObterRespostaAnatelAsync(ModeloCanonico.Custumer customer, ModeloCanonico.Acount conta, System.AsyncCallback callback, object state);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInovixServiceChannel : ClientTest.ServiceReferenceInovix.IInovixService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InovixServiceClient : System.ServiceModel.ClientBase<ClientTest.ServiceReferenceInovix.IInovixService>, ClientTest.ServiceReferenceInovix.IInovixService {
        
        public InovixServiceClient() {
        }
        
        public InovixServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InovixServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InovixServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InovixServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientTest.ServiceReferenceInovix.RetornoChamada SolicitaPortabilidade(ModeloCanonico.Custumer custumer) {
            return base.Channel.SolicitaPortabilidade(custumer);
        }
        
        public System.Threading.Tasks.Task<ClientTest.ServiceReferenceInovix.RetornoChamada> SolicitaPortabilidadeAsync(ModeloCanonico.Custumer custumer) {
            return base.Channel.SolicitaPortabilidadeAsync(custumer);
        }
        
        public object BeginObterRespostaAnatel(ModeloCanonico.Custumer customer, ModeloCanonico.Acount conta, System.AsyncCallback callback, object state) {
            return base.Channel.BeginObterRespostaAnatel(customer, conta, callback, state);
        }
        
        public System.Threading.Tasks.Task<object> BeginObterRespostaAnatelAsync(ModeloCanonico.Custumer customer, ModeloCanonico.Acount conta, System.AsyncCallback callback, object state) {
            return base.Channel.BeginObterRespostaAnatelAsync(customer, conta, callback, state);
        }
    }
}