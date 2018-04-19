
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
using Gestores;

namespace ClubTerra
{
    public partial class cargaCliente : Form
    {
        Boolean aux;
        //Declaramos la conexion
       /*public static NpgsqlConnection con = new NpgsqlConnection("Server = localhost; Port = 5432; Database = Gimnasio, User = postgres; Password = 1234561");
        
        public NpgsqlCommand cmd = new NpgsqlCommand();
        */

        public static NpgsqlConnection dbcon;
        public static IDbCommand dbcmd;
        public static IDataReader reader;
        private List<String> Estados = new List<String>();
       

        public cargaCliente()
        { 
            InitializeComponent();
            //Boolean aux = true;
            //Le asignamos los esados posible a la lista de estados, para asignarselo al combobox(lista desplegable)
           Estados.Add("Inicial");
           Estados.Add("Intermedio");
           Estados.Add("Avanzando");
           comboBox1.DataSource = Estados;
            //El comando "SelectIndex = 0" hace que siempre que se abra la lista se muetre el primer item.
           comboBox1.SelectedIndex = 0;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           
                    
            


            GestorCliente Gest = new GestorCliente();
            Gest.AgregarCliente(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, (float)Convert.ToDouble( textBox4.Text), (float)Convert.ToDouble(textBox5.Text),
                         textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox1(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void obraSocial_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
    }
}
