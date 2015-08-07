using ModeloCanonico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClientTest
{
    /// <summary>
    /// Interaction logic for TesteUnitarioServiceAnatel.xaml
    /// </summary>
    public partial class TesteUnitarioServiceAnatel : Window
    {
        private Anatel.IAnatel client;

        public TesteUnitarioServiceAnatel()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (Anatel.IAnatel)Activator.GetObject(typeof(Anatel.IAnatel), "tcp://localhost:8091/SolicitarPortabilidadeNumerica");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Custumer custumer = new Custumer();
            custumer.Nome = "cliente com teste de sucesso";
            custumer.Cpf = "88888888888";
            RetornoPortabilidade retorno = client.SolicitarPortabilidadeNumerica(custumer);
            if (retorno.CodigoErro == "0")
            {
                textBoxSucesso.Text = "Sucesso na chamada ao Anatel. Código: "+retorno.CodigoErro+" - Mensagem retorno:  "+
                    retorno.Motivo+" - Bilhete gerado: "+retorno.Bilhete;
            } else
            {
                textBoxSucesso.Text = "Erro na chamada ao Anatel.";
            }
        }

        private void buttonErro01_Click(object sender, RoutedEventArgs e)
        {
            Custumer custumer = new Custumer();
            custumer.Nome = "cliente erro 01";
            custumer.Cpf = "04986491644";
            RetornoPortabilidade retorno = client.SolicitarPortabilidadeNumerica(custumer);
            if (retorno.CodigoErro == "1")
            {
                textBoxErro01.Text = "Erro Código: " + retorno.CodigoErro + " - Mensagem retorno: " + retorno.Motivo;
            }
            else
            {
                textBoxErro01.Text = "Erro na chamada ao Anatel.";
            }
        }

        private void buttonErro02_Click(object sender, RoutedEventArgs e)
        {
            Custumer custumer = new Custumer();
            custumer.Nome = "cliente erro 02";
            custumer.Cpf = "05666561677";
            RetornoPortabilidade retorno = client.SolicitarPortabilidadeNumerica(custumer);
            if (retorno.CodigoErro == "2")
            {
                textBoxErro02.Text = "Erro Código: " + retorno.CodigoErro + " - Mensagem retorno: " + retorno.Motivo;
            }
            else
            {
                textBoxErro02.Text = "Erro na chamada ao Anatel.";
            }
        }
    }
}
