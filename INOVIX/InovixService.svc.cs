using ModeloCanonico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace INOVIX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IInovixService
    {
       

        
        /**
         * Metodo chamado da tela.
         * 
         * */
        public RetornoChamada SolicitaPortabilidade(ModeloCanonico.Custumer custumer)
        {
            /**
             * Chamada ao YUM*/


            /**
             * Caso chamada ao YUM retorno verdadeiro vamos chamar o KGB/*
             * */
            throw new NotImplementedException();

            /*
             * Depois de chamar o kbg chamamos o APT

           
             * Caso nao falhe:
             * Chamar o APT SolicitarBilhetePortabilidade
             
             Pegar o numero do Bilhete que o APT vai me cdevolver e colocar num array custumer e bilhete.
            Manda emnsagem de pedido enviado
            /**/
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

    }
}
