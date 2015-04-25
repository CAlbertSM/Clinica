using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaSanJose
{
    public class Expediente
    {
        private int numeroExpediente;
        public int NumeroExpediente
        {
            get { return numeroExpediente; }
            set { numeroExpediente = value; }
        }

        private string numeroIdentidadPaciente;
        public string NumeroIdentidadPaciente
        {
            get { return numeroIdentidadPaciente; }
            set { numeroIdentidadPaciente = value; }
        }

        private string primer_Nombre;
        public string Primer_Nombre
        {
            get { return primer_Nombre; }
            set { primer_Nombre = value; }
        }

        private string segundo_Nombre;
        public string Segundo_Nombre
        {
            get { return segundo_Nombre; }
            set { segundo_Nombre = value; }
        }

        private string primer_Apellido;
        public string Primer_Apellido
        {
            get { return primer_Apellido; }
            set { primer_Apellido = value; }
        }

        private string segundo_Apellido;
        public string Segundo_Apellido
        {
            get { return segundo_Apellido; }
            set { segundo_Apellido = value; }
        }

        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private string estadoCivil;
        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        private DateTime fechaNac;
        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        private string genero;
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private List<Consulta> consultas = new List<Consulta>();
        public List<Consulta> Consultas
        {
            get { return consultas; }
            set { consultas = value; }
        }


        public Expediente() { }

        public Expediente(int numeroExpediente, string numeroIdentidadPaciente, string primer_Nombre,
            string segundo_Nombre, string primer_Apellido, string segundo_Apellido, string direccion, string telefono, string estadoCivil,
            DateTime fechaNac, string genero)
        {
            NumeroExpediente = numeroExpediente;
            NumeroIdentidadPaciente = numeroIdentidadPaciente;
            Primer_Nombre = primer_Nombre;
            Segundo_Nombre = segundo_Nombre;
            Primer_Apellido = primer_Apellido;
            Segundo_Apellido = segundo_Apellido;
            Direccion = direccion;
            Telefono = telefono;
            FechaNac = fechaNac;
            Genero = genero;
        }
    }
}
