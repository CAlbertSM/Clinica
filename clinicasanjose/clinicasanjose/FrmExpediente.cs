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
    public partial class FrmExpediente : Form
    {
        FrmOpciones formOpciones;
        Conexion conexion;
        int opciones = -1;
        Expediente expedienteActual = new Expediente();
        bool estado;
        bool estanVacios;
        bool cambiogenero = false;
        bool estadoCivil=false;

        public FrmExpediente(int opcion, FrmOpciones opciones, Conexion conexion, Expediente expedienteEntrante)
        {
            InitializeComponent();
            this.opciones = opcion;
            this.formOpciones = opciones;
            this.conexion = conexion;
            if (opcion == 4)
            {
                expedienteActual = expedienteEntrante;
                cargarExpediente();
            }
        }


        private void Expediente_Load(object sender, EventArgs e)
        {
            this.cmbGeneroPaciente.SelectedIndex = this.cmbEstadoCivilPaciente.SelectedIndex ;
            this.label9.Text = "Fecha: " + DateTime.Today.Date.ToString().Trim();
            switch (opciones)
            {
                case 0://Crear nuevo expediente
                    this.btModificar.Enabled = false;
                    this.btEliminar.Enabled = false;
                    this.btBuscar.Enabled = false;
                    this.txtNumeroExpediente.Enabled = false;
                    break;

                case 1://modificar
                    this.btEliminar.Enabled = false;
                    this.btGuardar.Enabled = false;
                    this.btBuscar.Enabled = false;
                    break;

                case 2: //Eliminar
                    this.btGuardar.Enabled = false;
                    this.btModificar.Enabled = false;
                    this.btBuscar.Enabled = false;
                    this.txtIdPaciente.Enabled = false;
                    this.txtPnombrePaciente.Enabled = false;
                    this.txtSNombrePaciente.Enabled = false;
                    this.txtPApellidoPaciente.Enabled = false;
                    this.txtSApellidoPaciente.Enabled = false;
                    this.cmbGeneroPaciente.Enabled = false;
                    this.FechaNacPaciente.Enabled = false;
                    this.txtDireccionPaciente.Enabled = false;
                    this.cmbEstadoCivilPaciente.Enabled = false;
                    this.txtTelPaciente.Enabled = false;
                    break;
                case 3: // buscar
                    this.btGuardar.Enabled = false;
                    this.btModificar.Enabled = false;
                    this.btEliminar.Enabled = false;
                    //this.txtIdPaciente.Enabled = false;
                    this.txtPnombrePaciente.Enabled = false;
                    this.txtSNombrePaciente.Enabled = false;
                    this.txtPApellidoPaciente.Enabled = false;
                    this.txtSApellidoPaciente.Enabled = false;
                    this.cmbGeneroPaciente.Enabled = false;
                    this.FechaNacPaciente.Enabled = false;
                    this.txtDireccionPaciente.Enabled = false;
                    this.cmbEstadoCivilPaciente.Enabled = false;
                    this.txtTelPaciente.Enabled = false;
                    break;
                case 4:
                    this.btGuardar.Enabled = false;
                    this.btModificar.Enabled = false;
                    this.btEliminar.Enabled = false;
                    this.txtIdPaciente.Enabled = false;
                    this.txtNumeroExpediente.Enabled = false;
                    this.txtPnombrePaciente.Enabled = false;
                    this.txtSNombrePaciente.Enabled = false;
                    this.txtPApellidoPaciente.Enabled = false;
                    this.txtSApellidoPaciente.Enabled = false;
                    this.cmbGeneroPaciente.Enabled = false;
                    this.FechaNacPaciente.Enabled = false;
                    this.txtDireccionPaciente.Enabled = false;
                    this.cmbEstadoCivilPaciente.Enabled = false;
                    this.txtTelPaciente.Enabled = false;
                    break;
                default: break;
            }
            if (opciones == 0)
            {
                conexion.insertarExpediente("ExpedienteNuevo", "", "", "", "", "", "", "", DateTime.UtcNow, "");
                formOpciones.cargarBaseDeDatos();
                foreach (Expediente expediente in formOpciones.expedientes)
                {
                    if (expediente.NumeroIdentidadPaciente.Equals("ExpedienteNuevo"))
                    {
                        expedienteActual = expediente;
                        break;
                    }
                }
                this.txtNumeroExpediente.Text = expedienteActual.NumeroExpediente.ToString().Trim();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuExpediente exp = new FrmMenuExpediente(this.formOpciones, this.conexion);
            exp.Show();
            this.Close();

        }

        private void Expediente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                conexion.eliminarExpediente(expedienteActual.NumeroExpediente);
            }
        }

        private void nExpedienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtNumeroExpediente.Text.Trim().Equals(String.Empty))
            {
                if (this.comprobarCamposNombresNoEstanVacios())
                {
                    MessageBox.Show("No ha ingresado ningun parametro de búsqueda.");
                }
            }
        }

        private Boolean comprobarCamposNombresNoEstanVacios()
        {
            if (!this.txtIdPaciente.Text.Trim().Equals(string.Empty))
            {
                if (this.txtPnombrePaciente.Text.Trim().Equals(String.Empty))
                {
                    if (this.txtSNombrePaciente.Text.Trim().Equals(String.Empty))
                    {
                        if (this.txtPApellidoPaciente.Text.Trim().Equals(String.Empty))
                        {
                            if (this.txtSApellidoPaciente.Text.Trim().Equals(String.Empty))
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
                               
        }

        private Boolean verificarEntradas()
        {
            if (txtIdPaciente.Text.Length > 0 && txtPnombrePaciente.Text.Length>0 && txtSNombrePaciente.Text.Length >0 &&
                txtPApellidoPaciente.Text.Length > 0 && txtSApellidoPaciente.Text.Length> 0 &&
                txtDireccionPaciente.Text.Length > 0 && txtTelPaciente.Text.Length > 0 && cambiogenero.Equals(true) && estadoCivil.Equals(true))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            estado=conexion.actualizarExpediente(expedienteActual.NumeroExpediente, this.txtIdPaciente.Text.Trim(), this.txtPnombrePaciente.Text.Trim(),
                this.txtSNombrePaciente.Text.Trim(), this.txtPApellidoPaciente.Text.Trim(), this.txtSApellidoPaciente.Text.Trim(), this.txtDireccionPaciente.Text.Trim(),
                this.txtTelPaciente.Text.Trim(), this.cmbGeneroPaciente.SelectedItem.ToString().Trim(), DateTime.UtcNow, this.cmbGeneroPaciente.SelectedItem.ToString().Trim()[0].ToString().Trim());
            if (!this.txtIdPaciente.Text.Trim().Equals(String.Empty))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            
        }

        private void txtIdPaciente_TextChanged(object sender, EventArgs e)
        {
            if (this.comprobarCamposNombresNoEstanVacios())
            {
                this.btGuardar.Enabled = true;
            }
            else
            {
                this.btGuardar.Enabled = false;
            }
        }

        private void nExpedienteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (this.txtNumeroExpediente.Text.Equals(String.Empty))
            {
                MessageBox.Show("Indique el N° de Expediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                estado = conexion.buscarExpediente(int.Parse(txtNumeroExpediente.Text));
                txtNumeroExpediente.Clear();

                if (estado.Equals(false))
                {
                    MessageBox.Show("Expediente no encontrado", "Error", MessageBoxButtons.OK);
                }
                txtNumeroExpediente.Clear();
            }
        }

        private void btGuardar_Click_1(object sender, EventArgs e)
        {
            estanVacios = verificarEntradas();

            if (estanVacios.Equals(false))
            {
                estado = conexion.insertarExpediente(txtIdPaciente.Text, txtPnombrePaciente.Text, txtSNombrePaciente.Text, txtPApellidoPaciente.Text,
                txtSApellidoPaciente.Text, txtDireccionPaciente.Text, txtTelPaciente.Text, cmbEstadoCivilPaciente.SelectedItem.ToString(), FechaNacPaciente.Value,
                 cmbGeneroPaciente.SelectedItem.ToString());

                if (estado.Equals(true))
                {
                    MessageBox.Show("Archivo guardado con exito", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El archivo no pudo ser guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtIdPaciente.Clear();
                txtPnombrePaciente.Clear();
                txtSNombrePaciente.Clear();
                txtPApellidoPaciente.Clear();
                txtSApellidoPaciente.Clear();
                txtDireccionPaciente.Clear();
                txtTelPaciente.Clear();
                cmbEstadoCivilPaciente.ResetText();
                FechaNacPaciente.Value = DateTime.Now;
                cmbGeneroPaciente.ResetText();
            }
            else
            {
                MessageBox.Show("Uno de los campos esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (this.txtNumeroExpediente.Text.Equals(String.Empty))
            {
                MessageBox.Show("Indique el N° de Expediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                estanVacios = verificarEntradas();

                if (estanVacios.Equals(false))
                {

                    estado = conexion.actualizarExpediente(int.Parse(txtNumeroExpediente.Text), txtIdPaciente.Text, txtPnombrePaciente.Text, txtSNombrePaciente.Text, txtPApellidoPaciente.Text,
                        txtSApellidoPaciente.Text, txtDireccionPaciente.Text, txtTelPaciente.Text, cmbEstadoCivilPaciente.SelectedItem.ToString(), FechaNacPaciente.Value,
                         cmbGeneroPaciente.SelectedItem.ToString());

                    if (estado.Equals(true))
                    {
                        MessageBox.Show("Archivo Modificado con exito", "Exito", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("El archivo no pudo ser modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtNumeroExpediente.Clear();
                    txtIdPaciente.Clear();
                    txtPnombrePaciente.Clear();
                    txtSNombrePaciente.Clear();
                    txtPApellidoPaciente.Clear();
                    txtSApellidoPaciente.Clear();
                    txtDireccionPaciente.Clear();
                    txtTelPaciente.Clear();
                    cmbEstadoCivilPaciente.ResetText();
                    FechaNacPaciente.Value = DateTime.Now;
                    cmbGeneroPaciente.ResetText();
                }
                else
                {
                    MessageBox.Show("Uno de los campos esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (this.txtNumeroExpediente.Text.Equals(String.Empty))
            {
                MessageBox.Show("Indique el N° de Expediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                estado = conexion.eliminarExpediente(int.Parse(txtNumeroExpediente.Text));

                if (estado.Equals(true))
                {
                    MessageBox.Show("Archivo Eliminado con exito", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El archivo no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtNumeroExpediente.Clear();
            }

        }

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            if (this.txtNumeroExpediente.Text.Equals(String.Empty)) 
            {
                MessageBox.Show("Indique el N° de Expediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                estado = conexion.buscarExpediente(int.Parse(txtNumeroExpediente.Text));
                txtNumeroExpediente.Clear();

                if (estado.Equals(false))
                {
                    MessageBox.Show("Expediente no encontrado", "Error", MessageBoxButtons.OK);
                }
                txtNumeroExpediente.Clear();
            }
            
        }

        private void cmbGeneroPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambiogenero = true;
        }

        private void cmbEstadoCivilPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadoCivil = true;
        }

        private void noIdentidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtIdPaciente.Text.Equals(String.Empty))
            {
                MessageBox.Show("Indique el N° de Identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                estado = conexion.buscarExpedientePorIdentidad(txtIdPaciente.Text);
                txtIdPaciente.Clear();

                if (estado.Equals(false))
                {
                    MessageBox.Show("Expediente no encontrado", "Error", MessageBoxButtons.OK);
                }
                txtNumeroExpediente.Clear();
            }
            
            
        }

        private void cargarExpediente()
        {
            this.txtDireccionPaciente.Text = this.expedienteActual.Direccion.Trim();
            this.FechaNacPaciente.Value = this.expedienteActual.FechaNac;
            this.txtIdPaciente.Text = this.expedienteActual.NumeroIdentidadPaciente.Trim();
            this.txtNumeroExpediente.Text = this.expedienteActual.NumeroExpediente.ToString().Trim();
            this.txtPApellidoPaciente.Text = this.expedienteActual.Primer_Apellido.Trim();
            this.txtPnombrePaciente.Text = this.expedienteActual.Primer_Nombre.Trim();
            this.txtSApellidoPaciente.Text = this.expedienteActual.Segundo_Apellido.Trim();
            this.txtSNombrePaciente.Text = this.expedienteActual.Segundo_Nombre.Trim();
            this.txtTelPaciente.Text = this.expedienteActual.Telefono.Trim();
        }
    }
}
