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
            try
            {
                ModeloCanonico.Custumer custumer = client.GetCustomerByCPF("00112233445");
                textBoxErro01.Text = "Pessoa: " + custumer.Nome;
            }
            catch (FaultException<PortabilidadeFault> erro)
            {
                textBoxErro01.Text = "Erro " + erro.Detail.CodigoErro + ": " + erro.Detail.Motivo;
            }
            catch (Exception erroGenerico)
            {
                textBoxErro01.Text = "Erro de chamada ao webservice: " + erroGenerico;
            }
        }

        private void buttonErro02_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ModeloCanonico.Custumer custumer = client.GetCustomerByCPF("88888888888");
                textBoxErro02.Text = "Pessoa: " + custumer.Nome;
            }
            catch (FaultException<PortabilidadeFault> erro)
            {
                textBoxErro02.Text = "Erro " + erro.Detail.CodigoErro + ": " + erro.Detail.Motivo;
            }
            catch (Exception erroGenerico)
            {
                textBoxErro02.Text = "Erro de chamada ao webservice: " + erroGenerico;
            }
        }

        private void buttonSucesso02_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ModeloCanonico.Custumer custumer = client.ObterStatusFinanceiroCliente("04986491644");
                textBoxSucesso02.Text = "Status financeiro cliente: " + custumer.Nome;
            }
            catch (FaultException<PortabilidadeFault> erro)
            {
                textBoxSucesso02.Text = "Erro " + erro.Detail.CodigoErro + ": " + erro.Detail.Motivo;
            }
            catch (Exception erroGenerico)
            {
                textBoxSucesso02.Text = "Erro de chamada ao webservice: " + erroGenerico;
            }
        }

        private void buttonSucesso03_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ModeloCanonico.Custumer custumer = new Custumer();
                custumer.Cpf = "04986491644";
                Acount conta = client.ObterDadosConta(custumer);
                textBoxSucesso03.Text = "Conta do cliente [" + custumer.Cpf+"]: "+conta.Number;
            }
            catch (FaultException<PortabilidadeFault> erro)
            {
                textBoxSucesso03.Text = "Erro " + erro.Detail.CodigoErro + ": " + erro.Detail.Motivo;
            }
            catch (Exception erroGenerico)
            {
                textBoxSucesso03.Text = "Erro de chamada ao webservice: " + erroGenerico;
            }
        }

        private void buttonErro03_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ModeloCanonico.Custumer custumer = client.GetCustomerByCPF("22785426649");
                textBoxErro03.Text = "Pessoa: " + custumer.Nome;
            }
            catch (FaultException<PortabilidadeFault> erro)
            {
                textBoxErro03.Text = "Erro " + erro.Detail.CodigoErro + ": " + erro.Detail.Motivo;
            }
            catch (Exception erroGenerico)
            {
                textBoxErro03.Text = "Erro de chamada ao webservice: " + erroGenerico;
            }
        }

        private void buttonErro04_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ModeloCanonico.Custumer custumer = new Custumer();
                custumer.Cpf = "65290704191";
                Acount conta = client.ObterDadosConta(custumer);
                textBoxErro04.Text = "Conta do cliente [" + custumer.Cpf + "]: " + conta.Number;
            }
            catch (FaultException<PortabilidadeFault> erro)
            {
                textBoxErro04.Text = "Erro " + erro.Detail.CodigoErro + ": " + erro.Detail.Motivo;
            }
            catch (Exception erroGenerico)
            {
                textBoxErro04.Text = "Erro de chamada ao webservice: " + erroGenerico;
            }
        }
    }
}
