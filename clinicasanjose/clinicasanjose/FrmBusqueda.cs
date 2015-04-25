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
    public partial class FrmBusqueda : Form
    {
        FrmOpciones opciones;
        Conexion conexion;
        Expediente expedienteActual = new Expediente();

        public FrmBusqueda(FrmOpciones opciones, Conexion conexion)
        {
            InitializeComponent();
            this.opciones = opciones;
            this.conexion = conexion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        
        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                foreach (Expediente expediente in opciones.expedientes)
                {
                    if (expediente.NumeroExpediente == Convert.ToInt32(this.textBox1.Text))
                    {
                        expedienteActual = expediente;
                        break;
                    }
                }
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                foreach (Expediente expediente in opciones.expedientes)
                {
                    String nombre = expediente.Primer_Nombre.Trim() + expediente.Segundo_Nombre.Trim() + expediente.Primer_Apellido.Trim() +
                        expediente.Segundo_Apellido.Trim();
                    if (nombre.Equals(nombre, StringComparison.InvariantCultureIgnoreCase))
                    {
                        expedienteActual = expediente;
                        break;
                    }
                }
            }

            if (expedienteActual.NumeroExpediente != 0 && expedienteActual.NumeroIdentidadPaciente != null)
            {
                FrmMenuConsulta menuConsulta = new FrmMenuConsulta(opciones, conexion, expedienteActual);
                menuConsulta.ShowDialog();
                this.Close();
            }
            else
            {
                FrmCrearExpediente crearExp = new FrmCrearExpediente(opciones, conexion);
                crearExp.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals(String.Empty))
            {
                this.button1.Enabled = false;
            }
            else
            {
                this.button1.Enabled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }
    }
}
