using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definicion_de_clases
{
    public class Rutina
    {
        private DateTime iFechaInicio;
        private int iDuracion;
        private bool iEstado;
        private IList<LineaRutina> lLineaRutina = new List<LineaRutina>();

        public Rutina(DateTime pFechaInicio, int pDuracion, bool pEstado)
           {this.iFechaInicio = pFechaInicio;
            this.iDuracion = pDuracion;
            this.iEstado = pEstado;}

        public DateTime FechaInicio
        { get { return this.iFechaInicio; } }
        public int Duracion
        { get { return this.iDuracion; } }
        public bool Estado
        { get { return this.iEstado; } }

        public void AgregarLineaRutina(LineaRutina lineaRutina)
            {lLineaRutina.Add(lineaRutina);}
        public void EliminarLineaRutina(LineaRutina lineaRutina)
            {lLineaRutina.Remove(lineaRutina);}

    }
}
