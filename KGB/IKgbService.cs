using ModeloCanonico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KGB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    [RequiredParametersBehavior]
    public interface IKgbService
    {
        [OperationContract]
        [FaultContract(typeof(PortabilidadeFault))]
        Custumer ObterStatusFinanceiroCliente(string cpf);

        [OperationContract]
        [FaultContract(typeof(PortabilidadeFault))]
        Custumer GetCustomerByCPF(string cpf);
        
        [OperationContract]
        [FaultContract(typeof(PortabilidadeFault))]
        Acount ObterDadosConta(Custumer customer);
    }
    
}
