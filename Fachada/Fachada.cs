using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using definicion_de_clases;
using Gestores;


namespace Fachada
{
    public class Fachada
    {
        
        GestorCliente iGestor = new GestorCliente();
    

        public void AgregarCliente(string pNombre, string pApellido, int pDni, DateTime pFechaNacimiento, DateTime pFechaIngreso,
                        int pAltura, float pPeso, string pEmail, string pDireccion, int pTelefono, int pNumeroContacto,
                        TipoExperiencia pTipoExperiencia, int pHuellaDigital)
        {
            iGestor.AgregarCliente(pNombre, pApellido, pDni, pFechaNacimiento, pFechaIngreso,
                         pAltura, pPeso, pEmail, pDireccion, pTelefono, pNumeroContacto,
                         pTipoExperiencia, pHuellaDigital);

        }
        public void ModificarCliente()
        { }
        public void AarDeBajaCliente()
        { }
        public void AgregarNuevaCuota()
        { }
        public void ModificarCuota()
        { }
        public void DarDeBajaCuota()
        { }
        public void agregarNuevaRutina()
        { }
        public void modificarRutina()
        { }
        public void darDeBajaRutina()
        { }
        public void generarCuotasMensuales()
        { }
        public void buscarCliente()
        { }
        public void buscarRutina()
        { }
        public void buscarGasto()
        { }
        public void buscarEjercicio()
        { }
        public void agregarGasto()
        { }
        public void modificarGasto()
        { }
        public void darDeBajaGasto()
        { }
        public void agregarNuevoEjercicio()
        { }
        public void modificarEjercicio()
        { }
        public void darDeBajaEjercicio()
        { }
        public void agregarNuevoTipoDeEjercicio()
        { }
        public void agregarNuevoTipoDeGasto()
        { }





    }
}
