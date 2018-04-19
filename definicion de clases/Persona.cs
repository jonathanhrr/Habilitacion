using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Npgsql;
//using NpgsqlTypes;




namespace definicion_de_clases
{
    public class Persona
    {
        public static NpgsqlConnection dbcon;
        public static IDbCommand dbcmd;
        public static IDataReader reader;

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
        private int iHuellaDigital;
     
        private string  iTipoExperiencia;
        private IList<Afeccion> lAfeccion = new List<Afeccion>();
        private IList<Cuota> lCuota = new List<Cuota>();
        private IList<Rutina> lRutina = new List<Rutina>();
        private IList<Asistencia> lAsistencia = new List<Asistencia>();

        

        public Persona(string pNombre, string pApellido, int pDni, DateTime pFechaNacimiento, DateTime pFechaIngreso,
                        int pAltura, float pPeso, string pEmail, string pDireccion, int pTelefono, int pNumeroContacto,
                       string pTipoExperiencia, int pHuellaDigital) //constructor clase
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
            this.iTipoExperiencia = pTipoExperiencia;
            this.iHuellaDigital = pHuellaDigital;
            //this.iEstado = pEstado;
        }
        public Persona()
        { }

        //estas propiedades son de solo lectura, debido a que son públicas, 
        //no deben setearse desde fuera de la clase, para ello está el constructor
        public int Dni
        { get { return this.iDni; } }

        public string Apellido
        { get { return this.iApellido; } }

        public string Nombre
        { get { return this.iNombre; } }

        public DateTime FechaNacimiento
        { get { return this.iFechaNacimiento; } }

        public DateTime FechaIngreso
        { get { return this.iFechaIngreso; } }

        public int Altura
        { get { return this.iAltura; } }

        public float Peso
        { get { return this.iPeso; } }

        public string Email
        { get { return this.iEmail; } }

        public string Direccion
        { get { return this.iDireccion; } }

        public int Telefono
        { get { return this.iTelefono; } }

        public int NumeroContacto
        { get { return this.iNumeroContacto; } }

        public int HuellaDigital
        { get { return this.iHuellaDigital; } }

        public string TipoExperiencia
        { get { return iTipoExperiencia; } }

        public void AgregarAfeccion(Afeccion afeccion)
        { lAfeccion.Add(afeccion); }
        public void EliminarAfeccion(Afeccion afeccion)
        { lAfeccion.Remove(afeccion); }

        public void AgregarCuota(Cuota cuota)
        { lCuota.Add(cuota); }
        public void EliminarCuota(Cuota cuota)
        { lCuota.Remove(cuota); }

        public void AgregarRutina(Rutina rutina)
        { lRutina.Add(rutina); }
        public void EliminarRutina(Rutina rutina)
        { lRutina.Add(rutina); }

        public void AgregarAsistencia(Asistencia asistencia)
        { lAsistencia.Add(asistencia); }
        public void EliminarAsistencia(Asistencia asistencia)
        { lAsistencia.Add(asistencia); }


        public static void Open()
        {
            string connectionString =
                "Server=localhost;" +
                "Database=Gimnasio1.2;" +
                "User ID=postgres;" +
                "Password=123456;";
            dbcon = new NpgsqlConnection(connectionString);
            dbcon.Open();
            dbcmd = dbcon.CreateCommand();
        }

        public static void Close()
        {
            dbcon.Close();
        }

        public static DataSet GetClients()
        {
            Open();
            NpgsqlDataAdapter myDataAdapter = new NpgsqlDataAdapter("SELECT * FROM cliente ;", dbcon);
            DataSet ds = new DataSet();
            myDataAdapter.Fill(ds,"cliente");
            return ds;
        }

        public static DataSet BuscarCliente(string pFiltro)
        {
            NpgsqlDataAdapter myDataAdapter = new NpgsqlDataAdapter("SELECT * FROM cliente where nombre like ('" + pFiltro + "');", dbcon);

            DataSet ds = new DataSet();
            myDataAdapter.Fill(ds);
            return ds;
        }
        public static DataTable FiltrarClientes(string pFiltro)
        {
           
            NpgsqlDataAdapter myDataAdapter = new NpgsqlDataAdapter("SELECT * FROM cliente where nombre like ('"+ pFiltro + "%');", dbcon);
           
            DataTable ds = new DataTable();
            myDataAdapter.Fill(ds);
            return ds;
            
        }
        public static DataSet GetProduits()
        {

            NpgsqlDataAdapter myDataAdapter = new NpgsqlDataAdapter("SELECT * FROM produits ORDER BY pkey ASC;", dbcon);
            DataSet ds = new DataSet();
            myDataAdapter.Fill(ds, "Produits"); 
            return ds;
        }

        public static DataSet GetCommandes()
        {
            NpgsqlDataAdapter myDataAdapter = new NpgsqlDataAdapter("SELECT * FROM commandes ORDER BY pkey ASC;", dbcon);
            DataSet ds = new DataSet();
            myDataAdapter.Fill(ds, "Commandes");
            return ds;
        }

        public static DataSet GetProduitCommande()
        {
            NpgsqlDataAdapter myDataAdapter = new NpgsqlDataAdapter("SELECT * FROM produit_commande ORDER BY commande_pkey ASC, produit_pkey ASC;", dbcon);
            DataSet ds = new DataSet();
            myDataAdapter.Fill(ds, "Produit commande");
            return ds;
        }

        public static void ModificarCliente(string pNombre, string pApellido, int pDni, DateTime pFechaNacimiento,
            DateTime pFechaIngreso, float pAltura, float pPeso, string pEmail, string pDireccion,
            string pTelefono, string pNumeroContacto, string pTipoExperiencia)
        {
            try
            {
                Open();
                NpgsqlCommand command = new NpgsqlCommand("UPDATE cliente SET nombre= :pNombre, apellido= :pApellido, altura= :pAltura, peso= :pPeso, telefono= :pTelefono, direccion= :pDireccion, experiencia= :pTipoExperiencia, email= :pEmail   WHERE dni = ('" + pDni + "');", dbcon);
                /*, ,direccion= :pDireccion ,experiencia= :pTipoExperiencia " +
                    ",email= :pEmail  */
                command.Parameters.Add(new NpgsqlParameter("pNombre", DbType.String));
                command.Parameters.Add(new NpgsqlParameter("pApellido", DbType.String));
                //command.Parameters.Add(new NpgsqlParameter("pDni", DbType.Int32));
                //command.Parameters.Add(new NpgsqlParameter("pNumeroContacto", DbType.String));
                //(command.Parameters.Add(new NpgsqlParameter("pFechaNacimiento", DbType.Date));
                //command.Parameters.Add(new NpgsqlParameter("pFechaIngreso", DbType.Date));
                command.Parameters.Add(new NpgsqlParameter("pAltura", DbType.Decimal));
                command.Parameters.Add(new NpgsqlParameter("pPeso", DbType.Decimal));
                command.Parameters.Add(new NpgsqlParameter("pTelefono", DbType.String));
                //command.Parameters.Add(new NpgsqlParameter("iEstado", DbType.Boolean));
                command.Parameters.Add(new NpgsqlParameter("pDireccion", DbType.String));
                command.Parameters.Add(new NpgsqlParameter("pTipoExperiencia", DbType.String));
                command.Parameters.Add(new NpgsqlParameter("pEmail", DbType.String));
                command.Parameters[0].Value = pNombre;
                command.Parameters[1].Value = pApellido;
                //command.Parameters[2].Value = pDni;
                //command.Parameters[3].Value = pNumeroContacto;
                //command.Parameters[3].Value = pFechaNacimiento;
                //command.Parameters[3].Value = pFechaIngreso;
                command.Parameters[2].Value = pAltura;
                command.Parameters[3].Value = pPeso;
                command.Parameters[4].Value = pTelefono;
                command.Parameters[5].Value = pDireccion;
                command.Parameters[6].Value = pTipoExperiencia;
                command.Parameters[7].Value = pEmail;

                //command.Parameters[9].Value = iEstado;
                reader = command.ExecuteReader();
                reader.Close();
               // MessageBox.Show("Modificación exitosa");
            }
            catch(System.Exception ex)
            {
                //MessageBox.Show("Update failed");

            }
        }

        public static void DeleteClient(String pNombre)
        {
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM clients WHERE pkey= :nombre", dbcon);
            command.Parameters.Add(new NpgsqlParameter("nombre", DbType.String));
            command.Parameters[0].Value = pNombre;
            reader = command.ExecuteReader();
            reader.Close();
        }

        /*Agrega cliente con los datos que se cargan en la ventana "cargaCliente", le pasa los datos a el "GestorCliente" quien se lo
         * envia al metodo "AddClient" de esta clase. no carga las fechas*/
        public static void AddClient(string pNombre, string pApellido, int pDni, DateTime pFechaNacimiento,
            DateTime pFechaIngreso, float pAltura, float pPeso, string pEmail, string pDireccion,
            string pTelefono, string pNumeroContacto, string pTipoExperiencia)
        {
            
            //fechaNacimiento, fechaIngreso, numeroContacto
            Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO cliente (nombre ,apellido ,dni ," +
                "altura ,peso ,telefono ,direccion ,experiencia " +
                ",email) VALUES (:pNombre ,:pApellido ,:pDni ," +
                ":pAltura ,:pPeso,:pTelefono ,:pDireccion ,:pExperiencia ,:pEmail);", dbcon);
            command.Parameters.Add(new NpgsqlParameter("pNombre", DbType.String));
            command.Parameters.Add(new NpgsqlParameter("pApellido", DbType.String));
            command.Parameters.Add(new NpgsqlParameter("pDni", DbType.Int32));
            //command.Parameters.Add(new NpgsqlParameter("pNumeroContacto", DbType.String));
            //(command.Parameters.Add(new NpgsqlParameter("pFechaNacimiento", DbType.Date));
            //command.Parameters.Add(new NpgsqlParameter("pFechaIngreso", DbType.Date));
            command.Parameters.Add(new NpgsqlParameter("pAltura", DbType.Decimal));
            command.Parameters.Add(new NpgsqlParameter("pPeso", DbType.Decimal));
            command.Parameters.Add(new NpgsqlParameter("pTelefono", DbType.String));
            //command.Parameters.Add(new NpgsqlParameter("iEstado",DbType.Boolean));
            command.Parameters.Add(new NpgsqlParameter("pExperiencia", DbType.String));
            command.Parameters.Add(new NpgsqlParameter("pDireccion", DbType.String));
            command.Parameters.Add(new NpgsqlParameter("pEmail", DbType.String));
            command.Parameters[0].Value = pNombre;
            command.Parameters[1].Value = pApellido;
            command.Parameters[2].Value = pDni;
            //command.Parameters[3].Value = pNumeroContacto;
            //command.Parameters[3].Value = pFechaNacimiento;
            //command.Parameters[3].Value = pFechaIngreso;
            command.Parameters[3].Value = pAltura;
            command.Parameters[4].Value = pPeso;
            command.Parameters[5].Value = pEmail;
            command.Parameters[6].Value = pDireccion;
            command.Parameters[7].Value = pTelefono;           
            command.Parameters[8].Value = pTipoExperiencia;
            //command.Parameters[9].Value = iEstado;
            //No me esta tomando el dato para la columna estado de la BD, dice que no puede reconocer un 
            //parametro de tipo boolean nose que onda.
            dbcmd = dbcon.CreateCommand();
            reader = command.ExecuteReader();
            
            reader.Close();
            
        }

        public static void UpdateProduit(String id, String label, String prix)
        { }

        public static void DeleteProduit(String id)
        {
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM produits WHERE pkey= :id", dbcon);
            command.Parameters.Add(new NpgsqlParameter("id", DbType.Int32));
            command.Parameters[0].Value = id;
            reader = command.ExecuteReader();
            reader.Close();
        }

        public static void AddProduit(String label, String prix)
        {
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO produits (label,prix) VALUES (:label, :prix);", dbcon);
            command.Parameters.Add(new NpgsqlParameter("label", DbType.String));
            command.Parameters.Add(new NpgsqlParameter("prix", DbType.String));
            command.Parameters[0].Value = label;
            command.Parameters[1].Value = prix;
            dbcmd = dbcon.CreateCommand();
            reader = command.ExecuteReader();
            reader.Close();
        }

        public static void UpdateCommande(String id, String client_pkey, String total)
        {
            NpgsqlCommand command = new NpgsqlCommand("UPDATE commandes SET client_pkey= :client_pkey, total= :total WHERE pkey= :id;", dbcon);
            command.Parameters.Add(new NpgsqlParameter("id", DbType.Int32));
            command.Parameters.Add(new NpgsqlParameter("client_pkey", DbType.String));
            command.Parameters.Add(new NpgsqlParameter("prix", DbType.Double));
            command.Parameters[0].Value = id;
            command.Parameters[1].Value = client_pkey;
            command.Parameters[2].Value = total;
            reader = command.ExecuteReader();
            reader.Close();
        }

        public static void DeleteCommande(String id)
        {
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM commandes WHERE pkey= :id", dbcon);
            command.Parameters.Add(new NpgsqlParameter("id", DbType.Int32));
            command.Parameters[0].Value = id;
            reader = command.ExecuteReader();
            reader.Close();
        }

        public static void AddCommande(String client_pkey)
        {
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO commandes (client_pkey,total) VALUES (:client_pkey, 0);", dbcon);
            command.Parameters.Add(new NpgsqlParameter("client_pkey", DbType.String));
            command.Parameters[0].Value = client_pkey;
            reader = command.ExecuteReader();
            reader.Close();
        }

        public static void UpdateProduitCommande(String commande_pkey, String produit_pkey, String quantite)
        {
            NpgsqlCommand command = new NpgsqlCommand("UPDATE produit_commande SET quantite= :quantite WHERE commande_pkey= :commande_pkey AND produit_pkey= :produit_pkey;", dbcon);
            command.Parameters.Add(new NpgsqlParameter("commande_pkey", DbType.Int32));
            command.Parameters.Add(new NpgsqlParameter("produit_pkey", DbType.Int32));
            command.Parameters.Add(new NpgsqlParameter("quantite", DbType.Double));
            command.Parameters[0].Value = commande_pkey;
            command.Parameters[1].Value = produit_pkey;
            command.Parameters[2].Value = quantite;
            reader = command.ExecuteReader();
            reader.Close();
        }

        public static void DeleteProduitCommande(String commande_pkey, String produit_pkey)
        {
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM produit_commande WHERE commande_pkey= :commande_pkey AND produit_pkey= :produit_pkey", dbcon);
            command.Parameters.Add(new NpgsqlParameter("commande_pkey", DbType.Int32));
            command.Parameters.Add(new NpgsqlParameter("produit_pkey", DbType.Int32));
            command.Parameters[0].Value = commande_pkey;
            command.Parameters[1].Value = produit_pkey;
            reader = command.ExecuteReader();
            reader.Close();
        }

        public static void AddProduitCommande(String commande_pkey, String produit_pkey, String quantite)
        {
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO produit_commande (commande_pkey,produit_pkey,quantite) VALUES (:commande_pkey, :produit_pkey, :quantite);", dbcon);
            command.Parameters.Add(new NpgsqlParameter("commande_pkey", DbType.Int32));
            command.Parameters.Add(new NpgsqlParameter("produit_pkey", DbType.Int32));
            command.Parameters.Add(new NpgsqlParameter("quantite", DbType.Int32));
            command.Parameters[0].Value = commande_pkey;
            command.Parameters[1].Value = produit_pkey;
            command.Parameters[2].Value = quantite;
            dbcmd = dbcon.CreateCommand();
            reader = command.ExecuteReader();
            reader.Close();
        }
    }
}