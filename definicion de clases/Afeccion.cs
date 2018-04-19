using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definicion_de_clases
{
    public class Afeccion
    {
        private string iDescripcion; //atributos clase
        private DateTime iFecha;
        public Afeccion(string pDescripcion, DateTime pFecha) //constructor de clase Afeccion
        {
            this.iDescripcion = pDescripcion;
            this.iFecha = pFecha;
        }
        public string Descripcion  //propiedades solo lectura
        { get { return iDescripcion; } }
        public DateTime Fecha
        { get { return iFecha;} }
    }
}
