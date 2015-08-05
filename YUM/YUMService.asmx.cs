using System;
using System.Web.Services;
using ModeloCanonico;
namespace YUM
{
    /// <summary>
    /// Summary description for YUMService
    /// </summary>
    [WebService(Namespace = "http://br.pucminas/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class YUMService : System.Web.Services.WebService
    {
        [WebMethod]
        public Boolean UpdateCustomer(Custumer customer)
        {
            //validar dados do cliente
            validarCliente(customer);

            //caso aconteça algum erro na atualização do cliente
            atualizarBaseDeDados(customer);

            return true;
        }

        private void atualizarBaseDeDados(Custumer customer)
        {
           if (customer.Cpf.Equals("88995267615"))
            {
                throw new Exception("Erro na atualização da base de dados.");
            }
        }

        private void validarCliente(Custumer customer)
        {
            if (customer.Cpf == null)
            {
                throw new Exception("CPF inválido.");
            }

            if (customer.Nome == null)
            {
                throw new Exception("Nome inválido.");
            }

            if (customer.EnderecoCompleto == null)
            {
                throw new Exception("Endereço inválido.");
            }

        }
    }
}
