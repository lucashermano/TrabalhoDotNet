using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ModeloCanonico;

namespace KGB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IKgbService
    {

        [OperationContract]
        Custumer ObterStatusFinanceiroCliente(string cpf);
        [OperationContract]
        Custumer GetCustomerByCPF(string cpf);
        [OperationContract]
        Acount ObterDadosConta(Custumer customer);
      
    }

     
}
