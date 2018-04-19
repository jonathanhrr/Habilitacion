using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using definicion_de_clases;

namespace Gestores
{
    public class GestorCliente
    {
        private IList<Persona> lClientes = new List<Persona>();
        
        private Persona iPersona;
        public GestorCliente()
        { }
       // public DataSet pListaCliente = new DataSet();
        
        public void AgregarCliente(string pNombre, string pApellido, int pDni, DateTime pFechaNacimiento, DateTime pFechaIngreso,
                        float pAltura, float pPeso, string pEmail, string pDireccion, string pTelefono, string pNumeroContacto,
                        string pTipoExperiencia)
        {
            /*/Persona Cliente = new Persona(pNombre,pApellido, pDni,pFechaNacimiento, pFechaIngreso,
                        pAltura,pPeso, pEmail, pDireccion, pTelefono,pNumeroContacto,
                        pTipoExperiencia,pHuellaDigital);
            lClientes.Add(Cliente);*/
            
            Persona.AddClient(pNombre, pApellido, pDni, pFechaNacimiento, pFechaIngreso,
                        pAltura, pPeso, pEmail, pDireccion, pTelefono, pNumeroContacto,
                        pTipoExperiencia);



        }
        public static void ModificarCliente(string pNombre, string pApellido, int pDni, DateTime pFechaNacimiento,
            DateTime pFechaIngreso, float pAltura, float pPeso, string pEmail, string pDireccion,
            string pTelefono, string pNumeroContacto, string pTipoExperiencia)
        {
            Persona.ModificarCliente(pNombre, pApellido, pDni, pFechaNacimiento, pFechaIngreso,
                        pAltura, pPeso, pEmail, pDireccion, pTelefono, pNumeroContacto,
                        pTipoExperiencia);
        }
        public static DataSet BuscarCliente(string pFiltro)
        {
            /*Esto es solo para evitar que muestre error. Hay que hacer una busqueda en la base de datos que nos devuelva
            el cliente que buscamos*/


            return Persona.BuscarCliente(pFiltro);
        }
        public void DarDeBajaCliente(string pApellido, int pDni)
        {
         
        }
        public static DataTable FiltrarClientes(string pFiltro)
        {
            return Persona.FiltrarClientes(pFiltro);
        }

        public static  DataSet ListaDeClientes()
        {
           return Persona.GetClients();
        }
    }

        
}
