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
    public partial class FrmConsulta : Form
    {
        internal int opciones = -1, codigoEmpleadoLogueado = 0, idTipoEmpleadoLogueado = 0;
        FrmOpciones formOpciones;
        Conexion conexion;
        Expediente expedienteConsulta = new Expediente();
        Consulta consultaMasProxima = new Consulta();
        internal DateTime fechaConsulta;

        public FrmConsulta(int opcion, FrmOpciones opciones, Conexion conexion, Expediente expedienteEntrante)
        {
            InitializeComponent();
            this.opciones = opcion;
            this.formOpciones = opciones;
            this.conexion = conexion;
            this.expedienteConsulta = expedienteEntrante;
            this.codigoEmpleadoLogueado = opciones.codigoEmpleadoLogueado;
            this.idTipoEmpleadoLogueado = opciones.idTipoEmpleadoLogueado;
            this.lblCodigoEmpleado.Text = codigoEmpleadoLogueado.ToString().Trim();
            this.lblFecha.Text = DateTime.Today.Day.ToString().Trim() + "/" + DateTime.Today.Month.ToString().Trim() +
                "/" + DateTime.Today.Year.ToString().Trim();
            this.txtNombrePaciente.Text = expedienteEntrante.Primer_Nombre.Trim() + expedienteEntrante.Segundo_Nombre.Trim() +
                expedienteEntrante.Primer_Apellido.Trim() + expedienteEntrante.Segundo_Apellido.Trim();
            this.txtNoExpediente.Text = expedienteConsulta.NumeroExpediente.ToString().Trim();
            this.txtPeso.Focus();

        }

        private void btVerDatosPaciente_Click(object sender, EventArgs e)
        {
           
        }


        private void historialDelPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorial histo = new FrmHistorial(this.formOpciones, this.conexion, this.expedienteConsulta, this);
            histo.Show();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (opciones == 0)
            {
                conexion.insertarConsulta(expedienteConsulta.NumeroExpediente, formOpciones.codigoEmpleadoLogueado, DateTime.Now, decimal.Parse(double.Parse(this.txtTemperatura.Text.Trim()).ToString()),
                    float.Parse(this.txtEstatura.Text.Trim()), this.txtPresion.Text.Trim(), float.Parse(this.txtPeso.Text.Trim()), this.txtDiagnostico.Text.Trim(),
                    this.txtProblema.Text.Trim(), this.txtObservacion.Text.Trim());
                MessageBox.Show("Consulta ha sido añadida con éxito a la Base de Datos.", "Nueva Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formOpciones.cargarBaseDeDatos();
                this.Close();
            }
            else if (opciones == 2)
            {
                conexion.actualizarConsulta(expedienteConsulta.NumeroExpediente, Convert.ToInt32(this.lblCodigoEmpleado.Text.Trim()), this.fechaConsulta, decimal.Parse(double.Parse(this.txtTemperatura.Text.Trim()).ToString()),
                    float.Parse(this.txtEstatura.Text.Trim()), this.txtPresion.Text.Trim(), float.Parse(this.txtPeso.Text.Trim()), this.txtDiagnostico.Text.Trim(),
                    this.txtProblema.Text.Trim(), this.txtObservacion.Text.Trim());
                MessageBox.Show("Consulta ha sido modificada con éxito de la Base de Datos.", "Modificar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formOpciones.cargarBaseDeDatos();
                this.Close();
            }
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            FrmHistorial historial = new FrmHistorial(this.formOpciones, this.conexion, this.expedienteConsulta, this);
            historial.Show();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            switch (opciones)
            {
                case 0:
                    this.lblAccion.Text = "Nueva Consulta";
                    this.btEliminar.Enabled = false; 
                    this.btVerHistorial.Enabled = false;
                    this.btVerPrescripcion.Enabled = false;
                    break;

                case 1:
                    this.lblAccion.Text = "Consulta más reciente de Expediente";
                    this.btEliminar.Enabled = false; 
                    this.btGuardar.Enabled = false;
                    this.btCrearPrescripcion.Enabled = false;
                    cargarUltimaConsulta();
                    break;
                case 2: //modificar
                    this.lblAccion.Text = "Modificar la Consulta del Expediente";
                    this.btEliminar.Enabled = false;
                    this.btGuardar.Enabled = false;
                    this.btVerDatosPaciente.Enabled = false;
                    this.btCrearPrescripcion.Enabled = false;
                    break;
                case 3: //Eliminar
                    this.lblAccion.Text = "Eliminar la Consulta del Expediente";
                    this.btGuardar.Enabled = false;
                    this.btEliminar.Enabled = false;
                    this.btVerDatosPaciente.Enabled = false;
                    this.btCrearPrescripcion.Enabled = false;
                    this.txtDiagnostico.ReadOnly = this.txtEstatura.ReadOnly = this.txtObservacion.ReadOnly = this.txtPeso.ReadOnly =
                        this.txtPresion.ReadOnly = this.txtProblema.ReadOnly = this.txtTemperatura.ReadOnly = true;
                    break;

                default: break;
            }
        }

        private void btVerDatosPaciente_Click_1(object sender, EventArgs e)
        {
            FrmExpediente expe = new FrmExpediente(4, formOpciones, conexion, expedienteConsulta);
            expe.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrescripcion crear = new FrmPrescripcion();
            //DialogResult res = crear.ShowDialog();
            //string prescripcion = "";
            //if (res == DialogResult.OK)
            //{
            crear.cargarComponentes(codigoEmpleadoLogueado, expedienteConsulta.NumeroExpediente,2);
            crear.ShowDialog();
            //}

            //this.cadena = prescripcion;

        }

        private void btVerPrescripcion_Click(object sender, EventArgs e)
        {
            FrmPrescripcion ver = new FrmPrescripcion();
            ver.cargarComponentes(codigoEmpleadoLogueado, expedienteConsulta.NumeroExpediente,1);
            ver.ShowDialog();
            

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            this.btGuardar.Enabled = !isCamposVacios() && isPesoEstaturaTemperaturaValida();
        }

        private Boolean isCamposVacios()
        {
            if (!this.txtPeso.Text.Equals(String.Empty))
            {
                if (!this.txtPresion.Text.Equals(String.Empty))
                {
                    if (!this.txtEstatura.Text.Equals(String.Empty))
                    {
                        if (!this.txtTemperatura.Text.Equals(String.Empty))
                        {
                            if (!this.txtProblema.Text.Equals(String.Empty))
                            {
                                if (!this.txtObservacion.Text.Equals(String.Empty))
                                {
                                    if (!this.txtDiagnostico.Text.Equals(String.Empty))
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

        private Boolean isPesoEstaturaTemperaturaValida()
        {
            double valu;
            float value;
            Boolean peso, estatura, temperatura;
            peso = float.TryParse(this.txtPeso.Text.Trim(), out value);
            estatura = float.TryParse(this.txtEstatura.Text.Trim(), out value);
            temperatura = double.TryParse(this.txtTemperatura.Text.Trim(), out valu);

            return peso && estatura && temperatura;
        }

        private void cargarUltimaConsulta()
        {
            DateTime fechaMasProxima = DateTime.Parse("1900/01/01");
            int comparacion = 2;
            foreach (Consulta consulta in this.expedienteConsulta.Consultas)
            {
                comparacion = DateTime.Compare(consulta.Fecha, fechaMasProxima);
                if (comparacion == 1)
                {
                    this.consultaMasProxima = consulta;
                    comparacion = 2;
                }
            }
            this.txtDiagnostico.ReadOnly = this.txtEstatura.ReadOnly = this.txtObservacion.ReadOnly = this.txtPeso.ReadOnly =
                this.txtPresion.ReadOnly = this.txtProblema.ReadOnly = this.txtTemperatura.ReadOnly = true;
            this.txtDiagnostico.Text = consultaMasProxima.Diagnostico.Trim();
            this.txtEstatura.Text = Math.Round(Convert.ToDouble(consultaMasProxima.Estatura), 2).ToString().Trim();
            this.txtObservacion.Text = consultaMasProxima.Observacion.Trim();
            this.txtPeso.Text = Math.Round(Convert.ToDouble(consultaMasProxima.Peso), 2).ToString().Trim();
            this.txtPresion.Text = consultaMasProxima.PresionArterial.Trim();
            this.txtProblema.Text = consultaMasProxima.Problematica.Trim();
            this.txtTemperatura.Text = Math.Round(consultaMasProxima.Temperatura, 2).ToString().Trim();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            conexion.eliminarConsulta(expedienteConsulta.NumeroExpediente, this.fechaConsulta);
            MessageBox.Show("Consulta ha sido eliminada con éxito de la Base de Datos.", "Modificar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.formOpciones.cargarBaseDeDatos();
            this.Close();
        }

        


    }
}
