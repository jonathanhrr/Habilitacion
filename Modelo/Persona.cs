using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class Persona
    {
        
        private string iNombre;  //atributos clase
        private string iApellido;
        private int iDni;
        private DateTime iFechaNacimiento;
        private DateTime iFechaIngreso;
        private int iAltura;
        private float iPeso;
        private string iEmail;
        private string iDireccion;
        private int iTelefono;
        private int iNumeroContacto;        
        private TipoExperiencia iTipoExperiencia;
        private List<Afeccion> lAfeccion = new List<Afeccion>();
        private List<Asistencia> lAsistencia = new List<Asistencia>();
        private List<Cuota> lCuota = new List<Cuota>();



        public Persona(string pNombre, string pApellido, int pDni, DateTime pFechaNacimiento, DateTime pFechaIngreso,
                        int pAltura, float pPeso, string pEmail, string pDireccion, int pTelefono, int pNumeroContacto,
                        TipoExperiencia pTipoExperiencia) //constructor clase
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iDni = pDni;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iFechaIngreso = pFechaIngreso;
            this.iAltura = pAltura;
            this.iPeso = pPeso;
            this.iEmail = pEmail;
            this.iDireccion = pDireccion;
            this.iTelefono = pTelefono;
            this.iNumeroContacto = pNumeroContacto;
            this.iTipoExperiencia =pTipoExperiencia;            
        }

        public string Nombre { get => iNombre; set => iNombre = value; }
        public string Apellido { get => iApellido; set => iApellido = value; }
        public int Dni { get => iDni; set => iDni = value; }
        public DateTime FechaNacimiento { get => iFechaNacimiento; set => iFechaNacimiento = value; }
        public DateTime FechaIngreso { get => iFechaIngreso; set => iFechaIngreso = value; }
        public int Altura { get => iAltura; set => iAltura = value; }
        public float Peso { get => iPeso; set => iPeso = value; }
        public string Email { get => iEmail; set => iEmail = value; }
        public int Telefono { get => iTelefono; set => iTelefono = value; }
        public int NumeroContacto { get => iNumeroContacto; set => iNumeroContacto = value; }
        public TipoExperiencia TipoExperiencia { get => iTipoExperiencia; set => iTipoExperiencia = value; }
        public List<Afeccion> listaAfeccion { get => lAfeccion; set => lAfeccion = value; }
        public List<Asistencia> listaAsistencia { get => lAsistencia; set => lAsistencia = value; }
        public List<Cuota> listaCuota{ get => lCuota; set => lCuota = value; }
    }
}

