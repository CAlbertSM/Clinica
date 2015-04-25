using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaSanJose
{
    public class Empleado
    {
        private int codigoEmpleado;
        public int CodigoEmpleado
        {
            get { return codigoEmpleado; }
            set { codigoEmpleado = value; }
        }

        private string numeroIdentidadEmpleado;
        public string NumeroIdentidadEmpleado
        {
            get { return numeroIdentidadEmpleado; }
            set { numeroIdentidadEmpleado = value; }
        }

        private int idTipoEmpleado;
        public int IdTipoEmpleado
        {
            get { return idTipoEmpleado; }
            set { idTipoEmpleado = value; }
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

        private string especialidad;
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        private string genero;
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private string numeroColegiado;
        public string NumeroColegiado
        {
            get { return numeroColegiado; }
            set { numeroColegiado = value; }
        }

        private Usuario usuario = new Usuario();
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private TipoEmpleado tipoEmpleado = new TipoEmpleado();
        public TipoEmpleado TipoEmpleado
        {
            get { return tipoEmpleado; }
            set { tipoEmpleado = value; }
        }

        private List<Prescripcion> prescripciones = new List<Prescripcion>();
        public List<Prescripcion> Prescripciones
        {
            get { return prescripciones; }
            set { prescripciones = value; }
        }

        private List<Consulta> consultas = new List<Consulta>();
        public List<Consulta> Consultas
        {
            get { return consultas; }
            set { consultas = value; }
        }


        public Empleado() { }

        public Empleado(int codigoEmpleado, string numeroIdentidadEmpleado, int idTipoEmpleado, string primer_Nombre,
            string segundo_Nombre, string primer_Apellido, string segundo_Apellido, string direccion, string telefono, string estadoCivil,
            DateTime fechaNac, string especialidad, string genero, string numeroColegiado)
        {
            CodigoEmpleado = codigoEmpleado;
            NumeroIdentidadEmpleado = numeroIdentidadEmpleado;
            IdTipoEmpleado = idTipoEmpleado;
            Primer_Nombre = primer_Nombre;
            Segundo_Nombre = segundo_Nombre;
            Primer_Apellido = primer_Apellido;
            Direccion = direccion;
            Telefono = telefono;
            Especialidad = especialidad;
            FechaNac = fechaNac;
            Especialidad = especialidad;
            Genero = genero;
            NumeroColegiado = numeroColegiado;
        }
    }
}
