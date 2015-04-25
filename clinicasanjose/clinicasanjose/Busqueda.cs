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
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuConsulta menuConsulta = new MenuConsulta();
            menuConsulta.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearExpediente crearExp = new CrearExpediente();
            crearExp.Show();
        
        }
    }
}
