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
            customer.Cpf = "04986491644";

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
           
        }

        private void buttonErro02_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
