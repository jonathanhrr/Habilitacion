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
    public partial class modificarCliente : Form
    {
        public modificarCliente(string pCliente)
        {
            InitializeComponent();
            DataSet iCliente = new DataSet();
            iCliente = (GestorCliente.BuscarCliente(pCliente));
  
            textBox1.Text = iCliente.Tables[0].Rows[0]["nombre"].ToString();
            textBox2.Text = iCliente.Tables[0].Rows[0]["apellido"].ToString();
            textBox3.Text = iCliente.Tables[0].Rows[0]["dni"].ToString();
            textBox4.Text = iCliente.Tables[0].Rows[0]["altura"].ToString();
            textBox5.Text = iCliente.Tables[0].Rows[0]["peso"].ToString();
            textBox6.Text = iCliente.Tables[0].Rows[0]["email"].ToString();
            textBox7.Text = iCliente.Tables[0].Rows[0]["direccion"].ToString();
            textBox8.Text = iCliente.Tables[0].Rows[0]["telefono"].ToString();
            textBox9.Text = iCliente.Tables[0].Rows[0]["experiencia"].ToString();
            textBox10.Text = iCliente.Tables[0].Rows[0]["numeroContacto"].ToString();

        }

        private void peso_Click(object sender, EventArgs e)
        {

        }

        private void numeroDeContacto_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Form listarSocio = new ListarClientes();
            listarSocio.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                GestorCliente.ModificarCliente(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), dateTimePicker1.Value.Date, dateTimePicker2.Value.Date,
                (float)Convert.ToDouble(textBox4.Text), (float)Convert.ToDouble(textBox5.Text),
                         textBox6.Text, textBox7.Text, textBox8.Text, textBox10.Text, textBox9.Text);
                MessageBox.Show("Modificación realizada con exito");
                this.Close();

                Form listarSocio = new ListarClientes();
                listarSocio.Show();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            /*     if (MessageBox.Show("Estas seguro de eliminar este registro ?”, “Eliminar registro", MessageBoxButtons.YesNo.ToString()) == DialogResult.Yes)
             {
                 MessageBox.Show("Registro eliminado");
             }*/
        }
    }
}
