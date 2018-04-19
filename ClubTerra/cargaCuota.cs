using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestores;

namespace ClubTerra
{
    public partial class cargaCuota : Form
    {
        public cargaCuota()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {

            GestorCuota Gest = new GestorCuota();
            Gest.AgregarCuota(comboBox1.Text, Convert.ToInt32(textBox1.Text), dateTimePicker1.Value.Date , Convert.ToInt32(textBox2.Text), Convert.ToDouble(textBox3.Text));
         
        }
    
        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargaCuota_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
