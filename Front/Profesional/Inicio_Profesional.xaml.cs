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
using Code.code.Profesionales;
using Code.entidades.Actividades;


namespace Front.Profesional
{
    /// <summary>
    /// Lógica de interacción para Inicio_Profesional.xaml
    /// </summary>
    public partial class Inicio_Profesional : Window
    {


       

     

        public Inicio_Profesional()
        {
            InitializeComponent();
            
        }

       


        private void Button_CerrarSesion(object sender, RoutedEventArgs e)
        {

            this.Close();
            Login.Login log = new Login.Login();
            log.Show();

        }

        private void Load(object sender, RoutedEventArgs e)
        {
            ProfesionalMethod pro = new ProfesionalMethod();
            
            datGrid_ListActividades.ItemsSource = pro.ReadAllActividades();
            datGrid_ListActividades.Columns[8].Visibility = Visibility.Collapsed;
            datGrid_ListActividades.Columns[9].Visibility = Visibility.Collapsed;
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            ProfesionalMethod ale = new ProfesionalMethod();

            datGrid_ListAlertas.ItemsSource = ale.ReadAllAlertas();
            datGrid_ListAlertas.Columns[6].Visibility = Visibility.Collapsed;
            datGrid_ListAlertas.Columns[7].Visibility = Visibility.Collapsed;
            datGrid_ListAlertas.Columns[8].Visibility = Visibility.Collapsed;
        }
    }
}
