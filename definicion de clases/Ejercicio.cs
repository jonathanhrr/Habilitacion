using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definicion_de_clases
{
    public class Ejercicio
    {
        private string iNombre;
        private string iDescripcion;
        private bool iEstado;
        private TipoEjercicio iTipoEjercicio;

        public Ejercicio(string pNombre, string pDescripcion, bool pEstado, TipoEjercicio pTipoEjercicio)
        {
            this.iNombre = pNombre;
            this.iDescripcion = pDescripcion;
            this.iEstado = pEstado;
            this.iTipoEjercicio = pTipoEjercicio;
        }
        public string Nombre
        { get { return this.iNombre; } }
        public string Descripcion
        {get { return this.iDescripcion; } }
        public bool Estado
        { get { return this.iEstado; } }
        public TipoEjercicio TipoEjercicio
        { get { return this.iTipoEjercicio; } }

    }
}
