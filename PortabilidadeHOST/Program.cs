﻿using System;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.ServiceModel;
using APT;
using KGB;

namespace PortabilidadeHOST
{
    class Program
    {
        static void Main(string[] args)
        {
            iniciarServicoAnatel();
            iniciarServicoAPT();
            iniciarServicoKGB();
            //TODO verificar erro na inicialização do serviço do inovix
            iniciarServicoInovix();
            Console.Read();

        }

        private static void iniciarServicoInovix()
        {
            using (ServiceHost host = new ServiceHost(typeof(INOVIX.InovixService)))
            {
                host.Open();
                Console.WriteLine("Serviço Inovix iniciado @ " + DateTime.Now);
            }
        }

        private static void iniciarServicoKGB()
        {
            using (ServiceHost host = new ServiceHost(typeof(KgbService)))
            {
                host.Open();
                Console.WriteLine("Serviço KGB iniciado @ " + DateTime.Now);
            }
        }

        private static void iniciarServicoAPT()
        {
            //mesmo configurando o serviço igual as aulas, o servico não inicia na url localhost:9090
            //somente no endereço http://localhost:8733/AptService/
            using (ServiceHost host = new ServiceHost(typeof(AptService)))
            {
                host.Open();
                Console.WriteLine("Serviço APT iniciado @ " + DateTime.Now);
            }
        }

        private static void iniciarServicoAnatel()
        {
            Anatel.Anatel remotingService = new Anatel.Anatel();
            TcpChannel channel = new TcpChannel(8091);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Anatel.Anatel), "SolicitarPortabilidadeNumerica", WellKnownObjectMode.Singleton);

            Console.WriteLine("Serviço Anatel iniciado @ " + DateTime.Now);
        }
    }
}
