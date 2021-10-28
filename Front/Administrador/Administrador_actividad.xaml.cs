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
using Code.code.Administrador;

namespace Front.Administrador
{
    /// <summary>
    /// Lógica de interacción para Administrador_actividad.xaml
    /// </summary>
    public partial class Administrador_actividad : Window
    {
        public Administrador_actividad()
        {
            InitializeComponent();
        }

        private void datGrid_ListActividad1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Inicio_Administrador ini = new Inicio_Administrador();
            ini.Show();
        }

        private void datGrid_ListDetalle_Loaded(object sender, RoutedEventArgs e)
        {
            AdministradorMethod det_act = new AdministradorMethod();

            datGrid_ListDetalle.ItemsSource = det_act.ReadAllDetalleActividad();
            datGrid_ListDetalle.Columns[8].Visibility = Visibility.Collapsed;
            datGrid_ListDetalle.Columns[9].Visibility = Visibility.Collapsed;
        }

        private void datGrid_ListActividad_Loaded(object sender, RoutedEventArgs e)
        {
            

            AdministradorMethod act = new AdministradorMethod();

            datGrid_ListActividad.ItemsSource = act.ReadAllActividad();
            datGrid_ListActividad.Columns[3].Visibility = Visibility.Collapsed;
            datGrid_ListActividad.Columns[4].Visibility = Visibility.Collapsed;
        }
    }
}
