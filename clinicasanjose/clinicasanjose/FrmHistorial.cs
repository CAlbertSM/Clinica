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
    public partial class FrmHistorial : Form
    {
        FrmConsulta consulta;
        FrmOpciones formOpciones;
        Conexion conexion;
        Expediente expedienteConsulta = new Expediente();
        internal int selectedRow;

        public FrmHistorial(FrmOpciones opciones, Conexion conexion, Expediente expedienteEntrante, FrmConsulta consulta)
        {
            InitializeComponent();
            this.btVerdatosConsulta.Enabled = false;
            this.formOpciones = opciones;
            this.conexion = conexion;
            this.consulta = consulta;
            this.expedienteConsulta = expedienteEntrante;
            this.dtgHistorial.ReadOnly = true;
            this.dtgHistorial.AllowUserToAddRows = false;
            this.dtgHistorial.AllowUserToDeleteRows = false;
            this.dtgHistorial.AllowUserToResizeColumns = false;
            this.dtgHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgHistorial.MultiSelect = false;
            this.dtgHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorial.DataSource = conexion.obtenerConsultasExpediente(expedienteEntrante.NumeroExpediente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.consulta.fechaConsulta = Convert.ToDateTime(this.dtgHistorial.SelectedRows[0].Cells[1].Value);
            this.consulta.lblCodigoEmpleado.Text = Convert.ToString(this.dtgHistorial.SelectedRows[0].Cells[2].Value).Trim();
            this.consulta.lblFecha.Text = Convert.ToDateTime(this.dtgHistorial.SelectedRows[0].Cells[1].Value).ToString().Substring(0,10).Trim();
            this.consulta.txtDiagnostico.Text = Convert.ToString(this.dtgHistorial.SelectedRows[0].Cells[9].Value).Trim();
            this.consulta.txtEstatura.Text = Math.Round(Convert.ToDouble(float.Parse(this.dtgHistorial.SelectedRows[0].Cells[4].Value.ToString().Trim())), 2).ToString().Trim();
            this.consulta.txtObservacion.Text = Convert.ToString(this.dtgHistorial.SelectedRows[0].Cells[7].Value).Trim();
            this.consulta.txtPeso.Text = Math.Round(Convert.ToDouble(float.Parse(this.dtgHistorial.SelectedRows[0].Cells[6].Value.ToString().Trim())), 2).ToString().Trim();
            this.consulta.txtPresion.Text = Convert.ToString(this.dtgHistorial.SelectedRows[0].Cells[5].Value).Trim();
            this.consulta.txtProblema.Text = Convert.ToString(this.dtgHistorial.SelectedRows[0].Cells[8].Value).Trim();
            this.consulta.txtTemperatura.Text = Math.Round(Convert.ToDecimal(this.dtgHistorial.SelectedRows[0].Cells[3].Value), 2).ToString().Trim();
            if (this.consulta.opciones == 2)
            {
                this.consulta.btGuardar.Enabled = true;
                this.consulta.btEliminar.Enabled = false;
            }
            else if (this.consulta.opciones == 3)
            {
                this.consulta.btEliminar.Enabled = true;
                this.consulta.btGuardar.Enabled = false;
            }
            this.Close();
        }

        private void dtgHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgHistorial.SelectedRows.Count == 0)
            {
                this.btVerdatosConsulta.Enabled = false;
            }
            else
            {
                this.btVerdatosConsulta.Enabled = true;
            }
            selectedRow = e.RowIndex;
        }
    }
}
