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
    /// Lógica de interacción para Administrador_contrato.xaml
    /// </summary>
    public partial class Administrador_contrato : Window
    {
        public Administrador_contrato()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            AdministradorMethod con = new AdministradorMethod();

            datGrid_ListContrato.ItemsSource = con.ReadAllContrato();
            datGrid_ListContrato.Columns[5].Visibility = Visibility.Collapsed;
            datGrid_ListContrato.Columns[6].Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Inicio_Administrador ini = new Inicio_Administrador();
            ini.Show();
        }
    }
}
