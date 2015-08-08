using ModeloCanonico;
using System;
using System.ServiceModel;
using System.Windows;

namespace ClientTest
{
    /// <summary>
    /// Interaction logic for TesteUnitarioServiceAnatel.xaml
    /// </summary>
    public partial class TesteUnitarioServiceKgb : Window
    {
        ServiceReferenceKgb.KgbServiceClient client = new ServiceReferenceKgb.KgbServiceClient();

        public TesteUnitarioServiceKgb()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ModeloCanonico.Custumer custumer = client.GetCustomerByCPF("04986491644");
                textBoxSucesso01.Text = "Pessoa: " + custumer.Nome;
            }
            catch (FaultException<PortabilidadeFault> erro)
            {
                textBoxSucesso01.Text = "Erro " + erro.Detail.CodigoErro + ": " + erro.Detail.Motivo;
            }
            catch (Exception erroGenerico)
            {
                textBoxSucesso01.Text = "Erro de chamada ao webservice: " + erroGenerico;
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
