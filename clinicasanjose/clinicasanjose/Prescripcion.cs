using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaSanJose
{
    public class Prescripcion
    {
        private int numeroExpediente;
        public int NumeroExpediente
        {
            get { return numeroExpediente; }
            set { numeroExpediente = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private int codigoEmpleado;
        public int CodigoEmpleado
        {
            get { return codigoEmpleado; }
            set { codigoEmpleado = value; }
        }

        private string nombreMedicamento;
        public string NombreMedicamento
        {
            get { return nombreMedicamento; }
            set { nombreMedicamento = value; }
        }

        private string dosis;
        public string Dosis
        {
            get { return dosis; }
            set { dosis = value; }
        }

        private Empleado empleado = new Empleado();
        public Empleado Empleado
        {
            set { empleado = value; }
            get { return empleado; }
        }

        private Expediente expediente = new Expediente();
        public Expediente Expediente
        {
            set { expediente = value; }
            get { return expediente; }
        }

        public Prescripcion() { }

        public Prescripcion(int numeroExpediente, DateTime fecha, int codigoEmpleado, string nombreMedicamento, string dosis)
        {
            NumeroExpediente = numeroExpediente;
            Fecha = fecha;
            CodigoEmpleado = codigoEmpleado;
            NombreMedicamento = nombreMedicamento;
            Dosis = dosis;
        }
    }
}
