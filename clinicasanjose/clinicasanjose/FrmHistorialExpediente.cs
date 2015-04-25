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
    public partial class FrmHistorialExpediente : Form
    {
        bool clic = false;
        int expediente;
        string noIdentidad;
        Conexion conexion = new Conexion();

        public FrmHistorialExpediente()
        {
            expediente = 0;
            noIdentidad = "";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (expediente != 0)
            {
                conexion.buscarConsulta(expediente);
            }
            if (noIdentidad.Length > 0)
            {
                conexion.buscarConsultaIdentidad(noIdentidad);
            }
        }
        //this.Close();

        private void dtgHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clic = true;
        }

        public void recibeExpediente(DataTable tabla, int NumeroExpediente)
        {
            dtgHistorial.DataSource = tabla;
            expediente = NumeroExpediente;
        }

        public void recibeIdentidad(DataTable tabla, string NumeroIdentidad)
        {
            dtgHistorial.DataSource = tabla;
            noIdentidad = NumeroIdentidad;
        }

        public void recibeConsultas(DataTable tabla)
        {
            dtgHistorial.DataSource = tabla;
        }
    }
}
