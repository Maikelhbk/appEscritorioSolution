using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Code.entidades;
using Code.entidades.AdministradorEntity;


namespace Code.code.Administrador
{
    public class AdministradorMethod
    {



        public List<PROFESIONAL> ReadAllProfesional()
        {



            using (Datos.Entidades.Entities bbdd = new Datos.Entidades.Entities())
            {

                try
                {


                    var list = (from d in bbdd.PROFESIONAL
                                select d).ToList();


                    return list;
                }
                catch (Exception)
                {

                    return new List<PROFESIONAL>();
                }
            }

        }

        public List<CLIENTE> ReadAllCliente()
        {



            using (Datos.Entidades.Entities bbdd = new Datos.Entidades.Entities())
            {

                try
                {


                    var list = (from d in bbdd.CLIENTE
                                select d).ToList();


                    return list;
                }
                catch (Exception)
                {

                    return new List<CLIENTE>();
                }
            }

        }
        public List<REGISTRO_ALERTA> ReadAllAlertas()
        {



            using (Datos.Entidades.Entities bbdd = new Datos.Entidades.Entities())
            {

                try
                {


                    var list = (from d in bbdd.REGISTRO_ALERTA
                                select d).ToList();


                    return list;
                }
                catch (Exception)
                {

                    return new List<REGISTRO_ALERTA>();
                }
            }

        }
        public List<CONTRATO> ReadAllContrato()
        {



            using (Datos.Entidades.Entities bbdd = new Datos.Entidades.Entities())
            {

                try
                {


                    var list = (from d in bbdd.CONTRATO
                                select d).ToList();


                    return list;
                }
                catch (Exception)
                {

                    return new List<CONTRATO>();
                }
            }

        }
        public List<ACTIVIDAD> ReadAllActividad()
        {



            using (Datos.Entidades.Entities bbdd = new Datos.Entidades.Entities())
            {

                try
                {


                    var list = (from d in bbdd.ACTIVIDAD
                                select d).ToList();


                    return list;
                }
                catch (Exception)
                {

                    return new List<ACTIVIDAD>();
                }
            }

        }
        public List<DETALLE_ACTIVIDAD> ReadAllDetalleActividad()
        {



            using (Datos.Entidades.Entities bbdd = new Datos.Entidades.Entities())
            {

                try
                {


                    var list = (from d in bbdd.DETALLE_ACTIVIDAD
                                select d).ToList();


                    return list;
                }
                catch (Exception)
                {

                    return new List<DETALLE_ACTIVIDAD>();
                }
            }

        }
    }
}
