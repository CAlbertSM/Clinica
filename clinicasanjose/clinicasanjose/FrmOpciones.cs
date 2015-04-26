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
            this.empleados = conexion.obtenerEmpleado();
            this.consultas = conexion.obtenerConsulta();
            this.expedientes = conexion.obtenerExpediente();
            this.prescripciones = conexion.obtenerPrescipcion();
            this.tipoEmpleados = conexion.obtenerTiposEmpleado();
            this.usuarios = conexion.obtenerUsuarios();

            foreach (Empleado empleado in empleados)
            {
                foreach (TipoEmpleado tipoempleado in tipoEmpleados)
                {
                    if (tipoempleado.IdTipoEmpleado == empleado.IdTipoEmpleado)
                    {
                        empleado.TipoEmpleado = tipoempleado;
                        break;
                    }
                }

                foreach (Consulta consulta in consultas)
                {
                    if (consulta.CodigoEmpleado == empleado.CodigoEmpleado)
                    {
                        consulta.Empleado = empleado;
                        break;
                    }
                }
            }

            foreach (Prescripcion prescripcion in prescripciones)
            {
                foreach (Empleado empleado in empleados)
                {
                    if (prescripcion.CodigoEmpleado == empleado.CodigoEmpleado)
                    {
                        prescripcion.Empleado = empleado;
                        empleado.Prescripciones.Add(prescripcion);
                    }
                }
            }

            foreach (Expediente expediente in expedientes)
            {
                foreach (Consulta consulta in consultas)
                {
                    if (consulta.NumeroExpediente == expediente.NumeroExpediente)
                    {
                        consulta.Expediente = expediente;
                        expediente.Consultas.Add(consulta);
                    }
                }
            }

            foreach (Consulta consulta in consultas)
            {
                foreach (Prescripcion prescripcion in prescripciones)
                {
                    if (consulta.Fecha.Equals(prescripcion.Fecha) && consulta.NumeroExpediente == prescripcion.NumeroExpediente)
                    {
                        consulta.Prescipciones.Add(prescripcion);
                        prescripcion.Expediente = consulta.Expediente;
                        break;
                    }
                }
            }
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
            emple.Show();
            
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
