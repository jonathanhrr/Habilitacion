using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
namespace definicion_de_clases
{
    public class Cuota
    {
        private int iNumeroCuota;
        private DateTime iFechaPago;
        private float iMonto;
        private bool iEstado;
        public static NpgsqlConnection dbcon;
        public static IDbCommand dbcmd;
        public static IDataReader reader;

        public Cuota(int pNumeroCuota, DateTime pFechaPago, float pMonto, bool pEstado)
        {
            this.iNumeroCuota = pNumeroCuota;
            this.iFechaPago = pFechaPago;
            this.iMonto = pMonto;
            this.iEstado = pEstado;
        }
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

        public static void AgregarCuota(string pEstado, int pNumeroCuota, DateTime pFechaPago, int pIdCuota, double pMonto)
        {

            Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO cuota ( numeroCuota   ," +
                "idCuota , estado,) VALUES (:pNumeroCuota  ," +
                ":pIdCuota ,:pEstado);", dbcon);
            //command.Parameters.Add(new NpgsqlParameter("pEstado", DbType.String));
            command.Parameters.Add(new NpgsqlParameter("pNumeroCuota", DbType.Int32));
            //command.Parameters.Add(new NpgsqlParameter("pFechaPago", DbType.Date));
            command.Parameters.Add(new NpgsqlParameter("pIdCuota", DbType.Int32));
           // command.Parameters.Add(new NpgsqlParameter("pMonto", DbType.Double));

            command.Parameters[0].Value = pNumeroCuota;
            //command.Parameters[1].Value = pFechaPago;
            command.Parameters[1].Value = pIdCuota;
            //command.Parameters[2].Value = pMonto;
            //command.Parameters[3].Value = pEstado;
            dbcmd = dbcon.CreateCommand();
            reader = command.ExecuteReader();

            reader.Close();

        }



        public int NumeroCuota
        { get { return iNumeroCuota; } }
        public DateTime FechaPago
        { get { return iFechaPago; } }
        public float Monto
        { get { return iMonto; } }
        public bool Estado
        { get { return iEstado; } }
    }
}
