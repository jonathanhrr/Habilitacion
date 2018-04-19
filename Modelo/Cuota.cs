using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cuota
    {
        private int iNumeroCuota;
        private Nullable<DateTime> iFechaPago;
        private float iMonto;
        private bool iEstado;

        public Cuota(int pNumeroCuota, DateTime pFechaPago, float pMonto, bool pEstado)
        {
            this.iNumeroCuota = pNumeroCuota;
            this.iFechaPago = pFechaPago;
            this.iMonto = pMonto;
            this.iEstado = pEstado;
        }
        public Cuota()
        {
            this.iNumeroCuota = 0;
            this.iFechaPago = null;
            this.iMonto = 0;
            this.iEstado = false;
        }

        public int NumeroCuota { get => iNumeroCuota; set => iNumeroCuota = value; }
        public Nullable<DateTime> FechaPago { get => iFechaPago; set => iFechaPago = value; }
        public float Monto { get => iMonto; set => iMonto = value; }
        public bool Estado { get => iEstado; set => iEstado = value; }
    }
}
