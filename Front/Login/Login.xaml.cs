using Code.code;
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
using Front.Profesional;
using Front.Cliente;
using Front.Login;

namespace Front.Login
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            this.combobox_usuarios.SelectedValuePath = "Key";
            this.combobox_usuarios.DisplayMemberPath = "Value";
            this.combobox_usuarios.Items.Add(new KeyValuePair<int,string>(1,"Administrador"));
            this.combobox_usuarios.Items.Add(new KeyValuePair<int, string>(2, "Profesional"));
            this.combobox_usuarios.Items.Add(new KeyValuePair<int, string>(3, "Cliente"));
            

        }

        private void btn_ingresar_Cliente(object sender, RoutedEventArgs e)
        {
            Security ingresar = new Security();
            int valor = (int)this.combobox_usuarios.SelectedValue;
            var rut = txt_rut_cliente.Text;
            var pass = txt_password_cliente.Text;


            var respuesta = ingresar.Login(valor, rut, pass);

            if(respuesta != false)
            {
                this.Close();
                Inicio_Cliente cli = new Inicio_Cliente();
                cli.Show();



            }








            //switch (respuesta)
            //{
            //    case 1: 
            //        Inicio_Administrador admin = new Inicio_Administrador();
            //        this.Close();
            //        admin.Show(); 
            //    break;
            //    case 2:
            //        Inicio_Profesional prof = new Inicio_Profesional();
            //        this.Close();
            //        prof.Show();
            //    break;
            //    case 3:
            //        Inicio_Cliente cli = new Inicio_Cliente();
            //        this.Close();
            //        cli.Show();
            //    break;
            //}


        }

        private void ingresar_profesional(object sender, RoutedEventArgs e)
        {

            Security ingresar = new Security();

            int valor = (int)this.combobox_usuarios.SelectedValue;

            var correo = txt_correo_profesional.Text;
            var password = txt_password_profesional.Text;
            

            var respuesta = ingresar.Login(valor,correo,password);

            if(respuesta != false)
            {

                this.Close();
                Inicio_Profesional prof = new Inicio_Profesional();
                prof.Show();

            }

        }

        private void ingresar_administrador(object sender, RoutedEventArgs e)
        {

            Security ingresar = new Security();
            int valor = (int)this.combobox_usuarios.SelectedValue;
          


           
            var correo = txt_correo_administrado.Text;
            var password = txt_password_administrado.Text;

            var respuesta = ingresar.Login(valor, correo, password);

            if(respuesta != false)
            {
                this.Close();
                Inicio_Administrador admin = new Inicio_Administrador();
                admin.Show();


            }


        }

        private void combobox_usuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int valor = (int)this.combobox_usuarios.SelectedValue;

            if (valor == 1)
            {
                this.grid_profesional.Visibility = Visibility.Hidden;
                this.grid_cliente.Visibility = Visibility.Hidden;

                if (!this.grid_administrador.Visibility.Equals("Hidden"))
                {
                    this.grid_administrador.Visibility = Visibility.Visible;
                }

            }

            if (valor == 2)
            {
                this.grid_administrador.Visibility = Visibility.Hidden;
                this.grid_cliente.Visibility = Visibility.Hidden;
                if (!this.grid_profesional.Visibility.Equals("Hidden"))
                {
                    this.grid_profesional.Visibility = Visibility.Visible;
                }
            }

            if (valor == 3)
            {
                this.grid_administrador.Visibility = Visibility.Hidden;
                this.grid_profesional.Visibility = Visibility.Hidden;

                if (!this.grid_cliente.Visibility.Equals("Hidden"))
                {
                    this.grid_cliente.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
