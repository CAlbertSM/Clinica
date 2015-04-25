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
    public partial class FrmUsuarioCambiarContraseña : Form
    {
        private Usuario usuario;
        private Boolean contraseñaAnterior = false, contraseñaNueva = false, contraseñaNuevaConfirmada = false;
        private FrmLogin login;

        public FrmUsuarioCambiarContraseña()
        {
            InitializeComponent();
        }

        public FrmUsuarioCambiarContraseña(Usuario usuario, FrmLogin login)
        {
            this.usuario = usuario;
            this.login = login;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim().Equals(String.Empty) || !this.textBox1.Text.Trim().Equals(usuario.Contrasena))
            {
                this.errorProvider1.SetError(this.textBox1, "Contraseña Anterior No Coincide.");
                contraseñaAnterior = false;
            }
            else
            {
                contraseñaAnterior = true;
                this.errorProvider1.Clear();
            }
            desbloquearBotonCambiarContraseña();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Trim().Equals(String.Empty))
            {
                this.errorProvider1.SetError(this.textBox2, "Contraseña Nueva debe de ser distinta a\nla contraseña por defecto o distinta de\nuna cadena vacia.");
                contraseñaNueva = false;
            }
            else
            {
                contraseñaNueva = true;
                this.errorProvider1.Clear();
            }
            desbloquearBotonCambiarContraseña();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox3.Text.Trim().Equals(String.Empty) || !this.textBox2.Text.Trim().Equals(this.textBox3.Text.Trim()))
            {
                this.errorProvider1.SetError(this.textBox3, "Contraseña Nueva por confirmar no coincide.");
                contraseñaNuevaConfirmada = false;
            }
            else
            {
                contraseñaNuevaConfirmada = true;
                this.errorProvider1.Clear();
            }
            desbloquearBotonCambiarContraseña();
        }

        private void desbloquearBotonCambiarContraseña()
        {
            if (this.contraseñaAnterior && this.contraseñaNueva && this.contraseñaNuevaConfirmada)
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean r = login.Conexion.actualizarUsuario(usuario.CodigoEmpleado, this.textBox2.Text.Trim());
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void FrmUsuarioCambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void FrmUsuarioCambiarContraseña_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
