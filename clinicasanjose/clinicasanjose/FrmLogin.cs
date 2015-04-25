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
    public partial class FrmLogin : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private Conexion conexion;
        private FrmOpciones opciones;
        protected internal int idTipoEmpleadoLogueado;
        protected internal int codigoEmpleadoLogueado;


        public Conexion Conexion
        {
            get { return conexion; }
        }

        

        public FrmLogin()
        {
            InitializeComponent();
        }

        public FrmLogin(List<Usuario> usuarios, Conexion conexion, FrmOpciones opciones)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.conexion = conexion;
            this.opciones = opciones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean usuarioExiste = false;
            Boolean contraseñaCorrecta = false;
            Usuario usuarioCorrecto = new Usuario();
            foreach (Usuario user in usuarios)
            {
                if (user.CodigoEmpleado.ToString().Trim().Equals(this.textBox1.Text.Trim()))
                {
                    usuarioExiste = true;
                    usuarioCorrecto = user;
                    if (usuarioCorrecto.Contrasena.Equals(this.textBox2.Text.Trim()))
                    {
                        contraseñaCorrecta = true;
                    }
                    else
                    {
                        contraseñaCorrecta = false;
                    }

                }
            }
            if (usuarioExiste)
            {
                if (usuarioCorrecto.Contrasena.Equals("generica"))
                {
                    FrmUsuarioCambiarContraseña cambiarContraseña = new FrmUsuarioCambiarContraseña(usuarioCorrecto, this);
                    if (cambiarContraseña.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.opciones.cargarBaseDeDatos();
                        usuarios = opciones.usuarios;
                    }
                    
                    this.textBox2.Text = String.Empty;
                    this.textBox2.Focus();
                }
                else
                {
                    if (contraseñaCorrecta)
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        String nombreEmpleadoUsuario = "";
                        foreach(Empleado empleado in opciones.empleados)
                        {
                            if(empleado.CodigoEmpleado == usuarioCorrecto.CodigoEmpleado)
                            {
                                nombreEmpleadoUsuario = empleado.Primer_Nombre + " " + empleado.Primer_Apellido;
                                this.idTipoEmpleadoLogueado = empleado.IdTipoEmpleado;
                                this.codigoEmpleadoLogueado = empleado.CodigoEmpleado;
                                break;
                            }
                        }
                        this.opciones.bienvenida = "Bienvenid@: " + nombreEmpleadoUsuario;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales Incorrectas, verifique antes de ingresar.", "Error: Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas, verifique antes de ingresar.", "Error: Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals(String.Empty))
            {
                this.errorProvider1.SetError(this.textBox1, "Ingrese un Codigo de Usuario.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Equals(String.Empty))
            {
                this.errorProvider1.SetError(this.textBox2, "Ingrese una Contraseña.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }
    }
}
