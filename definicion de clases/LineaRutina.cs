using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definicion_de_clases
{
    public class LineaRutina
    {
        private DiasSemana iDia;
        private float iPeso;
        private int iCantidadRepeticiones;
        private bool iEstado;
        private Ejercicio iEjercicio;
        public LineaRutina(DiasSemana pDia, float pPeso, int pCantidadRepeticiones, bool pEstado, Ejercicio pEjercicio)
        {
            this.iDia = pDia;
            this.iPeso = pPeso;
            this.iCantidadRepeticiones = pCantidadRepeticiones;
            this.iEstado = pEstado;
            this.iEjercicio = pEjercicio;
        }

        public DiasSemana Dia
        { get { return this.iDia; } }
        public float Peso
        { get { return this.iPeso; } }
        public int CantidadRepeticiones
        { get { return this.iCantidadRepeticiones; } }
        public bool Estado
        { get { return this.iEstado; } }
        public Ejercicio Ejercicio
        {
            get { return this.iEjercicio; }


        }
    }
}