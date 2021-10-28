using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class CommonBC
    {
        /// <summary>
        /// Sincroniza los valores de propiedades comunes entre 2 objetos 
        /// </summary>
        /// <param name="origen">Objeto con los valores a copiar hacia el destino.</param>
        /// <param name="destino">Objeto que recibe la copia de los valores en sus propiedades</param>
        internal static void Syncronize(object origen, object destino)
        {
            Type tipo = null;
            PropertyInfo[] propiedades = null;

            tipo = origen.GetType();
            propiedades = tipo.GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                try
                {
                    PropertyInfo propInfo = destino.GetType().GetProperty(propiedad.Name);
                    propInfo.SetValue(destino, propiedad.GetValue(origen, null));
                }
                catch {/* Los valores que no se pueden asignar son ignorados */}
            }
        }
    }
}
