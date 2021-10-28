using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.entidades.ProfesionalEntity
{
    public class Profesional
    {

        public int ID_PROFESIONAL { get; set; }

        public int ID_ROL { get; set; }

        public string NOMBRE_PRO { get; set; }

        public string APELLIDO_PRO { get; set; }

        public string TELEFONO_PRO { get; set; }

        public string CORREO_PRO { get; set; }


        public Profesional()
        {
            this.Init();
        }

        private void Init()
        {
            ID_PROFESIONAL = 0;
            ID_ROL = 0;
            NOMBRE_PRO = string.Empty;
            APELLIDO_PRO = string.Empty;
            TELEFONO_PRO = string.Empty;
            CORREO_PRO = string.Empty;

        }




    }
}
