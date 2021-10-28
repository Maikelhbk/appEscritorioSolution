using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Code.entidades;
using Code.entidades.ProfesionalEntity;
using Code.entidades.Actividades;

namespace Code.code.Profesionales
{
    public class ProfesionalMethod
    {

       

      


        public bool CreateProfesional()
        {
            Datos.Entidades.Entities bbdd = new Datos.Entidades.Entities();
            Datos.Entidades.PROFESIONAL profesional = new Datos.Entidades.PROFESIONAL();

            try
            {
                CommonBC.Syncronize(this, profesional);
                bbdd.PROFESIONAL.Add(profesional);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                bbdd.PROFESIONAL.Remove(profesional);
                return false;
            }
        }
        //public bool ReadProfesional()
        //{
        //    Datos.Entidades.Entities bbdd = new Datos.Entidades.Entities();
        //    try
        //    {
        //        Datos.Entidades.PROFESIONAL pro = bbdd.PROFESIONAL.First(b => b.ID_PROFESIONAL == _lispro.id_profesional);
        //        CommonBC.Syncronize(pro, this);

        //        ObtenerNombreProfesional();


        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        //private void ObtenerNombreProfesional()
        //{
        //    PROFESIONAL id = new PROFESIONAL() { ID_PROFESIONAL = _lispro.id_profesional };
        //    if (id.ReadNombreProfeiosnal())
        //    {
        //         = Rut.NombreContacto;
        //    }
        //    else
        //    {
        //        _nombreContacto = string.Empty;
        //    }
        //}


        public List<DETALLE_ACTIVIDAD> ReadAllActividades( )
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

        //private List<Detalle_Actividad> CasteoActividades(List<DETALLE_ACTIVIDAD> list)
        //{
        //    List<Detalle_Actividad> newList = new List<Detalle_Actividad>();

        //    foreach (DETALLE_ACTIVIDAD datos in list)
        //    {
        //        Detalle_Actividad actividad = new Detalle_Actividad();
        //        CommonBC.Syncronize(datos, actividad);
        //        newList.Add(actividad);

        //    }

        //    return newList;

        //}


    }

}

//string _nombreProfesional;
//string _apellidoprofesional;
//string _telefonoprofesional;
//string _correoprofeiosnal;