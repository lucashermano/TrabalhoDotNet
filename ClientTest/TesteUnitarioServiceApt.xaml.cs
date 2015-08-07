using ModeloCanonico;
using System;
using System.ServiceModel;
using System.Windows;

namespace ClientTest
{
    /// <summary>
    /// Interaction logic for TesteUnitarioServiceAnatel.xaml
    /// </summary>
    public partial class TesteUnitarioServiceApt : Window
    {
        ServiceReferenceApt.AptServiceClient apt = new ServiceReferenceApt.AptServiceClient();

        public TesteUnitarioServiceApt()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ModeloCanonico.Custumer custumer = new ModeloCanonico.Custumer();
            custumer.Cpf = "88888888888";
            ModeloCanonico.Acount acount = new ModeloCanonico.Acount();
            acount.Number = "122345";
            ModeloCanonico.Portability portabilidade = apt.SolicitarBilhetePortabilidade(custumer, acount);
            textBoxSucesso.Text = "Sucesso na chamada ao APT. Número do bilhete: "+portabilidade.Bilhete;
        }

        private void buttonErro01_Click(object sender, RoutedEventArgs e)
        {
            ModeloCanonico.Custumer custumer = new ModeloCanonico.Custumer();
            custumer.Cpf = "04986491644";
            ModeloCanonico.Acount acount = new ModeloCanonico.Acount();
            acount.Number = "122345";
            try
            {
                ModeloCanonico.Portability portabilidade = apt.SolicitarBilhetePortabilidade(custumer, acount);
                textBoxErro01.Text = "Não lançou exceção corretamente.";
            }
            catch (FaultException<PortabilidadeFault> erro)
            {
                textBoxErro01.Text = "Erro "+erro.Detail.CodigoErro+": " + erro.Detail.Motivo;
            }
            catch (Exception erroGenerico)
            {
                textBoxErro01.Text = "Erro de chamada ao webservice: "+ erroGenerico;
            }
            
        }

        private void buttonErro02_Click(object sender, RoutedEventArgs e)
        {
            ModeloCanonico.Custumer custumer = new ModeloCanonico.Custumer();
            custumer.Cpf = "05666561677";
            ModeloCanonico.Acount acount = new ModeloCanonico.Acount();
            acount.Number = "122345";
            try
            {
                ModeloCanonico.Portability portabilidade = apt.SolicitarBilhetePortabilidade(custumer, acount);
                textBoxErro02.Text = "Não lançou exceção corretamente.";
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
    }
}
