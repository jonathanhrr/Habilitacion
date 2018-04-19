using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubTerra
{
    public partial class menuSocios : Form
    {
        public menuSocios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form agregarSocio = new cargaCliente();
            agregarSocio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mostrarSocio = new ListarClientes();
            mostrarSocio.Show();
            
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
