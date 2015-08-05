﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INOVIX.ServiceReferenceYUM {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Custumer", Namespace="http://br.pucminas/")]
    [System.SerializableAttribute()]
    public partial class Custumer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CpfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnderecoCompletoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Cpf {
            get {
                return this.CpfField;
            }
            set {
                if ((object.ReferenceEquals(this.CpfField, value) != true)) {
                    this.CpfField = value;
                    this.RaisePropertyChanged("Cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string EnderecoCompleto {
            get {
                return this.EnderecoCompletoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoCompletoField, value) != true)) {
                    this.EnderecoCompletoField = value;
                    this.RaisePropertyChanged("EnderecoCompleto");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://br.pucminas/", ConfigurationName="ServiceReferenceYUM.YUMServiceSoap")]
    public interface YUMServiceSoap {
        
        // CODEGEN: Generating message contract since element name cpf from namespace http://br.pucminas/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://br.pucminas/GetCustomerByCPF", ReplyAction="*")]
        INOVIX.ServiceReferenceYUM.GetCustomerByCPFResponse GetCustomerByCPF(INOVIX.ServiceReferenceYUM.GetCustomerByCPFRequest request);
        
        // CODEGEN: Generating message contract since element name customer from namespace http://br.pucminas/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://br.pucminas/UpdateCustomer", ReplyAction="*")]
        INOVIX.ServiceReferenceYUM.UpdateCustomerResponse UpdateCustomer(INOVIX.ServiceReferenceYUM.UpdateCustomerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCustomerByCPFRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCustomerByCPF", Namespace="http://br.pucminas/", Order=0)]
        public INOVIX.ServiceReferenceYUM.GetCustomerByCPFRequestBody Body;
        
        public GetCustomerByCPFRequest() {
        }
        
        public GetCustomerByCPFRequest(INOVIX.ServiceReferenceYUM.GetCustomerByCPFRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://br.pucminas/")]
    public partial class GetCustomerByCPFRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cpf;
        
        public GetCustomerByCPFRequestBody() {
        }
        
        public GetCustomerByCPFRequestBody(string cpf) {
            this.cpf = cpf;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCustomerByCPFResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCustomerByCPFResponse", Namespace="http://br.pucminas/", Order=0)]
        public INOVIX.ServiceReferenceYUM.GetCustomerByCPFResponseBody Body;
        
        public GetCustomerByCPFResponse() {
        }
        
        public GetCustomerByCPFResponse(INOVIX.ServiceReferenceYUM.GetCustomerByCPFResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://br.pucminas/")]
    public partial class GetCustomerByCPFResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public INOVIX.ServiceReferenceYUM.Custumer GetCustomerByCPFResult;
        
        public GetCustomerByCPFResponseBody() {
        }
        
        public GetCustomerByCPFResponseBody(INOVIX.ServiceReferenceYUM.Custumer GetCustomerByCPFResult) {
            this.GetCustomerByCPFResult = GetCustomerByCPFResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateCustomerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateCustomer", Namespace="http://br.pucminas/", Order=0)]
        public INOVIX.ServiceReferenceYUM.UpdateCustomerRequestBody Body;
        
        public UpdateCustomerRequest() {
        }
        
        public UpdateCustomerRequest(INOVIX.ServiceReferenceYUM.UpdateCustomerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://br.pucminas/")]
    public partial class UpdateCustomerRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public INOVIX.ServiceReferenceYUM.Custumer customer;
        
        public UpdateCustomerRequestBody() {
        }
        
        public UpdateCustomerRequestBody(INOVIX.ServiceReferenceYUM.Custumer customer) {
            this.customer = customer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateCustomerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateCustomerResponse", Namespace="http://br.pucminas/", Order=0)]
        public INOVIX.ServiceReferenceYUM.UpdateCustomerResponseBody Body;
        
        public UpdateCustomerResponse() {
        }
        
        public UpdateCustomerResponse(INOVIX.ServiceReferenceYUM.UpdateCustomerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://br.pucminas/")]
    public partial class UpdateCustomerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool UpdateCustomerResult;
        
        public UpdateCustomerResponseBody() {
        }
        
        public UpdateCustomerResponseBody(bool UpdateCustomerResult) {
            this.UpdateCustomerResult = UpdateCustomerResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface YUMServiceSoapChannel : INOVIX.ServiceReferenceYUM.YUMServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class YUMServiceSoapClient : System.ServiceModel.ClientBase<INOVIX.ServiceReferenceYUM.YUMServiceSoap>, INOVIX.ServiceReferenceYUM.YUMServiceSoap {
        
        public YUMServiceSoapClient() {
        }
        
        public YUMServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public YUMServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public YUMServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public YUMServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        INOVIX.ServiceReferenceYUM.GetCustomerByCPFResponse INOVIX.ServiceReferenceYUM.YUMServiceSoap.GetCustomerByCPF(INOVIX.ServiceReferenceYUM.GetCustomerByCPFRequest request) {
            return base.Channel.GetCustomerByCPF(request);
        }
        
        public INOVIX.ServiceReferenceYUM.Custumer GetCustomerByCPF(string cpf) {
            INOVIX.ServiceReferenceYUM.GetCustomerByCPFRequest inValue = new INOVIX.ServiceReferenceYUM.GetCustomerByCPFRequest();
            inValue.Body = new INOVIX.ServiceReferenceYUM.GetCustomerByCPFRequestBody();
            inValue.Body.cpf = cpf;
            INOVIX.ServiceReferenceYUM.GetCustomerByCPFResponse retVal = ((INOVIX.ServiceReferenceYUM.YUMServiceSoap)(this)).GetCustomerByCPF(inValue);
            return retVal.Body.GetCustomerByCPFResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        INOVIX.ServiceReferenceYUM.UpdateCustomerResponse INOVIX.ServiceReferenceYUM.YUMServiceSoap.UpdateCustomer(INOVIX.ServiceReferenceYUM.UpdateCustomerRequest request) {
            return base.Channel.UpdateCustomer(request);
        }
        
        public bool UpdateCustomer(INOVIX.ServiceReferenceYUM.Custumer customer) {
            INOVIX.ServiceReferenceYUM.UpdateCustomerRequest inValue = new INOVIX.ServiceReferenceYUM.UpdateCustomerRequest();
            inValue.Body = new INOVIX.ServiceReferenceYUM.UpdateCustomerRequestBody();
            inValue.Body.customer = customer;
            INOVIX.ServiceReferenceYUM.UpdateCustomerResponse retVal = ((INOVIX.ServiceReferenceYUM.YUMServiceSoap)(this)).UpdateCustomer(inValue);
            return retVal.Body.UpdateCustomerResult;
        }
    }
}
