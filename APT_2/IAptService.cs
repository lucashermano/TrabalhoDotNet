using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModeloCanonico;

namespace APT
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    [RequiredParametersBehavior] //identifica que todos os parametros são obrigatorios
    public interface IAptService
    {
        [OperationContract]
        [FaultContract(typeof(PortabilidadeFault))]
        Portability SolicitarBilhetePortabilidade(Custumer custumer, Acount acount);
    }

     
}
