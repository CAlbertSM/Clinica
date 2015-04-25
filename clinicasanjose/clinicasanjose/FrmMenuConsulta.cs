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
    public partial class FrmMenuConsulta : Form
    {

        FrmOpciones opciones;
        Conexion conexion;
        Expediente expedienteEntrante = new Expediente();


        public FrmMenuConsulta(FrmOpciones opciones, Conexion conexion, Expediente expedienteEntrante)
        {
            InitializeComponent();
            this.opciones = opciones;
            this.conexion = conexion;
            this.expedienteEntrante = expedienteEntrante;
            inicializarOpciones();
        }

        private void MenuConsulta_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String opcion = (String)this.cbOpciones.SelectedItem;
            int indice = 1;
            if (opcion.Equals("Nueva Consulta"))
            {
                indice = 0;
            }
            else if (opcion.Equals("Consulta Anterior"))
            {
                indice = 1;
            }
            else if (opcion.Equals("Modificar Consulta"))
            {
                indice = 2;
            }
            else if (opcion.Equals("Eliminar Consulta"))
            {
                indice = 3;
            }

            switch (indice)
            {
                case 0: FrmConsulta consulta1 = new FrmConsulta(indice, opciones, conexion, expedienteEntrante);
                        consulta1.ShowDialog();
                        break;

                case 1: FrmConsulta consulta2 = new FrmConsulta(indice, opciones, conexion, expedienteEntrante);
                        consulta2.ShowDialog();
                        break;
                case 2: FrmConsulta consulta3 = new FrmConsulta(indice, opciones, conexion, expedienteEntrante);
                        consulta3.ShowDialog();
                        break;
                case 3: FrmConsulta consulta4 = new FrmConsulta(indice, opciones, conexion, expedienteEntrante);
                        consulta4.ShowDialog();
                        break;
                default: break; 
            }
        }

        public void inicializarOpciones()
        {
            this.cbOpciones.Items.Clear();
            if (opciones.idTipoEmpleadoLogueado == 1)
            {
                this.cbOpciones.Items.Add("Nueva Consulta");
                this.cbOpciones.Items.Add("Consulta Anterior");
                this.cbOpciones.Items.Add("Modificar Consulta");
                this.cbOpciones.Items.Add("Eliminar Consulta");
            }
            else if (opciones.idTipoEmpleadoLogueado == 2)
            {
                this.cbOpciones.Items.Add("Nueva Consulta");
                this.cbOpciones.Items.Add("Consulta Anterior");
                this.cbOpciones.Items.Add("Modificar Consulta");
                this.cbOpciones.Items.Add("Eliminar Consulta");
            }
            else if (opciones.idTipoEmpleadoLogueado == 3 || opciones.idTipoEmpleadoLogueado == 4)
            {
                this.cbOpciones.Items.Add("Consulta Anterior");
            }
        }
    }
}
