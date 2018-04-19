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
using Npgsql;
using NpgsqlTypes;

namespace ClubTerra
{
    public partial class ListarClientes : Form
    {
        private string iCliente;
        public ListarClientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = GestorCliente.ListaDeClientes().Tables[0];
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
            dataGridView1.Columns[8].ReadOnly = true;
            dataGridView1.Columns[9].ReadOnly = true;
            dataGridView1.Columns[10].ReadOnly = true;
            dataGridView1.Columns[11].ReadOnly = true;
            dataGridView1.Columns[12].ReadOnly = true;

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrarClientes_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (GestorCliente.FiltrarClientes(textBox2.Text)).DefaultView;
            this.dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {

           
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row != null)
            {
                //guardamos los datos de la fila en las variables
                iCliente = row.Cells[8].Value.ToString();
                

            }
            
            Form modificarSocio = new modificarCliente(iCliente);
            modificarSocio.Show();
            this.Close();
           
        }
    }
}
