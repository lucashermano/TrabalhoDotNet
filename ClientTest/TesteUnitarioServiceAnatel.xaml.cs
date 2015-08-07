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

        }
    }
}
