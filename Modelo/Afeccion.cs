using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Afeccion
    {
        private string iDescripcion; //atributos clase
        private Nullable<DateTime> iFecha;
        public Afeccion(string pDescripcion, DateTime pFecha) //constructor de clase Afeccion
        {
            this.iDescripcion = pDescripcion;
            this.iFecha = pFecha;
        }
        public Afeccion()
        {
            this.iDescripcion = "";
            this.iFecha = null;
        }
        
        public string Descripcion { get => iDescripcion; set => iDescripcion = value; }
        public DateTime? IFecha { get => iFecha; set => iFecha = value; }
    }
}