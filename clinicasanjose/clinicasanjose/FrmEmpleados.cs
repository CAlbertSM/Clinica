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
    public partial class FrmEmpleados : Form
    {
        Empleado empleadoSeleccionado;
        Boolean EliminacionModificacion;
        Conexion conexion;
        FrmOpciones opciones;

        public Empleado retornarEmpleadoSeleccionado()
        {
            return empleadoSeleccionado;
        }


        public FrmEmpleados(Boolean EliminacionModificacion, Conexion conexion, FrmOpciones opciones)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.opciones = opciones;
            if (EliminacionModificacion)
            {
                this.groupBox1.Enabled = this.btGuardarEmpleado.Enabled = true;
                this.txtDireccionEmpleado.Enabled = this.txtEspecialidad.Enabled = this.FechaNacEmpleado.Enabled = this.txtNoColegiado.Enabled =
                this.txtNoIdentidad.Enabled = this.txtPApellidoEmpleado.Enabled = this.txtPNombreEmpleado.Enabled = this.txtSApellidoEmpleado.Enabled =
                this.txtSNombreEmpleado.Enabled = this.txtTelEmpleado.Enabled = false;
                this.btGuardarEmpleado.Text = "Buscar";
            }
            this.cmbTipoEmpleado.Items.Clear();
            foreach (TipoEmpleado tipo in opciones.tipoEmpleados)
            {
                if (tipo.IdTipoEmpleado != 1)
                {
                    this.cmbTipoEmpleado.Items.Add(tipo.NombreTipoEmpleado.Trim());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void regresarAPantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opciones op = new Opciones();
            //op.Show();
            this.Close();
        }

        private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btGuardarEmpleado_Click(object sender, EventArgs e)
        {
            if (this.txtNoEmpleado.Text != string.Empty &&
                this.txtDireccionEmpleado.Text!= String.Empty &&
                this.txtNoColegiado.Text != String.Empty &&
                this.FechaNacEmpleado.Value  != null  &&
                this.txtNoIdentidad.Text != String.Empty &&
                this.txtPNombreEmpleado.Text != String.Empty &&
                this.txtPApellidoEmpleado.Text != String.Empty &&
                this.cmbGeneroEmpleado.SelectedItem != null &&
                this.cmbTipoEmpleado.SelectedItem != null
                )
            {

                if (this.conexion.InsertarEmpleado(Convert.ToInt32(this.txtNoEmpleado.Text.ToString()), this.txtNoIdentidad.Text.ToString(),
                                                (this.cmbTipoEmpleado.SelectedIndex + 1), this.txtPNombreEmpleado.Text.ToString(),
                                                this.txtSNombreEmpleado.Text.ToString(), this.txtPApellidoEmpleado.Text.ToString(), this.txtSApellidoEmpleado.Text.ToString(), this.txtDireccionEmpleado.Text.ToString(),
                                                this.txtTelEmpleado.Text.ToString(), this.cmbEstadocivilEmpleado.SelectedItem.ToString(),Convert.ToDateTime(this.FechaNacEmpleado.Value), this.txtEspecialidad.Text.ToString(),
                                                this.cmbGeneroEmpleado.SelectedItem.ToString(), this.txtNoColegiado.Text.ToString()))
                {

                    MessageBox.Show("Empleado Agregado Exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.txtNoEmpleado.Clear();
                    this.txtDireccionEmpleado.Clear();
                    this.txtNoColegiado.Clear();
                    this.FechaNacEmpleado.ResetText();
                    this.txtNoIdentidad.Clear();
                    this.txtPNombreEmpleado.Clear();
                    this.txtSNombreEmpleado.Clear();
                    this.txtPApellidoEmpleado.Clear();
                    this.txtSApellidoEmpleado.Clear();
                    this.txtEspecialidad.Clear();
                    this.txtTelEmpleado.Clear();
                    this.cmbGeneroEmpleado.ResetText();
                    this.cmbTipoEmpleado.ResetText();
                    this.opciones.cargarBaseDeDatos();
                }
                else {

                    MessageBox.Show("Ha ocurrido un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                }

             

            }
            else {

                MessageBox.Show("Faltan datos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            
            }

            bool estado;

            if (this.btGuardarEmpleado.Text.Equals("Eliminar"))
            {
                if (this.txtNoEmpleado.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Indique el N° de Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estado = conexion.eliminarEmpleado(int.Parse(txtNoEmpleado.Text));
                    if (estado.Equals(true))
                    {
                        MessageBox.Show("Empleado Eliminado con exito", "Exito", MessageBoxButtons.OK);
                        this.opciones.cargarBaseDeDatos();
                    }
                    else
                    {
                        MessageBox.Show("El empleado no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.txtNoEmpleado.Clear();

                }
            }


            if (this.btGuardarEmpleado.Text.Equals("Buscar"))
            {

                if (this.txtNoEmpleado.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Indique el N° de Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estado = conexion.buscarEmpleado(int.Parse(txtNoEmpleado.Text));
                    this.txtNoEmpleado.Clear();
                    if (estado.Equals(false))
                    {
                        MessageBox.Show("Expediente no encontrado", "Error", MessageBoxButtons.OK);
                    }

                }
            }
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cmbGeneroEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void avanzadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btGuardarEmpleado.Enabled = true;
            this.groupBox1.Enabled = true;
            this.btGuardarEmpleado.Text = "Guardar";
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.groupBox1.Enabled = this.btGuardarEmpleado.Enabled = true;
            this.txtDireccionEmpleado.Enabled = this.txtEspecialidad.Enabled = this.FechaNacEmpleado.Enabled = this.txtNoColegiado.Enabled =
                this.txtNoIdentidad.Enabled = this.txtPApellidoEmpleado.Enabled = this.txtPNombreEmpleado.Enabled = this.txtSApellidoEmpleado.Enabled =
                this.txtSNombreEmpleado.Enabled = this.txtTelEmpleado.Enabled = false;
            this.cmbTipoEmpleado.Enabled = false;
            this.cmbGeneroEmpleado.Enabled = false;
            this.cmbEstadocivilEmpleado.Enabled = false;
            this.btGuardarEmpleado.Text = "Buscar";
        }

        private void eliminarEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.txtDireccionEmpleado.Enabled = this.txtEspecialidad.Enabled = this.FechaNacEmpleado.Enabled = this.txtNoColegiado.Enabled =
                this.txtNoIdentidad.Enabled = this.txtPApellidoEmpleado.Enabled = this.txtPNombreEmpleado.Enabled = this.txtSApellidoEmpleado.Enabled =
                this.txtSNombreEmpleado.Enabled = this.txtTelEmpleado.Enabled = false;
            this.btGuardarEmpleado.Text = "Eliminar";
            //FrmEmpleados empleados = new FrmEmpleados(true, ); //Llamamos a este mismo formulario solo que para realizar la busqueda del empleado a modificar o eliminar
            //empleados.ShowDialog();
            //if (empleados.DialogResult == DialogResult.OK)//Esto lo modifican ustedes para que solo cuando busque de verdad devuelva OK, caso contrario pongan el DialogREsult en CAncel
            //{
            //}
        }

        private void modificarDatosEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmEmpleados empleados = new FrmEmpleados(true); //Llamamos a este mismo formulario solo que para realizar la busqueda del empleado a modificar o eliminar
            //empleados.ShowDialog();
            //if (empleados.DialogResult == DialogResult.OK)//Esto lo modifican ustedes para que solo cuando busque de verdad devuelva OK, caso contrario pongan el DialogREsult en CAncel
            //{
            //}
            this.btGuardarEmpleado.Text = "Guardar";
        }


        private void Busqueda()//Aqui van a poner el codigo de busqueda y en donde van a modificar el DialogResult del Form en OK o Cancel.
        {
            //Cuando haya realizado la busqueda deben de guardar el empleado que busco en la propiedad empleadoSeleccionado de este form.
        }

        private void txtNoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Caracter no Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {


            }

        }

        private void txtNoColegiado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Caracter no Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {


            }

        }

        private void txtNoIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)  && (e.KeyChar != Convert.ToChar('-')))
            {
                //MessageBox.Show("Caracter no Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {


            }
        }

        private void txtNoIdentidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPNombreEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Caracter no Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {


            }

        }

        private void txtSNombreEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Caracter no Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {


            }
        }

        private void txtPApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Caracter no Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {


            }
        }

        private void txtSApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Caracter no Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {


            }
        }

        private void txtTelEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != Convert.ToChar('-')))
            {
                //MessageBox.Show("Caracter no Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
