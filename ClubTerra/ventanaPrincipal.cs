using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;


namespace ClubTerra

{
    public partial class ventanaPrincipal : Form
    {
       

        public ventanaPrincipal()
        {
            
            InitializeComponent();

        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Form menuSocio = new menuSocios();
            menuSocio.Show();
        
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form vCuota = new menuCuota();
            vCuota.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form vRutina = new cargaRutina();
            vRutina.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form vEjercicio = new cargaEjercicio();
            vEjercicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form vGasto = new cargaGasto();
            vGasto.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*Form vResumen = new mostrarResumen();
            vResumen.Show();*/
        }
    }
}
