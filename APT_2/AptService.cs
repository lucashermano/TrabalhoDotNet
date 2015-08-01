using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModeloCanonico;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.ServiceModel;

namespace APT
{
    public class AptService: IAptService
    {

        public Portability SolicitarBilhetePortabilidade(Custumer custumer, Acount acount)
        {

            //[chamando o webservice do módulo Anatel]
            Anatel.IAnatel client;
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (Anatel.IAnatel)Activator.GetObject(typeof(Anatel.IAnatel), "tcp://localhost:8091/SolicitarPortabilidadeNumerica");

            //[obtendo resposta da Anatel para a portabilidade]
            RetornoPortabilidade retorno = client.SolicitarPortabilidadeNumerica(custumer);

            //[verificar as validacoes retornadas pela anatel]
            if (!retorno.CodigoErro.Equals("0"))
            {
                PortabilidadeFault falha = new PortabilidadeFault();
                falha.CodigoErro = retorno.CodigoErro;
                falha.DataErro = retorno.DataErro;
                falha.Motivo = retorno.Motivo;
                throw new FaultException<PortabilidadeFault>(falha);
            }

            //[obtendo o numero do bilhete da Anatel]
            Portability portabilidade = new Portability();
            portabilidade.Bilhete = retorno.Bilhete;

            return portabilidade;
        }
    }
}