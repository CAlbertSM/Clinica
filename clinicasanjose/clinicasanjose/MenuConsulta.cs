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
    public partial class MenuConsulta : Form
    {
        public MenuConsulta()
        {
            InitializeComponent();
        }

        private void MenuConsulta_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.cbOpciones.SelectedIndex;
            

            switch (indice)
            {
                case 0: Consulta consulta1 = new Consulta(indice);
                        consulta1.Show();
                        this.Close();
                        break;

                case 1: Consulta consulta2 = new Consulta(indice);
                        consulta2.Show();
                        this.Close();
                        break;
                case 2: Consulta consulta3 = new Consulta(indice);
                        consulta3.Show();
                        this.Close();
                        break;
                case 3: Consulta consulta4 = new Consulta(indice);
                        consulta4.Show();
                        this.Close();
                        break;
                default: break; 
            }
        }
    }
}
