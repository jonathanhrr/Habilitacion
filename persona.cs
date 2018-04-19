using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitacion;
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
    private tipoExperiencia iExperiencia;
    private prueba asd;

    public Persona(string pNombre, string pApellido, int pDni, DateTime pFechaNacimiento, DateTime pFechaIngreso,
                    int pAltura, float pPeso, string pEmail, string pDireccion, int pTelefono, int pNumeroContacto, ) //constructor clase
    {
        this.iNombre = pNombre;
        this.iApellido = pApellido;
        this.iDni = pDni;
        this.iFechaNacimiento = pFechaNacimiento;
        this.tipoExperiencia =new tipoExperiencia;
    }


    //estas propiedades son de solo lectura, debido a que son públicas, 
    //no deben setearse desde fuera de la clase, para ello está el constructor
    public int Dni  
    {
        get { return this.iDni; }
    }
    public string Apellido
    { get { return this.iApellido; }        
    }
    public string Nombre
    { get { return this.iNombre; }
    }
    public DateTime FechaNacimiento {
        get { return this.iFechaNacimiento; }
    }
    public tipoExperiencia tipoExperiencia
    {
        set { iTipoExperiencia = value; }
        get { return iTipoExperiencia; }
    }
}
}