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
    public partial class FrmCrearExpediente : Form
    {
        FrmOpciones opciones;
        Conexion conexion;

        public FrmCrearExpediente(FrmOpciones opciones, Conexion conexion)
        {
            InitializeComponent();
            this.opciones = opciones;
            this.conexion = conexion;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            FrmExpediente expediente = new FrmExpediente(0, opciones, conexion, null);
            expediente.Show();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCrearExpediente_Load(object sender, EventArgs e)
        {

        }
    }
}
