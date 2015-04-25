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
    public partial class FrmMenuExpediente : Form
    {
        FrmOpciones opciones;
        Conexion conexion;

        public FrmMenuExpediente(FrmOpciones opciones, Conexion conexion)
        {
            InitializeComponent();
            this.opciones = opciones;
            this.conexion = conexion;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.cbOpciones.SelectedIndex;
            switch (indice)
            {
                case 0: FrmExpediente expediente1 = new FrmExpediente(indice, this.opciones, this.conexion, null);
                    expediente1.ShowDialog();
                    this.Close();
                    break;

                case 1: FrmExpediente expediente2 = new FrmExpediente(indice, this.opciones, this.conexion, null);
                    expediente2.ShowDialog();
                    this.Close();
                    break;
                case 2: FrmExpediente expediente3 = new FrmExpediente(indice, this.opciones, this.conexion, null);
                    expediente3.ShowDialog();
                    this.Close();
                    break;
                case 3: FrmExpediente expediente4 = new FrmExpediente(indice, this.opciones, this.conexion, null);
                    expediente4.ShowDialog();
                    this.Close();
                    break;
                default: break;
            }
        }

        private void FrmMenuExpediente_Load(object sender, EventArgs e)
        {

        }

        private void FrmMenuExpediente_Load_1(object sender, EventArgs e)
        {

        }

        private void FrmMenuExpediente_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
