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
    public partial class FrmPrescripcion : Form
    {
        Conexion conexion = new Conexion();
        int numPaciente, idEmpleado;
        List<Prescripcion> prescripciones = new List<Prescripcion>();

        public FrmPrescripcion(int numPacienteC, int idEmpleadoC)
        {
            cargarComponentes(numPacienteC, idEmpleadoC);
            InitializeComponent();

        }

        public FrmPrescripcion()
        {
            InitializeComponent();

        }

        public void cargarComponentes(int numPacienteC, int idEmpleadoC)
        {
            numPaciente = numPacienteC;
            idEmpleado = idEmpleadoC;
            prescripciones = conexion.obtenerPrescipcion();
            foreach (Prescripcion prescribe in prescripciones)
            {
                listBox1.Items.Add(prescribe.NombreMedicamento.GetEnumerator());
                listBox3.Items.Add(prescribe.Dosis.GetEnumerator());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.MedicamentoDosis = this.tbxMedicamento.Text + "#" + this.tbxDosis.Text;
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.insertarPrescripcion(numPaciente, DateTime.Now, idEmpleado, tbxMedicamento.Text, tbxDosis.Text);
            }
            catch (Exception C)
            {
                
                MessageBox.Show( "Error: " + C.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string temporal;
            temporal = listBox1.SelectedIndex.ToString();
            conexion.eliminarPrescripcion(numPaciente);
            cargarComponentes(numPaciente, idEmpleado);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.MedicamentoDosis = this.tbxMedicamento.Text + "#" + this.tbxDosis.Text;
        }


    }
}
