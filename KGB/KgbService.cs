using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModeloCanonico;

namespace KGB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class KgbService : IKgbService
    {

        public Custumer ObterStatusFinanceiroCliente(string cpf)
        {
            throw new NotImplementedException();
        }

        public Custumer GetCustomerByCPF(string cpf)
        {
            throw new NotImplementedException();
        }

        public Acount ObterDadosConta(Custumer customer)
        {
            throw new NotImplementedException();
        }
    }
}