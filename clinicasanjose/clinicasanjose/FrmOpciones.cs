using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaSanJose
{
    public partial class FrmOpciones : Form
    {
        Conexion conexion = new Conexion();
        internal List<Consulta> consultas = new List<Consulta>();
        internal List<Empleado> empleados = new List<Empleado>();
        internal List<Expediente> expedientes = new List<Expediente>();
        internal List<Prescripcion> prescripciones = new List<Prescripcion>();
        internal List<TipoEmpleado> tipoEmpleados = new List<TipoEmpleado>();
        internal List<Usuario> usuarios = new List<Usuario>();
        internal String bienvenida = "";
        protected internal int idTipoEmpleadoLogueado = 0;
        protected internal int codigoEmpleadoLogueado = 0;

        public void cargarBaseDeDatos()
        {
            this.conexion.cargarBaseDeDatos(); 
            this.empleados = conexion.empleados;
            this.consultas = conexion.consultas;
            this.expedientes = conexion.expedientes;
            this.prescripciones = conexion.prescripciones;
            this.tipoEmpleados = conexion.tipoEmpleados;
            this.usuarios = conexion.usuarios;
        }

        public FrmOpciones()
        {
            cargarBaseDeDatos();
            FrmLogin login = new FrmLogin(this.usuarios, conexion, this);
            if (login.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitializeComponent();
                this.idTipoEmpleadoLogueado = login.idTipoEmpleadoLogueado;
                this.codigoEmpleadoLogueado = login.codigoEmpleadoLogueado;
                this.lblBienvenida.Text = bienvenida;
                inicializarOpciones();
            }
            else
            {
                Environment.Exit(0);
            }
            
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void btExpedientes_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmEmpleados emple = new FrmEmpleados(false, this.conexion, this);
            emple.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmBusqueda busqueda = new FrmBusqueda(this, conexion);
            busqueda.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmMenuExpediente menuexpe = new FrmMenuExpediente(this, conexion);
            menuexpe.ShowDialog();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Opciones_Load(object sender, EventArgs e)
        {

        }

        private void inicializarOpciones()
        {
            if (this.idTipoEmpleadoLogueado == 1)//Admin
            {
                this.pictureBox1.Enabled = this.pictureBox2.Enabled = this.pictureBox3.Enabled = true;
            }
            else if (this.idTipoEmpleadoLogueado == 2)//Medico
            {
                this.pictureBox1.Enabled = false;
                this.pictureBox2.Enabled = this.pictureBox3.Enabled = true;
            }
            else if (this.idTipoEmpleadoLogueado == 3)//Enfermera
            {
                this.pictureBox1.Enabled = false;
                this.pictureBox2.Enabled = this.pictureBox3.Enabled = true;
            }
            else if (this.idTipoEmpleadoLogueado == 2)//Secretaria
            {
                this.pictureBox1.Enabled = this.pictureBox2.Enabled = false;
                this.pictureBox3.Enabled = true;
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin(this.usuarios, conexion, this);
            if (login.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.idTipoEmpleadoLogueado = login.idTipoEmpleadoLogueado;
                this.lblBienvenida.Text = bienvenida;
                this.inicializarOpciones();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
