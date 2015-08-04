using ModeloCanonico;
using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows;

namespace ClientTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ServiceReferenceKgb.KgbServiceClient kgb = new ServiceReferenceKgb.KgbServiceClient();
            ModeloCanonico.Custumer custumer = kgb.GetCustomerByCPF("04986491644");
            textBox.Text = custumer.Nome;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ServiceReferenceApt.AptServiceClient apt = new ServiceReferenceApt.AptServiceClient();

            ModeloCanonico.Custumer custumer = new ModeloCanonico.Custumer();
            custumer.Nome = "Custumer apt";
            ModeloCanonico.Acount acount = new ModeloCanonico.Acount();
            acount.Number = "122345";
            ModeloCanonico.Portability portabilidade = apt.SolicitarBilhetePortabilidade(custumer, acount);
            textBox1.Text = portabilidade.Bilhete;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = "0";
            //[chamando o webservice do módulo Anatel]
            
            Anatel.IAnatel client;
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (Anatel.IAnatel)Activator.GetObject(typeof(Anatel.IAnatel), "tcp://localhost:8091/SolicitarPortabilidadeNumerica");
            Custumer custumer = new Custumer();
            custumer.Nome = "Hermano";
            //[obtendo resposta da Anatel para a portabilidade]
            RetornoPortabilidade retorno = client.SolicitarPortabilidadeNumerica(custumer);
            textBox2.Text = retorno.Bilhete;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ServiceReferenceYum.YUMServiceSoapClient client = new ServiceReferenceYum.YUMServiceSoapClient();
            ServiceReferenceYum.Custumer customer = new ServiceReferenceYum.Custumer();
            customer.Nome = "Hermano";
            customer.Cpf = "99999999999";
            customer.EnderecoCompleto = "Endereco imcompleto";

            if (client.UpdateCustomer(customer))
            {
                textBox3.Text = "Cliente atualizado: "+customer.EnderecoCompleto;
            } else
            {
                textBox3.Text = "Cliente desatualizado!";
            }

            
        }
    }
}
