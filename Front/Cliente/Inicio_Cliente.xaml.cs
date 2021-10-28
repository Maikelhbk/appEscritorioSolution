using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Front.Cliente
{
    /// <summary>
    /// Lógica de interacción para Inicio_Cliente.xaml
    /// </summary>
    public partial class Inicio_Cliente : Window
    {
        public Inicio_Cliente()
        {
            InitializeComponent();
        }

        private void cerrarSesion_Cliente(object sender, RoutedEventArgs e)
        {
            this.Close();
            Login.Login log = new Login.Login();
            log.Show();
        }
    }
}
