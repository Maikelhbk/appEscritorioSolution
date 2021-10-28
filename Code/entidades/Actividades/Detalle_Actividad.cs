using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.entidades.Actividades
{

    public class Detalle_Actividad
    {

        public int REGISTRO_ACTIVIDAD { get; set; }

        public int ID_ACTIVIDAD { get; set; } 

        public int ID_PROFESIONAL { get; set; }

        public string UBICACION { get; set; }

        public DateTime FECHA_ACTIVIDAD { get; set; }

        public int ASISTENTES { get; set; }

        public string MATERIAL { get; set; }

        public string DESCRIPCION { get; set; }

        public virtual Actividad ACTIVIDAD { get; set; }
  
        public virtual ProfesionalEntity.Profesional PROFESIONAL { get; set; }



    }
}
