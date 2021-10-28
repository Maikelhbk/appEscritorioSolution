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
using Front.Login;
using Code.code.Administrador;
using Front.Administrador;

namespace Front.Administrador
{
    /// <summary>
    /// Lógica de interacción para Inicio_Administrador.xaml
    /// </summary>
    public partial class Inicio_Administrador : Window
    {
        public Inicio_Administrador()
        {
            InitializeComponent();
        }

        private void Button_CerrarSesion(object sender, RoutedEventArgs e)
        {
            this.Close();
            Login.Login log = new Login.Login();
            log.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void datGrid_ListClientes_Loaded(object sender, RoutedEventArgs e)
        {
            AdministradorMethod cli = new AdministradorMethod();
            
            datGrid_ListClientes.ItemsSource = cli.ReadAllCliente();
            datGrid_ListClientes.Columns[9].Visibility = Visibility.Collapsed;
            datGrid_ListClientes.Columns[10].Visibility = Visibility.Collapsed;
            datGrid_ListClientes.Columns[11].Visibility = Visibility.Collapsed;
            datGrid_ListClientes.Columns[12].Visibility = Visibility.Collapsed;
            datGrid_ListClientes.Columns[13].Visibility = Visibility.Collapsed;
            datGrid_ListClientes.Columns[14].Visibility = Visibility.Collapsed;
        }

        private void datGrid_ListProfesionales_Loaded(object sender, RoutedEventArgs e)
        {
            AdministradorMethod pro = new AdministradorMethod();

            datGrid_ListProfesionales.ItemsSource = pro.ReadAllProfesional();
            datGrid_ListProfesionales.Columns[9].Visibility = Visibility.Collapsed;
            datGrid_ListProfesionales.Columns[10].Visibility = Visibility.Collapsed;
            datGrid_ListProfesionales.Columns[11].Visibility = Visibility.Collapsed;
            datGrid_ListProfesionales.Columns[12].Visibility = Visibility.Collapsed;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            Administrador_alerta ale = new Administrador_alerta();
            ale.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            Administrador_contrato con = new Administrador_contrato();
            con.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            Administrador_actividad act = new Administrador_actividad();
            act.Show();
        }
    }
}
