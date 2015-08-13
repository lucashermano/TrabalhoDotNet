using ModeloCanonico;
using System.ServiceModel;
using System.Windows;

namespace ClientTest
{
    /// <summary>
    /// Interaction logic for TesteUnitarioServiceInovix.xaml
    /// </summary>
    public partial class TesteUnitarioServiceInovix : Window
    {


        public TesteUnitarioServiceInovix()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ServiceReferenceInovix.InovixServiceClient client = new ServiceReferenceInovix.InovixServiceClient();
            ModeloCanonico.Custumer customer = new ModeloCanonico.Custumer();
            customer.Cpf = "70127182772";

            try
            {
                ServiceReferenceInovix.RetornoChamada retorno = client.SolicitaPortabilidade(customer);
                textBoxSucesso.Text = retorno.StringValue;
            }
            catch (System.Exception erro)
            {
                textBoxSucesso.Text = "Erro na chamada ao serviço inovix: " + erro;
            }

        }

        private void buttonErro01_Click(object sender, RoutedEventArgs e)
        {
            ServiceReferenceInovix.InovixServiceClient client = new ServiceReferenceInovix.InovixServiceClient();
            ModeloCanonico.Custumer customer = new ModeloCanonico.Custumer();
            customer.Cpf = "04986491644";

            try
            {
                ServiceReferenceInovix.RetornoChamada retorno = client.SolicitaPortabilidade(customer);
                textBoxErro01.Text = retorno.StringValue;
            }
            catch (FaultException<PortabilidadeFault> erro)
            {
                textBoxErro01.Text = "Erro " + erro.Detail.CodigoErro + ": " + erro.Detail.Motivo;
            }
            catch (System.Exception erro)
            {
                textBoxErro01.Text = "Erro na chamada ao serviço inovix: " + erro;
            }
        }
    }
}
