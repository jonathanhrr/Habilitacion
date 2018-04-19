using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Asistencia
    {
        private Nullable< DateTime> iFecha;

        public Asistencia(DateTime pFecha)
        {
            this.iFecha = pFecha;
        }
        public Asistencia() {
            this.iFecha = null;
        }
        public DateTime? IFecha { get => iFecha; set => iFecha = value; }
    }
}
