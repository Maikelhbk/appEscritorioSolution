using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code.entidades;
using Datos.Entidades;

namespace Code.code
{
    public class Security
    {

     public  bool Login(int rol, string user, string pass)
        {

            switch (rol)
            {
                case 1: return Login_Administrador(user,pass);
                 
                case 2:
                    return Login_Profesional(user, pass);

                case 3:
                    return Login_Cliente(user, pass);
                default:
                    return false;
                   
            }




        }


        private bool Login_Cliente(string user, string pass)
        {


            try
            {
                using (Entities db = new Entities())
                {

                    var resultado = (from d in db.CLIENTE
                               where d.RUT_CLIENTE == user.Trim() &&
                               d.CONTRASENA_CLIENTE == pass.Trim()
                               select d).FirstOrDefault();
                    if(resultado != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                    

                }
               ;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        private bool Login_Profesional(string user, string pass)
        {

            try{
                using (Entities db = new Entities()){

                    var resultado = (from d in db.PROFESIONAL
                               where d.CORREO_PRO == user.Trim() &&
                               d.CONTRASENA_PRO == pass.Trim()
                               select d).FirstOrDefault();



                    if (resultado != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }




                }


               



            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private bool Login_Administrador(string user, string pass)
        {

            try
            {
                using (Entities db = new Entities())
                {

                    var resultado = (from d in db.ADMINISTRADOR
                               where d.CORREO_ADM == user.Trim() &&
                               d.CONTRASENA_ADM == pass.Trim()
                               select d).FirstOrDefault();

                    if (resultado != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
