using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaSanJose
{
    public class Consulta
    {
        private int numeroExpediente;
        private DateTime fecha;
        private int codigoEmpleado;
        private decimal temperatura;
        private float estatura;
        private string presionArterial;
        private float peso;
        private string diagnostico;
        private string problematica;
        private string observacion;
        private Empleado empleado = new Empleado();
        private Expediente expediente = new Expediente();
        private List<Prescripcion> prescipciones = new List<Prescripcion>();
        
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int CodigoEmpleado
        {
            get { return codigoEmpleado; }
            set { codigoEmpleado = value; }
        }
        public decimal Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }
        public float Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }
        public string PresionArterial
        {
            get { return presionArterial; }
            set { presionArterial = value; }
        }
        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }       
        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }       
        public string Problematica
        {
            get { return problematica; }
            set { problematica = value; }
        }      
        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        public int NumeroExpediente
        {
            get { return numeroExpediente; }
            set { numeroExpediente = value; }
        }
        public Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }
        public Expediente Expediente
        {
            get { return expediente; }
            set { expediente = value; }
        }
        public List<Prescripcion> Prescipciones
        {
            get { return prescipciones; }
            set { prescipciones = value; }
        }

        public Consulta() { }

        public Consulta(int numeroExpediente, int CodigoEmpleado, DateTime fecha, decimal temperatura, float estatura, string presionArterial,
            float peso, string diagnostico, string problematica, string observacion)
        {
            NumeroExpediente = numeroExpediente;
            Fecha = fecha;
            Temperatura = temperatura;
            Estatura = estatura;
            PresionArterial = presionArterial;
            Peso = peso;
            Diagnostico = diagnostico;
            Problematica = problematica;
            Observacion = observacion;
            CodigoEmpleado = codigoEmpleado;
        }
    }
}
