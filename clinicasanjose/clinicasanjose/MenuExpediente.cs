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
    public partial class MenuExpediente : Form
    {
        public MenuExpediente()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.cbOpciones.SelectedIndex;
            switch (indice)
            {
                case 0: Expediente expediente1 = new Expediente(indice);
                    expediente1.Show();
                    this.Close();
                    break;

                case 1: Expediente expediente2 = new Expediente(indice);
                    expediente2.Show();
                    this.Close();
                    break;
                case 2: Expediente expediente3 = new Expediente(indice);
                    expediente3.Show();
                    this.Close();
                    break;
                case 3: Expediente expediente4 = new Expediente(indice);
                    expediente4.Show();
                    this.Close();
                    break;
                default: break;
            }
        }
    }
}
