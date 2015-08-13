using ModeloCanonico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INOVIX
{
    public class InovixUtil
    {
        public static ModeloCanonico.Custumer obterClienteYUM(string cpf)
        {
            ServiceReferenceYUM.YUMServiceSoapClient client = new ServiceReferenceYUM.YUMServiceSoapClient();
            ServiceReferenceYUM.Custumer custumer = client.GetCustomerByCPF(cpf);
            if (custumer != null)
            {
                return converterObjetoCustomerYUM(custumer);
            } else
            {
                return null;
            }
            
        }

        private static ModeloCanonico.Custumer converterObjetoCustomerYUM(ServiceReferenceYUM.Custumer custumer)
        {
            ModeloCanonico.Custumer novoCliente = new ModeloCanonico.Custumer();
            novoCliente.Cpf = custumer.Cpf;
            novoCliente.Nome = custumer.Nome;
            novoCliente.EnderecoCompleto = custumer.EnderecoCompleto;
            return novoCliente;
        }

        public static Acount obterDadosContaKGB(ModeloCanonico.Custumer customer)
        {
            ServiceReferenceKGB.KgbServiceClient client = new ServiceReferenceKGB.KgbServiceClient();
            return client.ObterDadosConta(customer);
        }

        public static void atualizarClienteYUM(ModeloCanonico.Custumer customer)
        {
            ServiceReferenceYUM.YUMServiceSoapClient client = new ServiceReferenceYUM.YUMServiceSoapClient();
            client.UpdateCustomer(criarObjetoCustomerYUM(customer));

        }

        public static ServiceReferenceYUM.Custumer criarObjetoCustomerYUM(ModeloCanonico.Custumer customer)
        {
            ServiceReferenceYUM.Custumer novoCustomer = new ServiceReferenceYUM.Custumer();
            novoCustomer.Cpf = customer.Cpf;
            novoCustomer.Nome = customer.Nome;
            novoCustomer.EnderecoCompleto = customer.EnderecoCompleto;
            return novoCustomer;
        }

        public static ModeloCanonico.Custumer obterClienteKGB(string cpf)
        {
            ServiceReferenceKGB.KgbServiceClient client = new ServiceReferenceKGB.KgbServiceClient();
            return client.GetCustomerByCPF(cpf);
        }
    }
}