using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ModeloCanonico;

namespace INOVIX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface InovixService
    {

        [OperationContract]
        RetornoChamada SolicitaPortabilidade(Custumer custumer);

        [OperationContract(AsyncPattern = false)]
        IAsyncResult BeginObterRespostaAnatel(Custumer customer, Acount conta, AsyncCallback callback, object state);

        RetornoChamada EndReceberRespostaAnatel(IAsyncResult asyncResult);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class RetornoChamada
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

       

    }
}
