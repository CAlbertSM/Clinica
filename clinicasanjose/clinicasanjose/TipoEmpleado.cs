using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaSanJose
{
    public class TipoEmpleado
    {
        private int idTipoEmpleado;
        public int IdTipoEmpleado
        {
            get { return idTipoEmpleado; }
            set { idTipoEmpleado = value; }
        }

        private string nombreTipoEmpleado;
        public string NombreTipoEmpleado
        {
            get { return nombreTipoEmpleado; }
            set { nombreTipoEmpleado = value; }
        }

        public TipoEmpleado() { }

        public TipoEmpleado(int idTipoEmpleado, string nombreTipoEmpleado)
        {
            IdTipoEmpleado = idTipoEmpleado;
            NombreTipoEmpleado = nombreTipoEmpleado;
        }
    }
}
