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
        int numExpediente, idEmpleado;
        string nombreMedicamento = "";
        bool cambio = false;
        int numero = 0;
        List<Prescripcion> prescripciones = new List<Prescripcion>();

        public FrmPrescripcion(int numExpedienteC, int idEmpleadoC, int opcion)
        {
            cargarComponentes(numExpedienteC, idEmpleadoC,opcion);
            InitializeComponent();

        }

        public FrmPrescripcion()
        {
            InitializeComponent();

        }

        public void cargarComponentes(int numPacienteC, int idEmpleadoC,int opcion)
        {
            numExpediente = numPacienteC;
            idEmpleado = idEmpleadoC;
            prescripciones = conexion.leerPrescripciones(numExpediente);
            foreach (Prescripcion prescribe in prescripciones)
            {
                listBox1.Items.Add(prescribe.NombreMedicamento.GetEnumerator());
                listBox3.Items.Add(prescribe.Dosis.GetEnumerator());
            }
            if (opcion.Equals(1))
            {
                this.tbxMedicamento.Enabled = false;
                this.tbxDosis.Enabled = false;
                this.button1.Enabled = false;
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

        }

        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    string temporal;
        //    temporal = listBox1.SelectedIndex.ToString();
        //    conexion.eliminarPrescripcion(numExpediente,nombreMedicamento);
        //    cargarComponentes(numExpediente, idEmpleado,2);

        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.MedicamentoDosis = this.tbxMedicamento.Text + "#" + this.tbxDosis.Text;
            try
            {
                if (this.tbxDosis.Text.Equals(String.Empty) && this.tbxMedicamento.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Falta uno de los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.insertarPrescripcion(numExpediente, DateTime.Now, idEmpleado, tbxMedicamento.Text, tbxDosis.Text);
                this.tbxMedicamento.Clear();
                this.tbxDosis.Clear();
            }
            catch (Exception C)
            {

                MessageBox.Show("Error: " + C.Message);
            }
            cargarComponentes(numExpediente, idEmpleado, 2);
        }


        private void button2_Click(object sender, EventArgs e)
        {
           if(cambio.Equals(true))
           {
            conexion.eliminarPrescripcion(numExpediente, nombreMedicamento);
            cargarComponentes(numExpediente, idEmpleado,2);
           }
           else
           {
               MessageBox.Show("Error,no se ha seleccionado ningun medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                nombreMedicamento = listBox1.SelectedItem.ToString();
                cambio = true;
                numero = listBox1.SelectedIndex;
            }
        }


    }
}
