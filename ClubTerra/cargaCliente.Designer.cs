namespace ClubTerra
{
    partial class cargaCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloDeVentana = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.fechaDeNacimiento = new System.Windows.Forms.Label();
            this.fechaDeIngreso = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.numeroDeContacto = new System.Windows.Forms.Label();
            this.obraSocial = new System.Windows.Forms.Label();
            this.clasificacionDeExperiencia = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tituloDeVentana
            // 
            this.tituloDeVentana.AutoSize = true;
            this.tituloDeVentana.BackColor = System.Drawing.Color.Orange;
            this.tituloDeVentana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tituloDeVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloDeVentana.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tituloDeVentana.Location = new System.Drawing.Point(12, 23);
            this.tituloDeVentana.Name = "tituloDeVentana";
            this.tituloDeVentana.Padding = new System.Windows.Forms.Padding(0, 0, 582, 0);
            this.tituloDeVentana.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tituloDeVentana.Size = new System.Drawing.Size(708, 22);
            this.tituloDeVentana.TabIndex = 0;
            this.tituloDeVentana.Text = "Datos de cliente";
            this.tituloDeVentana.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tituloDeVentana.Click += new System.EventHandler(this.Label1_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.Orange;
            this.nombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nombre.Location = new System.Drawing.Point(12, 62);
            this.nombre.Name = "nombre";
            this.nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nombre.Size = new System.Drawing.Size(65, 20);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre";
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.ForeColor = System.Drawing.Color.Orange;
            this.apellido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apellido.Location = new System.Drawing.Point(12, 97);
            this.apellido.Name = "apellido";
            this.apellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.apellido.Size = new System.Drawing.Size(65, 20);
            this.apellido.TabIndex = 2;
            this.apellido.Text = "Apellido";
            this.apellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.ForeColor = System.Drawing.Color.Orange;
            this.dni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dni.Location = new System.Drawing.Point(12, 132);
            this.dni.Name = "dni";
            this.dni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dni.Size = new System.Drawing.Size(37, 20);
            this.dni.TabIndex = 3;
            this.dni.Text = "DNI";
            this.dni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dni.Click += new System.EventHandler(this.label3_Click);
            // 
            // fechaDeNacimiento
            // 
            this.fechaDeNacimiento.AutoSize = true;
            this.fechaDeNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDeNacimiento.ForeColor = System.Drawing.Color.Orange;
            this.fechaDeNacimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fechaDeNacimiento.Location = new System.Drawing.Point(12, 169);
            this.fechaDeNacimiento.Name = "fechaDeNacimiento";
            this.fechaDeNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fechaDeNacimiento.Size = new System.Drawing.Size(157, 20);
            this.fechaDeNacimiento.TabIndex = 4;
            this.fechaDeNacimiento.Text = "Fecha de nacimiento";
            this.fechaDeNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fechaDeIngreso
            // 
            this.fechaDeIngreso.AutoSize = true;
            this.fechaDeIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDeIngreso.ForeColor = System.Drawing.Color.Orange;
            this.fechaDeIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fechaDeIngreso.Location = new System.Drawing.Point(12, 202);
            this.fechaDeIngreso.Name = "fechaDeIngreso";
            this.fechaDeIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fechaDeIngreso.Size = new System.Drawing.Size(132, 20);
            this.fechaDeIngreso.TabIndex = 5;
            this.fechaDeIngreso.Text = "Fecha de ingreso";
            this.fechaDeIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.ForeColor = System.Drawing.Color.Orange;
            this.altura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.altura.Location = new System.Drawing.Point(12, 235);
            this.altura.Name = "altura";
            this.altura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.altura.Size = new System.Drawing.Size(51, 20);
            this.altura.TabIndex = 6;
            this.altura.Text = "Altura";
            this.altura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.ForeColor = System.Drawing.Color.Orange;
            this.peso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.peso.Location = new System.Drawing.Point(12, 272);
            this.peso.Name = "peso";
            this.peso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.peso.Size = new System.Drawing.Size(45, 20);
            this.peso.TabIndex = 7;
            this.peso.Text = "Peso";
            this.peso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.ForeColor = System.Drawing.Color.Orange;
            this.correo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.correo.Location = new System.Drawing.Point(12, 306);
            this.correo.Name = "correo";
            this.correo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.correo.Size = new System.Drawing.Size(57, 20);
            this.correo.TabIndex = 8;
            this.correo.Text = "Correo";
            this.correo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.ForeColor = System.Drawing.Color.Orange;
            this.direccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.direccion.Location = new System.Drawing.Point(12, 338);
            this.direccion.Name = "direccion";
            this.direccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.direccion.Size = new System.Drawing.Size(75, 20);
            this.direccion.TabIndex = 9;
            this.direccion.Text = "Dirección";
            this.direccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.ForeColor = System.Drawing.Color.Orange;
            this.telefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.telefono.Location = new System.Drawing.Point(12, 373);
            this.telefono.Name = "telefono";
            this.telefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.telefono.Size = new System.Drawing.Size(71, 20);
            this.telefono.TabIndex = 10;
            this.telefono.Text = "Telefono";
            this.telefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.telefono.Click += new System.EventHandler(this.label10_Click);
            // 
            // numeroDeContacto
            // 
            this.numeroDeContacto.AutoSize = true;
            this.numeroDeContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroDeContacto.ForeColor = System.Drawing.Color.Orange;
            this.numeroDeContacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.numeroDeContacto.Location = new System.Drawing.Point(12, 406);
            this.numeroDeContacto.Name = "numeroDeContacto";
            this.numeroDeContacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numeroDeContacto.Size = new System.Drawing.Size(153, 20);
            this.numeroDeContacto.TabIndex = 11;
            this.numeroDeContacto.Text = "Numero de contacto";
            this.numeroDeContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // obraSocial
            // 
            this.obraSocial.AutoSize = true;
            this.obraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obraSocial.ForeColor = System.Drawing.Color.Orange;
            this.obraSocial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.obraSocial.Location = new System.Drawing.Point(8, 441);
            this.obraSocial.Name = "obraSocial";
            this.obraSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.obraSocial.Size = new System.Drawing.Size(91, 20);
            this.obraSocial.TabIndex = 12;
            this.obraSocial.Text = "Experiencia";
            this.obraSocial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.obraSocial.Click += new System.EventHandler(this.obraSocial_Click);
            // 
            // clasificacionDeExperiencia
            // 
            this.clasificacionDeExperiencia.AutoSize = true;
            this.clasificacionDeExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clasificacionDeExperiencia.ForeColor = System.Drawing.Color.Orange;
            this.clasificacionDeExperiencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clasificacionDeExperiencia.Location = new System.Drawing.Point(12, 477);
            this.clasificacionDeExperiencia.Name = "clasificacionDeExperiencia";
            this.clasificacionDeExperiencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clasificacionDeExperiencia.Size = new System.Drawing.Size(60, 20);
            this.clasificacionDeExperiencia.TabIndex = 13;
            this.clasificacionDeExperiencia.Text = "Estado";
            this.clasificacionDeExperiencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(468, 26);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(252, 197);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(468, 26);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(540, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(640, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(252, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(252, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(468, 26);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(252, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(468, 26);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(252, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(468, 26);
            this.textBox4.TabIndex = 21;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(252, 266);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(468, 26);
            this.textBox5.TabIndex = 22;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(252, 300);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(468, 26);
            this.textBox6.TabIndex = 23;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(252, 335);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(468, 26);
            this.textBox7.TabIndex = 24;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(252, 370);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(468, 26);
            this.textBox8.TabIndex = 25;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(252, 403);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(468, 26);
            this.textBox9.TabIndex = 26;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 443);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cargaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(747, 528);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.clasificacionDeExperiencia);
            this.Controls.Add(this.obraSocial);
            this.Controls.Add(this.numeroDeContacto);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.fechaDeIngreso);
            this.Controls.Add(this.fechaDeNacimiento);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.tituloDeVentana);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "cargaCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloDeVentana;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label fechaDeNacimiento;
        private System.Windows.Forms.Label fechaDeIngreso;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label numeroDeContacto;
        private System.Windows.Forms.Label obraSocial;
        private System.Windows.Forms.Label clasificacionDeExperiencia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

