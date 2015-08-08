using ModeloCanonico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using INOVIX.ServiceReferenceYUM;
using System.Threading.Tasks;
using System.Threading;

namespace INOVIX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : InovixService
    {

        private ModeloCanonico.Custumer customerGlobal;
        private Acount contaGlobal;

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
            customer = InovixUtil.obterClienteYUM(cpf);


            /**
             * Caso chamada ao YUM não encontre o cliente, chamando o kgb
             * */
            if (customer == null)
            {
                customer = InovixUtil.obterClienteKGB(cpf);
                //incluindo o cliente na base do yum
                InovixUtil.atualizarClienteYUM(customer);
            }

            conta = InovixUtil.obterDadosContaKGB(customer);

            customerGlobal = customer;
            contaGlobal = conta;

            object state = conta;

            var task = Task<RetornoChamada>.Factory.FromAsync(BeginObterRespostaAnatel, EndReceberRespostaAnatel, customer, conta, state);
            return task.Result;
        }

        #region ISampleTaskAsync Members
        /**Recebe a resposta de erro, chamado se houver erro na chamada do APT
         * ***/
        public IAsyncResult BeginObterRespostaAnatel(ModeloCanonico.Custumer customer, Acount contam, AsyncCallback callback, object state)
        {
            var task = Task<RetornoChamada>.Factory.StartNew(SolicitarBilheteApt, state);

            return task.ContinueWith(res => callback(task));
        }

        /**
        * Recebe a resposta do APT
        **/
        public RetornoChamada EndReceberRespostaAnatel(IAsyncResult asyncResult)
        {
            return ((Task<RetornoChamada>)asyncResult).Result;
        }
        #endregion

        private RetornoChamada SolicitarBilheteApt(object state)
        {
            ModeloCanonico.Custumer custumer = (ModeloCanonico.Custumer)state;
            ServiceReferenceApt.AptServiceClient aptClient = new ServiceReferenceApt.AptServiceClient();

            Portability portabilidade = aptClient.SolicitarBilhetePortabilidade(customerGlobal, contaGlobal);

            RetornoChamada retorno = new RetornoChamada();
            retorno.StringValue = "Bilhete gerado: " + portabilidade.Bilhete;
            return retorno;
        }


    }
}
