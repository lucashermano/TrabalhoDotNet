﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INOVIX.ServiceReferenceApt {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceApt.IAptService")]
    public interface IAptService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAptService/SolicitarBilhetePortabilidade", ReplyAction="http://tempuri.org/IAptService/SolicitarBilhetePortabilidadeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ModeloCanonico.PortabilidadeFault), Action="http://tempuri.org/IAptService/SolicitarBilhetePortabilidadePortabilidadeFaultFau" +
            "lt", Name="PortabilidadeFault", Namespace="http://br.pucminas")]
        ModeloCanonico.Portability SolicitarBilhetePortabilidade(ModeloCanonico.Custumer custumer, ModeloCanonico.Acount acount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAptServiceChannel : INOVIX.ServiceReferenceApt.IAptService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AptServiceClient : System.ServiceModel.ClientBase<INOVIX.ServiceReferenceApt.IAptService>, INOVIX.ServiceReferenceApt.IAptService {
        
        public AptServiceClient() {
        }
        
        public AptServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AptServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AptServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AptServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ModeloCanonico.Portability SolicitarBilhetePortabilidade(ModeloCanonico.Custumer custumer, ModeloCanonico.Acount acount) {
            return base.Channel.SolicitarBilhetePortabilidade(custumer, acount);
        }
    }
}
