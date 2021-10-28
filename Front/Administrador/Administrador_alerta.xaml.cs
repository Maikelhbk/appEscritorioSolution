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
using Front.Administrador;
using Code.code.Administrador;

namespace Front.Administrador
{
    /// <summary>
    /// Lógica de interacción para Administrador_alerta.xaml
    /// </summary>
    public partial class Administrador_alerta : Window
    {
        public Administrador_alerta()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Inicio_Administrador ini = new Inicio_Administrador();
            ini.Show();
        }

        private void datGrid_ListAlertas_Loaded(object sender, RoutedEventArgs e)
        {
            AdministradorMethod ale = new AdministradorMethod();

            datGrid_ListAlertas.ItemsSource = ale.ReadAllAlertas();
            datGrid_ListAlertas.Columns[6].Visibility = Visibility.Collapsed;
            datGrid_ListAlertas.Columns[7].Visibility = Visibility.Collapsed;
            datGrid_ListAlertas.Columns[8].Visibility = Visibility.Collapsed;
        }
    }
}
