using System;
using System.Windows;

namespace ClientTest
{
    /// <summary>
    /// Interaction logic for TesteUnitarioServiceAnatel.xaml
    /// </summary>
    public partial class TesteUnitarioServiceYum : Window
    {
        ServiceReferenceYum.YUMServiceSoapClient client = new ServiceReferenceYum.YUMServiceSoapClient();

        public TesteUnitarioServiceYum()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string cpf = "04986491644";
            try
            {
                ServiceReferenceYum.Custumer custumerYum = client.GetCustomerByCPF(cpf);
                if (custumerYum == null)
                {
                    textBoxSucesso.Text = "Cliente inexistente: " + cpf;
                }
                else
                {
                    textBoxSucesso.Text = "Erro no teste de busca do cliente inexistente: " + cpf;
                }
            }
            catch (Exception erro)
            {
                textBoxSucesso.Text = "Erro de chamada ao webservice: " + erro;
            }
        }

        private void buttonSucesso02_Click(object sender, RoutedEventArgs e)
        {
            string cpf = "88888888888";
            try
            {
                ServiceReferenceYum.Custumer custumerYum = client.GetCustomerByCPF(cpf);
                if (custumerYum != null)
                {
                    textBoxSucesso02.Text = "Cliente yum: " + custumerYum.Nome;
                }
                else
                {
                    textBoxSucesso02.Text = "Erro no teste de busca do cliente existente: " + cpf;
                }
            }
            catch (Exception erro)
            {
                textBoxSucesso02.Text = "Erro de chamada ao webservice: " + erro;
            }
        }

        private void buttonSucesso03_Click(object sender, RoutedEventArgs e)
        {
            string cpf = "88888888888";
            try
            {
                ServiceReferenceYum.Custumer custumerYum = client.GetCustomerByCPF(cpf);
                Boolean retorno = client.UpdateCustomer(custumerYum);
                if (retorno)
                {
                    textBoxSucesso03.Text = "Cliente atualizado: " + custumerYum.Nome;
                }
                else
                {
                    textBoxSucesso03.Text = "Erro na atualização do cliente: " + cpf;
                }
            }
            catch (Exception erro)
            {
                textBoxSucesso03.Text = "Erro de chamada ao webservice: " + erro;
            }
        }

        private void buttonErro01_Click(object sender, RoutedEventArgs e)
        {
            string cpf = "88888888888";
            try
            {
                ServiceReferenceYum.Custumer custumerYum = client.GetCustomerByCPF(cpf);
                custumerYum.Cpf = null;
                Boolean retorno = client.UpdateCustomer(custumerYum);
                if (retorno)
                {
                    textBoxErro01.Text = "Cliente atualizado: " + custumerYum.Nome;
                }
                else
                {
                    textBoxErro01.Text = "Erro na atualização do cliente: " + cpf;
                }
            }
            catch (Exception erro)
            {
                textBoxErro01.Text = "Erro de chamada ao webservice: " + erro.Message;
            }
        }

        private void buttonErro02_Click(object sender, RoutedEventArgs e)
        {
            string cpf = "88888888888";
            try
            {
                ServiceReferenceYum.Custumer custumerYum = client.GetCustomerByCPF(cpf);
                custumerYum.Nome = null;
                Boolean retorno = client.UpdateCustomer(custumerYum);
                if (retorno)
                {
                    textBoxErro02.Text = "Cliente atualizado: " + custumerYum.Nome;
                }
                else
                {
                    textBoxErro02.Text = "Erro na atualização do cliente: " + cpf;
                }
            }
            catch (Exception erro)
            {
                textBoxErro02.Text = "Erro de chamada ao webservice: " + erro.Message;
            }
        }

        private void buttonErro03_Click(object sender, RoutedEventArgs e)
        {
            string cpf = "88888888888";
            try
            {
                ServiceReferenceYum.Custumer custumerYum = client.GetCustomerByCPF(cpf);
                custumerYum.EnderecoCompleto = null;
                Boolean retorno = client.UpdateCustomer(custumerYum);
                if (retorno)
                {
                    textBoxErro03.Text = "Cliente atualizado: " + custumerYum.Nome;
                }
                else
                {
                    textBoxErro03.Text = "Erro na atualização do cliente: " + cpf;
                }
            }
            catch (Exception erro)
            {
                textBoxErro03.Text = "Erro de chamada ao webservice: " + erro.Message;
            }
        }

        private void buttonErro04_Click(object sender, RoutedEventArgs e)
        {
            string cpf = "88995267615";
            try
            {
                ServiceReferenceYum.Custumer custumerYum = client.GetCustomerByCPF(cpf);
                Boolean retorno = client.UpdateCustomer(custumerYum);
                if (retorno)
                {
                    textBoxErro04.Text = "Cliente atualizado: " + custumerYum.Nome;
                }
                else
                {
                    textBoxErro04.Text = "Erro na atualização do cliente: " + cpf;
                }
            }
            catch (Exception erro)
            {
                textBoxErro04.Text = "Erro de chamada ao webservice: " + erro.Message;
            }
        }
    }
}
