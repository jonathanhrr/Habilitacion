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
    public partial class cargaGasto : Form
    {
        public cargaGasto()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
