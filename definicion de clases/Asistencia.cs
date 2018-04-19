using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definicion_de_clases
{
    public class Asistencia
    {
        private DateTime iFechaAsistencia;
        public Asistencia(DateTime pFechaAsistencia)
        { this.iFechaAsistencia = pFechaAsistencia; }

        public DateTime FechaAsistencia
        { get { return this.iFechaAsistencia; } }
                    
    }
}
