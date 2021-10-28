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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp;
using Code.code;


namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

      
        public MainWindow()
        {
            
            InitializeComponent();

           
        }

       


       



        private void Ingresar_Click(object sender, RoutedEventArgs e)
        {
            var negocio = new Security() ;
            var rut = txtUsuario.Text;
            var pass = pbContrasena.Password;
            var resultado = negocio.Login(rut,pass);

            MessageBox.Show(resultado.ToString());


        }
    }
}
