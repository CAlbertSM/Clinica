using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaSanJose
{
    public class Usuario
    {
        private int codigoEmpleado;
        private string contrasena;

        public int CodigoEmpleado
        {
            get { return codigoEmpleado; }
            set { codigoEmpleado = value; }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public Usuario() { }

        public Usuario(int codigoEmpleado, string contraseña)
        {
            CodigoEmpleado = codigoEmpleado;
            Contrasena = contraseña;
        }
    }
}
