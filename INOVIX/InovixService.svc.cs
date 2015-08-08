using ModeloCanonico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using INOVIX.ServiceReferenceYUM;

namespace INOVIX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IInovixService
    {
       

        
        /**
         * Metodo chamado da tela.
         * 
         * */
        public RetornoChamada SolicitaPortabilidade(ModeloCanonico.Custumer customer)
        {
            Acount conta = null;
            string cpf = customer.Cpf;
            /**
             * Chamada ao YUM*/
            customer = obterClienteYUM(cpf);


            /**
             * Caso chamada ao YUM não encontre o cliente, chamando o kgb
             * */
            if (customer == null)
            {
                customer = obterClienteKGB(cpf);
                //incluindo o cliente na base do yum
                atualizarClienteYUM(customer);
            }

            conta = obterDadosContaKGB(customer);

            ServiceReferenceApt.AptServiceClient aptClient = new ServiceReferenceApt.AptServiceClient();

            Portability portabilidade = aptClient.SolicitarBilhetePortabilidade(customer, conta);

            RetornoChamada retorno = new RetornoChamada();
            retorno.

            return null;
        }

        private Acount obterDadosContaKGB(ModeloCanonico.Custumer customer)
        {
            ServiceReferenceKGB.KgbServiceClient client = new ServiceReferenceKGB.KgbServiceClient();
            return client.ObterDadosConta(customer);
        }



        /**
         * Recebe a resposta do APT
         * */
        public RetornoChamada ReceberRespostaAnatel(RetornoPortabilidade custumer)
        {
            return null;
        }


        /**Recebe a resposta de erro, chamado se houver erro na chamada do APT
         * ***/
        public RetornoChamada ObterRespostaAnatel(RetornoPortabilidade custumer)
        {
            return null;
        }

        private ModeloCanonico.Custumer obterClienteYUM(string cpf)
        {
            ServiceReferenceYUM.YUMServiceSoapClient client = new ServiceReferenceYUM.YUMServiceSoapClient();
            ServiceReferenceYUM.Custumer custumer = client.GetCustomerByCPF(cpf);
            return converterObjetoCustomerYUM(custumer);
        }

        private void atualizarClienteYUM(ModeloCanonico.Custumer customer)
        {
            ServiceReferenceYUM.YUMServiceSoapClient client = new ServiceReferenceYUM.YUMServiceSoapClient();
            client.UpdateCustomer(criarObjetoCustomerYUM(customer));

        }

        private ServiceReferenceYUM.Custumer criarObjetoCustomerYUM(ModeloCanonico.Custumer customer)
        {
            ServiceReferenceYUM.Custumer novoCustomer = new ServiceReferenceYUM.Custumer();
            novoCustomer.Cpf = customer.Cpf;
            novoCustomer.Nome = customer.Nome;
            novoCustomer.EnderecoCompleto = customer.EnderecoCompleto;
            return novoCustomer;
        }

        private ModeloCanonico.Custumer converterObjetoCustomerYUM(ServiceReferenceYUM.Custumer custumer)
        {
            ModeloCanonico.Custumer novoCliente = new ModeloCanonico.Custumer();
            novoCliente.Cpf = custumer.Cpf;
            novoCliente.Nome = custumer.Nome;
            novoCliente.EnderecoCompleto= custumer.EnderecoCompleto;
            return novoCliente;
        }

        private ModeloCanonico.Custumer obterClienteKGB(string cpf)
        {
            ServiceReferenceKGB.KgbServiceClient client = new ServiceReferenceKGB.KgbServiceClient();
            return client.GetCustomerByCPF(cpf);
        }
    }
}
