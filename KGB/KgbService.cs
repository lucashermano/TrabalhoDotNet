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
            //• Operação que retorna o status financeiro do cliente a partir de um dado CPF de
            //entrada.
            //• Validar se o dado é válido
            //• CPF obrigatório
            //• Usar WCF
            throw new NotImplementedException();
        }

        public Custumer GetCustomerByCPF(string cpf)
        {
            //• Operação que retorna o cliente a partir de um dado CPF de entrada.
            //• Validar se o dado é válido
            //• CPF obrigatório
            //• Usar ASMX
            throw new NotImplementedException();
        }

        public Acount ObterDadosConta(Custumer customer)
        {
            //• Operação que retorna a conta de um cliente
            //• Validar se o dado é válido
            //• Customer obrigatório
            //• Usar WCF
            throw new NotImplementedException();
        }
    }
}