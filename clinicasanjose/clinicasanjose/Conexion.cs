using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ClinicaSanJose
{
    public class Conexion
    {
        //private String cadenaConexion = "Data Source=.\\MSSQLSERVER2012;Initial Catalog=Clinica;Integrated Security=True";
        private String cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Clinica;Integrated Security=True";
        private SqlConnection conexion;
        internal List<Consulta> consultas = new List<Consulta>();
        internal List<Empleado> empleados = new List<Empleado>();
        internal List<Expediente> expedientes = new List<Expediente>();
        internal List<Prescripcion> prescripciones = new List<Prescripcion>();
        internal List<TipoEmpleado> tipoEmpleados = new List<TipoEmpleado>();
        internal List<Usuario> usuarios = new List<Usuario>();

        public Conexion()
        {
            this.conexion = new SqlConnection(this.cadenaConexion);
        }

        #region Usuario
        public List<Usuario> obtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            SqlCommand comando = new SqlCommand("seleccionarUsuarios", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                usuarios.Add(new Usuario(lector.GetInt32(0), lector.GetString(1)));
            }
            lector.Close();
            this.conexion.Close();
            return usuarios;
        }

        public Boolean actualizarUsuario(Int32 CodigoEmpleado, String Contraseña)
        {
            SqlCommand comando = new SqlCommand("actualizaUsuario", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter codigoEmpleado = comando.Parameters.Add("@CodigoEmpleado", System.Data.SqlDbType.Int);
            codigoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter contraseña = comando.Parameters.Add("@Contrasena", System.Data.SqlDbType.VarChar, 15);
            contraseña.Direction = System.Data.ParameterDirection.Input;

            codigoEmpleado.Value = CodigoEmpleado;
            contraseña.Value = Contraseña;
            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }
        #endregion

        #region TipoEmpleado
        public List<TipoEmpleado> obtenerTiposEmpleado()
        {
            List<TipoEmpleado> tiposEmpleado = new List<TipoEmpleado>();

            SqlCommand comando = new SqlCommand("seleccionarTiposEmpleado", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tiposEmpleado.Add(new TipoEmpleado(lector.GetInt32(0), lector.GetString(1)));
            }
            lector.Close();
            this.conexion.Close();
            return tiposEmpleado;
        }

        public Boolean actualizarTipoEmpleado(Int32 IdTipoEmpleado, String NombreTipoEmpleado)
        {
            SqlCommand comando = new SqlCommand("actualizarTipoEmpleado", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idTipoEmpleado = comando.Parameters.Add("@IdTipoEmpleado", System.Data.SqlDbType.Int);
            idTipoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter nombreTipoEmpleado = comando.Parameters.Add("@NombreTipoEmpleado", System.Data.SqlDbType.VarChar, 20);
            nombreTipoEmpleado.Direction = System.Data.ParameterDirection.Input;

            idTipoEmpleado.Value = IdTipoEmpleado;
            nombreTipoEmpleado.Value = NombreTipoEmpleado;
            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public Boolean eliminarTipoEmpleado(Int32 IdTipoEmpleado)
        {
            SqlCommand comando = new SqlCommand("eliminarTipoEmpleado", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idTipoEmpleado = comando.Parameters.Add("@IdTipoEmpleado", System.Data.SqlDbType.Int);
            idTipoEmpleado.Direction = System.Data.ParameterDirection.Input;

            idTipoEmpleado.Value = IdTipoEmpleado;
            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public Boolean insertarTipoEmpleado(Int32 IdTipoEmpleado, String NombreTipoEmpleado)
        {
            SqlCommand comando = new SqlCommand("insertarTipoEmpleado", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idTipoEmpleado = comando.Parameters.Add("@IdTipoEmpleado", System.Data.SqlDbType.Int);
            idTipoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter nombreTipoEmpleado = comando.Parameters.Add("@NombreTipoEmpleado", System.Data.SqlDbType.VarChar, 20);
            nombreTipoEmpleado.Direction = System.Data.ParameterDirection.Input;

            idTipoEmpleado.Value = IdTipoEmpleado;
            nombreTipoEmpleado.Value = NombreTipoEmpleado;
            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        #endregion

        #region Prescripcion
        public List<Prescripcion> obtenerPrescipcion()
        {
            List<Prescripcion> prescripciones = new List<Prescripcion>();

            SqlCommand comando = new SqlCommand("seleccionarPrescripcion", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                prescripciones.Add(new Prescripcion(lector.GetInt32(1), lector.GetDateTime(2), lector.GetInt32(3),
                    lector.GetString(4), lector.GetString(5)));
            }
            lector.Close();
            this.conexion.Close();
            return prescripciones;
        }

        public Boolean actualizarPrescripcion(Int32 NumeroExpediente, DateTime Fecha, Int32 CodigoEmpleado, String NombreMedicamento, String Dosis)
        {
            SqlCommand comando = new SqlCommand("actualizaPrescripcion", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter numeroExpediente = comando.Parameters.Add("@NumeroExpediente", System.Data.SqlDbType.Int);
            numeroExpediente.Direction = System.Data.ParameterDirection.Input;
            SqlParameter fecha = comando.Parameters.Add("@Fecha", System.Data.SqlDbType.DateTime);
            fecha.Direction = System.Data.ParameterDirection.Input;
            SqlParameter codigoEmpleado = comando.Parameters.Add("@CodigoEmpleado", System.Data.SqlDbType.Int);
            codigoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter nombreMedicamento = comando.Parameters.Add("@NombreMedicamento", System.Data.SqlDbType.VarChar, 70);
            nombreMedicamento.Direction = System.Data.ParameterDirection.Input;
            SqlParameter dosis = comando.Parameters.Add("@Dosis", System.Data.SqlDbType.VarChar, 120);
            dosis.Direction = System.Data.ParameterDirection.Input;

            numeroExpediente.Value = NumeroExpediente;
            fecha.Value = Fecha;
            codigoEmpleado.Value = CodigoEmpleado;
            nombreMedicamento.Value = NombreMedicamento;
            dosis.Value = Dosis;
            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public Boolean eliminarPrescripcion(Int32 NumeroExpediente)
        {
            SqlCommand comando = new SqlCommand("eliminarPrescripcion", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter numeroExpediente = comando.Parameters.Add("@NumeroExpediente", System.Data.SqlDbType.Int);
            numeroExpediente.Direction = System.Data.ParameterDirection.Input;

            numeroExpediente.Value = NumeroExpediente;
            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public Boolean insertarPrescripcion(Int32 NumeroExpediente, DateTime Fecha, Int32 CodigoEmpleado, String NombreMedicamento, String Dosis)
        {
            SqlCommand comando = new SqlCommand("insertarPrescripcion", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter numeroExpediente = comando.Parameters.Add("@NumeroExpediente", System.Data.SqlDbType.Int);
            numeroExpediente.Direction = System.Data.ParameterDirection.Input;
            SqlParameter fecha = comando.Parameters.Add("@Fecha", System.Data.SqlDbType.DateTime);
            fecha.Direction = System.Data.ParameterDirection.Input;
            SqlParameter codigoEmpleado = comando.Parameters.Add("@CodigoEmpleado", System.Data.SqlDbType.Int);
            codigoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter nombreMedicamento = comando.Parameters.Add("@NombreMedicamento", System.Data.SqlDbType.VarChar, 70);
            nombreMedicamento.Direction = System.Data.ParameterDirection.Input;
            SqlParameter dosis = comando.Parameters.Add("@Dosis", System.Data.SqlDbType.VarChar, 120);
            dosis.Direction = System.Data.ParameterDirection.Input;

            numeroExpediente.Value = NumeroExpediente;
            fecha.Value = Fecha;
            codigoEmpleado.Value = CodigoEmpleado;
            nombreMedicamento.Value = NombreMedicamento;
            dosis.Value = Dosis;
            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }
        #endregion

        #region Empleado
        public List<Empleado> obtenerEmpleado()
        {
            List<Empleado> empleados = new List<Empleado>();

            SqlCommand comando = new SqlCommand("seleccionarEmpleados", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                empleados.Add(new Empleado(lector.GetInt32(0), lector.GetString(1), lector.GetInt32(2), lector.GetString(3), lector.GetString(4),
                    lector.GetString(5), lector.GetString(6), lector.GetString(7), lector.GetString(8), lector.GetString(9), lector.GetDateTime(10),
                    lector.GetString(11), lector.GetString(12), lector.GetString(13)));
            }
            lector.Close();
            this.conexion.Close();
            return empleados;
        }

        public Boolean actualizarEmpleado(int CodigoEmpleado, string NumeroIdentidadEmpleado, int IdTipoEmpleado, string Primer_Nombre,
            string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Direccion, string Telefono, string EstadoCivil,
            DateTime FechaNac, string Especialidad, string Genero, string NumeroColegiado)
        {
            SqlCommand comando = new SqlCommand("actualizarEmpleado", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter codigoEmpleado = comando.Parameters.Add("@CodigoEmpleado", System.Data.SqlDbType.Int);
            codigoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter numeroIdentidadEmpleado = comando.Parameters.Add("@NumeroIdentidadEmpleado", System.Data.SqlDbType.VarChar, 15);
            numeroIdentidadEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter idTipoEmpleado = comando.Parameters.Add("@IdTipoEmpleado", System.Data.SqlDbType.Int);
            idTipoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter primer_Nombre = comando.Parameters.Add("@Primer_Nombre", System.Data.SqlDbType.VarChar, 15);
            primer_Nombre.Direction = System.Data.ParameterDirection.Input;
            SqlParameter segundo_Nombre = comando.Parameters.Add("@Segundo_Nombre", System.Data.SqlDbType.VarChar, 30);
            segundo_Nombre.Direction = System.Data.ParameterDirection.Input;
            SqlParameter primer_Apellido = comando.Parameters.Add("@Primer_Apellido", System.Data.SqlDbType.VarChar, 20);
            primer_Apellido.Direction = System.Data.ParameterDirection.Input;
            SqlParameter segundo_Apellido = comando.Parameters.Add("@Segundo_Apellido", System.Data.SqlDbType.VarChar, 20);
            segundo_Apellido.Direction = System.Data.ParameterDirection.Input;
            SqlParameter direccion = comando.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar, 150);
            direccion.Direction = System.Data.ParameterDirection.Input;
            SqlParameter telefono = comando.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar, 9);
            telefono.Direction = System.Data.ParameterDirection.Input;
            SqlParameter estadoCivil = comando.Parameters.Add("@EstadoCivil", System.Data.SqlDbType.VarChar, 10);
            estadoCivil.Direction = System.Data.ParameterDirection.Input;
            SqlParameter fechaNac = comando.Parameters.Add("@FechaNac", System.Data.SqlDbType.DateTime);
            fechaNac.Direction = System.Data.ParameterDirection.Input;
            SqlParameter especialidad = comando.Parameters.Add("@Especialidad", System.Data.SqlDbType.VarChar, 45);
            especialidad.Direction = System.Data.ParameterDirection.Input;
            SqlParameter genero = comando.Parameters.Add("@Genero", System.Data.SqlDbType.VarChar, 1);
            genero.Direction = System.Data.ParameterDirection.Input;
            SqlParameter numeroColegiado = comando.Parameters.Add("@NumeroColegiado", System.Data.SqlDbType.VarChar, 20);
            numeroColegiado.Direction = System.Data.ParameterDirection.Input;


            codigoEmpleado.Value = CodigoEmpleado;
            numeroColegiado.Value = NumeroColegiado;
            idTipoEmpleado.Value = IdTipoEmpleado;
            primer_Nombre.Value = Primer_Nombre;
            segundo_Nombre.Value = Segundo_Nombre;
            primer_Apellido.Value = Primer_Apellido;
            segundo_Apellido.Value = Segundo_Apellido;
            direccion.Value = Direccion;
            telefono.Value = Telefono;
            estadoCivil.Value = EstadoCivil;
            fechaNac.Value = FechaNac;
            especialidad.Value = Especialidad;
            genero.Value = Genero;
            numeroColegiado.Value = NumeroColegiado;

            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public Boolean eliminarEmpleado(int CodigoEmpleado)
        {
            SqlCommand comando = new SqlCommand("eliminarEmpleado", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter codigoEmpleado = comando.Parameters.Add("@CodigoEmpleado", System.Data.SqlDbType.Int);
            codigoEmpleado.Direction = System.Data.ParameterDirection.Input;

            codigoEmpleado.Value = CodigoEmpleado;
            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public Boolean InsertarEmpleado(int CodigoEmpleado, string NumeroIdentidadEmpleado, int IdTipoEmpleado, string Primer_Nombre,
            string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Direccion, string Telefono, string EstadoCivil,
            DateTime FechaNac, string Especialidad, string Genero, string NumeroColegiado)
        {
            SqlCommand comando = new SqlCommand("insertarEmpleado", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter codigoEmpleado = comando.Parameters.Add("@CodigoEmpleado", System.Data.SqlDbType.Int);
            codigoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter numeroIdentidadEmpleado = comando.Parameters.Add("@NumeroIdentidadEmpleado", System.Data.SqlDbType.VarChar, 15);
            numeroIdentidadEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter idTipoEmpleado = comando.Parameters.Add("@IdTipoEmpleado", System.Data.SqlDbType.Int);
            idTipoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter primer_Nombre = comando.Parameters.Add("@Primer_Nombre", System.Data.SqlDbType.VarChar, 15);
            primer_Nombre.Direction = System.Data.ParameterDirection.Input;
            SqlParameter segundo_Nombre = comando.Parameters.Add("@Segundo_Nombre", System.Data.SqlDbType.VarChar, 30);
            segundo_Nombre.Direction = System.Data.ParameterDirection.Input;
            SqlParameter primer_Apellido = comando.Parameters.Add("@Primer_Apellido", System.Data.SqlDbType.VarChar, 20);
            primer_Apellido.Direction = System.Data.ParameterDirection.Input;
            SqlParameter segundo_Apellido = comando.Parameters.Add("@Segundo_Apellido", System.Data.SqlDbType.VarChar, 20);
            segundo_Apellido.Direction = System.Data.ParameterDirection.Input;
            SqlParameter direccion = comando.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar, 150);
            direccion.Direction = System.Data.ParameterDirection.Input;
            SqlParameter telefono = comando.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar, 9);
            telefono.Direction = System.Data.ParameterDirection.Input;
            SqlParameter estadoCivil = comando.Parameters.Add("@EstadoCivil", System.Data.SqlDbType.VarChar, 10);
            estadoCivil.Direction = System.Data.ParameterDirection.Input;
            SqlParameter fechaNac = comando.Parameters.Add("@FechaNac", System.Data.SqlDbType.DateTime);
            fechaNac.Direction = System.Data.ParameterDirection.Input;
            SqlParameter especialidad = comando.Parameters.Add("@Especialidad", System.Data.SqlDbType.VarChar, 45);
            especialidad.Direction = System.Data.ParameterDirection.Input;
            SqlParameter genero = comando.Parameters.Add("@Genero", System.Data.SqlDbType.VarChar, 1);
            genero.Direction = System.Data.ParameterDirection.Input;
            SqlParameter numeroColegiado = comando.Parameters.Add("@NumeroColegiado", System.Data.SqlDbType.VarChar, 20);
            numeroColegiado.Direction = System.Data.ParameterDirection.Input;


            codigoEmpleado.Value = CodigoEmpleado;
            numeroColegiado.Value = NumeroColegiado;
            idTipoEmpleado.Value = IdTipoEmpleado;
            primer_Nombre.Value = Primer_Nombre;
            segundo_Nombre.Value = Segundo_Nombre;
            primer_Apellido.Value = Primer_Apellido;
            segundo_Apellido.Value = Segundo_Apellido;
            direccion.Value = Direccion;
            telefono.Value = Telefono;
            estadoCivil.Value = EstadoCivil;
            fechaNac.Value = FechaNac;
            especialidad.Value = Especialidad;
            genero.Value = Genero;
            numeroColegiado.Value = NumeroColegiado;
            numeroIdentidadEmpleado.Value = NumeroIdentidadEmpleado;

            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }
        #endregion

        #region Expediente
        public List<Expediente> obtenerExpediente()
        {
            List<Expediente> expedientes = new List<Expediente>();

            SqlCommand comando = new SqlCommand("seleccionarExpediente", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                expedientes.Add(new Expediente(lector.GetInt32(0), lector.GetString(1), lector.GetString(2), lector.GetString(3), lector.GetString(4),
                    lector.GetString(5), lector.GetString(6), lector.GetString(7), lector.GetString(8), lector.GetDateTime(9), lector.GetString(10)));
            }
            lector.Close();
            this.conexion.Close();
            return expedientes;
        }

        public Boolean actualizarExpediente(int NumeroExpediente, string NumeroIdentidadPaciente, string Primer_Nombre,
            string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Direccion, string Telefono, string EstadoCivil,
            DateTime FechaNac, string Genero)
        {
            SqlCommand comando = new SqlCommand("actualizaExpediente", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter numeroExpediente = comando.Parameters.Add("@NumeroExpediente", System.Data.SqlDbType.Int);
            numeroExpediente.Direction = System.Data.ParameterDirection.Input;
            SqlParameter numeroIdentidadPaciente = comando.Parameters.Add("@NumeroIdentidadPaciente", System.Data.SqlDbType.VarChar, 15);
            numeroIdentidadPaciente.Direction = System.Data.ParameterDirection.Input;
            SqlParameter primer_Nombre = comando.Parameters.Add("@Primer_Nombre", System.Data.SqlDbType.VarChar, 15);
            primer_Nombre.Direction = System.Data.ParameterDirection.Input;
            SqlParameter segundo_Nombre = comando.Parameters.Add("@Segundo_Nombre", System.Data.SqlDbType.VarChar, 30);
            segundo_Nombre.Direction = System.Data.ParameterDirection.Input;
            SqlParameter primer_Apellido = comando.Parameters.Add("@Primer_Apellido", System.Data.SqlDbType.VarChar, 20);
            primer_Apellido.Direction = System.Data.ParameterDirection.Input;
            SqlParameter segundo_Apellido = comando.Parameters.Add("@Segundo_Apellido", System.Data.SqlDbType.VarChar, 20);
            segundo_Apellido.Direction = System.Data.ParameterDirection.Input;
            SqlParameter direccion = comando.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar, 150);
            direccion.Direction = System.Data.ParameterDirection.Input;
            SqlParameter telefono = comando.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar, 9);
            telefono.Direction = System.Data.ParameterDirection.Input;
            SqlParameter estadoCivil = comando.Parameters.Add("@EstadoCivil", System.Data.SqlDbType.VarChar, 10);
            estadoCivil.Direction = System.Data.ParameterDirection.Input;
            SqlParameter fechaNac = comando.Parameters.Add("@FechaNac", System.Data.SqlDbType.DateTime);
            fechaNac.Direction = System.Data.ParameterDirection.Input;
            SqlParameter genero = comando.Parameters.Add("@Genero", System.Data.SqlDbType.VarChar, 1);
            genero.Direction = System.Data.ParameterDirection.Input;

            numeroExpediente.Value = NumeroExpediente;
            numeroIdentidadPaciente.Value = NumeroIdentidadPaciente;
            primer_Nombre.Value = Primer_Nombre;
            segundo_Nombre.Value = Segundo_Nombre;
            primer_Apellido.Value = Primer_Apellido;
            segundo_Apellido.Value = Segundo_Apellido;
            direccion.Value = Direccion;
            telefono.Value = Telefono;
            estadoCivil.Value = EstadoCivil;
            fechaNac.Value = FechaNac;
            genero.Value = Genero;


            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public Boolean eliminarExpediente(int NumeroExpediente)
        {
            SqlCommand comando = new SqlCommand("eliminarExpediente", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter numeroExpediente = comando.Parameters.Add("@NumeroExpediente", System.Data.SqlDbType.Int);
            numeroExpediente.Direction = System.Data.ParameterDirection.Input;

            numeroExpediente.Value = NumeroExpediente;
            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public Boolean insertarExpediente(string NumeroIdentidadPaciente, string Primer_Nombre,
            string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Direccion, string Telefono, string EstadoCivil,
            DateTime FechaNac, string Genero)
        {
            SqlCommand comando = new SqlCommand("insertarExpediente", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter numeroIdentidadPaciente = comando.Parameters.Add("@NumeroIdentidadPaciente", System.Data.SqlDbType.VarChar, 15);
            numeroIdentidadPaciente.Direction = System.Data.ParameterDirection.Input;
            SqlParameter primer_Nombre = comando.Parameters.Add("@Primer_Nombre", System.Data.SqlDbType.VarChar, 15);
            primer_Nombre.Direction = System.Data.ParameterDirection.Input;
            SqlParameter segundo_Nombre = comando.Parameters.Add("@Segundo_Nombre", System.Data.SqlDbType.VarChar, 30);
            segundo_Nombre.Direction = System.Data.ParameterDirection.Input;
            SqlParameter primer_Apellido = comando.Parameters.Add("@Primer_Apellido", System.Data.SqlDbType.VarChar, 20);
            primer_Apellido.Direction = System.Data.ParameterDirection.Input;
            SqlParameter segundo_Apellido = comando.Parameters.Add("@Segundo_Apellido", System.Data.SqlDbType.VarChar, 20);
            segundo_Apellido.Direction = System.Data.ParameterDirection.Input;
            SqlParameter direccion = comando.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar, 150);
            direccion.Direction = System.Data.ParameterDirection.Input;
            SqlParameter telefono = comando.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar, 9);
            telefono.Direction = System.Data.ParameterDirection.Input;
            SqlParameter estadoCivil = comando.Parameters.Add("@EstadoCivil", System.Data.SqlDbType.VarChar, 10);
            estadoCivil.Direction = System.Data.ParameterDirection.Input;
            SqlParameter fechaNac = comando.Parameters.Add("@FechaNac", System.Data.SqlDbType.DateTime);
            fechaNac.Direction = System.Data.ParameterDirection.Input;
            SqlParameter genero = comando.Parameters.Add("@Genero", System.Data.SqlDbType.VarChar, 1);
            genero.Direction = System.Data.ParameterDirection.Input;

            numeroIdentidadPaciente.Value = NumeroIdentidadPaciente;
            primer_Nombre.Value = Primer_Nombre;
            segundo_Nombre.Value = Segundo_Nombre;
            primer_Apellido.Value = Primer_Apellido;
            segundo_Apellido.Value = Segundo_Apellido;
            direccion.Value = Direccion;
            telefono.Value = Telefono;
            estadoCivil.Value = EstadoCivil;
            fechaNac.Value = FechaNac;
            genero.Value = Genero;


            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }
        #endregion

        #region Consulta
        public List<Consulta> obtenerConsulta()
        {
            List<Consulta> consultas = new List<Consulta>();

            SqlCommand comando = new SqlCommand("seleccionarConsulta", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                consultas.Add(new Consulta(lector.GetInt32(0), lector.GetInt32(2), lector.GetDateTime(1), lector.GetDecimal(3), float.Parse(lector.GetDouble(4).ToString().Trim()),
                    lector.GetString(5), float.Parse(lector.GetDouble(6).ToString().Trim()), lector.GetString(7), lector.GetString(8), lector.GetString(9)));
            }
            lector.Close();
            this.conexion.Close();
            return consultas;
        }

        public Boolean actualizarConsulta(int NumeroExpediente, int CodigoEmpleado, DateTime Fecha, decimal Temperatura, float Estatura, string PresionArterial,
            float Peso, string Diagnostico, string Problematica, string Observacion)
        {
            SqlCommand comando = new SqlCommand("actualizaConsulta", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter numeroExpediente = comando.Parameters.Add("@NumeroExpediente", System.Data.SqlDbType.Int);
            numeroExpediente.Direction = System.Data.ParameterDirection.Input;
            SqlParameter codigoEmpleado = comando.Parameters.Add("@CodigoEmpleado", System.Data.SqlDbType.Int);
            codigoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter temperatura = comando.Parameters.Add("@Temperatura", System.Data.SqlDbType.Decimal);
            temperatura.Direction = System.Data.ParameterDirection.Input;
            SqlParameter estatura = comando.Parameters.Add("@Estatura", System.Data.SqlDbType.Float);
            estatura.Direction = System.Data.ParameterDirection.Input;
            SqlParameter presionArterial = comando.Parameters.Add("@PresionArterial", System.Data.SqlDbType.VarChar, 7);
            presionArterial.Direction = System.Data.ParameterDirection.Input;
            SqlParameter peso = comando.Parameters.Add("@Peso", System.Data.SqlDbType.Float);
            peso.Direction = System.Data.ParameterDirection.Input;
            SqlParameter diagnostico = comando.Parameters.Add("@Diagnostico", System.Data.SqlDbType.VarChar, 400);
            diagnostico.Direction = System.Data.ParameterDirection.Input;
            SqlParameter problematica = comando.Parameters.Add("@Problematica", System.Data.SqlDbType.VarChar, 400);
            problematica.Direction = System.Data.ParameterDirection.Input;
            SqlParameter observacion = comando.Parameters.Add("@Observacion", System.Data.SqlDbType.VarChar, 20);
            observacion.Direction = System.Data.ParameterDirection.Input;
            SqlParameter fecha = comando.Parameters.Add("@Fecha", System.Data.SqlDbType.DateTime);
            fecha.Direction = System.Data.ParameterDirection.Input;

            numeroExpediente.Value = NumeroExpediente;
            codigoEmpleado.Value = CodigoEmpleado;
            temperatura.Value = Temperatura;
            estatura.Value = Estatura;
            presionArterial.Value = PresionArterial;
            peso.Value = Peso;
            diagnostico.Value = Diagnostico;
            problematica.Value = Problematica;
            observacion.Value = Observacion;
            fecha.Value = Fecha;


            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public Boolean eliminarConsulta(int NumeroExpediente, DateTime Fecha)
        {
            SqlCommand comando = new SqlCommand("eliminarConsulta", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter fecha = comando.Parameters.Add("@Fecha", System.Data.SqlDbType.DateTime);
            fecha.Direction = System.Data.ParameterDirection.Input;

            SqlParameter numeroExpediente = comando.Parameters.Add("@NumeroExpediente", System.Data.SqlDbType.Int);
            numeroExpediente.Direction = System.Data.ParameterDirection.Input;

            fecha.Value = Fecha;
            numeroExpediente.Value = NumeroExpediente;
            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public Boolean insertarConsulta(int NumeroExpediente, int CodigoEmpleado, DateTime Fecha, decimal Temperatura, float Estatura, string PresionArterial,
            float Peso, string Diagnostico, string Problematica, string Observacion)
        {
            SqlCommand comando = new SqlCommand("insertarConsulta", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter numeroExpediente = comando.Parameters.Add("@NumeroExpediente", System.Data.SqlDbType.Int);
            numeroExpediente.Direction = System.Data.ParameterDirection.Input;
            SqlParameter codigoEmpleado = comando.Parameters.Add("@CodigoEmpleado", System.Data.SqlDbType.Int);
            codigoEmpleado.Direction = System.Data.ParameterDirection.Input;
            SqlParameter temperatura = comando.Parameters.Add("@Temperatura", System.Data.SqlDbType.Decimal);
            temperatura.Direction = System.Data.ParameterDirection.Input;
            SqlParameter estatura = comando.Parameters.Add("@Estatura", System.Data.SqlDbType.Float);
            estatura.Direction = System.Data.ParameterDirection.Input;
            SqlParameter presionArterial = comando.Parameters.Add("@PresionArterial", System.Data.SqlDbType.VarChar, 7);
            presionArterial.Direction = System.Data.ParameterDirection.Input;
            SqlParameter peso = comando.Parameters.Add("@Peso", System.Data.SqlDbType.Float);
            peso.Direction = System.Data.ParameterDirection.Input;
            SqlParameter diagnostico = comando.Parameters.Add("@Diagnostico", System.Data.SqlDbType.VarChar, 400);
            diagnostico.Direction = System.Data.ParameterDirection.Input;
            SqlParameter problematica = comando.Parameters.Add("@Problematica", System.Data.SqlDbType.VarChar, 400);
            problematica.Direction = System.Data.ParameterDirection.Input;
            SqlParameter observacion = comando.Parameters.Add("@Observacion", System.Data.SqlDbType.VarChar, 20);
            observacion.Direction = System.Data.ParameterDirection.Input;
            SqlParameter fecha = comando.Parameters.Add("@Fecha", System.Data.SqlDbType.DateTime);
            fecha.Direction = System.Data.ParameterDirection.Input;

            numeroExpediente.Value = NumeroExpediente;
            codigoEmpleado.Value = CodigoEmpleado;
            temperatura.Value = Temperatura;
            estatura.Value = Estatura;
            presionArterial.Value = PresionArterial;
            peso.Value = Peso;
            diagnostico.Value = Diagnostico;
            problematica.Value = Problematica;
            observacion.Value = Observacion;
            fecha.Value = Fecha;


            this.conexion.Open();

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public DataTable obtenerConsultasExpediente(int NumeroExpediente)
        {
            DataTable consultas = new DataTable();

            SqlCommand comando = new SqlCommand("consultarConsulta", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter numeroExpediente = comando.Parameters.Add("@NumeroExpediente", System.Data.SqlDbType.Int);
            numeroExpediente.Direction = System.Data.ParameterDirection.Input;

            numeroExpediente.Value = NumeroExpediente;

            this.conexion.Open();

            comando.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(consultas);

            this.conexion.Close();
            return consultas;
        }
        #endregion

        public void buscarConsulta(int NumeroExpediente)
        {
            DataTable tabla = new DataTable();
            string consulta = "exec consultarConsulta " + NumeroExpediente;
            FrmHistorialExpediente historial = new FrmHistorialExpediente();
            this.conexion.Open();

            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.Fill(tabla);

                historial.recibeConsultas(tabla);
                historial.ShowDialog();
                conexion.Close();

            }
            catch (SqlException sqlE)
            {
                conexion.Close();
            }

        }

        public void buscarConsultaIdentidad(string NumeroIdentidad)
        {
            DataTable tabla = new DataTable();
            string consulta = "exec consultaIdentidad " + NumeroIdentidad;
            FrmHistorialExpediente historial = new FrmHistorialExpediente();
            this.conexion.Open();

            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.Fill(tabla);

                historial.recibeConsultas(tabla);
                historial.ShowDialog();
                conexion.Close();

            }
            catch (SqlException sqlE)
            {
                conexion.Close();
            }

        }

        public Boolean buscarExpedientePorIdentidad(string NumeroIdentidad)
        {
            try
            {
                conexion.Close();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("consultarExpedienteI", this.conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@NumeroIdentidad", SqlDbType.VarChar);
                da.SelectCommand.Parameters["@NumeroIdentidad"].Value = Convert.ToString(NumeroIdentidad);
                da.Fill(dt);
                FrmHistorialExpediente historial = new FrmHistorialExpediente();
                historial.recibeIdentidad(dt, NumeroIdentidad);
                historial.ShowDialog();
                conexion.Close();
                return true;

            }
            catch (Exception ex)
            {

                return false;

            }


        }

        public Boolean buscarExpediente(int NumeroExpediente)
        {
            DataTable tabla = new DataTable();
            string consulta = "exec consultarExpediente " + NumeroExpediente;
            FrmHistorialExpediente historial = new FrmHistorialExpediente();
            this.conexion.Open();

            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.Fill(tabla);
                if (tabla.Rows.Count > 0)
                {
                    historial.recibeExpediente(tabla, NumeroExpediente);
                    historial.ShowDialog();
                    conexion.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }

        }

        public Boolean buscarEmpleado(Int32 CodigoEmpleado)
        {
            DataTable tabla = new DataTable();
            FrmHistorialExpediente historial = new FrmHistorialExpediente();
            string consulta = "exec consultarEmpleado " + CodigoEmpleado;
            this.conexion.Open();

            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.Fill(tabla);
                if (tabla.Rows.Count > 0)
                {
                    historial.recibeConsultas(tabla);
                    historial.btVerdatosConsulta.Visible = false;
                    historial.ShowDialog();
                    conexion.Close();
                    return true;
                }
                else
                {
                    conexion.Close();
                    return false;
                }
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }

        }

        public void cargarBaseDeDatos()
        {
            this.empleados = obtenerEmpleado();
            this.consultas = obtenerConsulta();
            this.expedientes = obtenerExpediente();
            this.prescripciones = obtenerPrescipcion();
            this.tipoEmpleados = obtenerTiposEmpleado();
            this.usuarios = obtenerUsuarios();

            foreach (Empleado empleado in empleados)
            {
                foreach (TipoEmpleado tipoempleado in tipoEmpleados)
                {
                    if (tipoempleado.IdTipoEmpleado == empleado.IdTipoEmpleado)
                    {
                        empleado.TipoEmpleado = tipoempleado;
                        break;
                    }
                }

                foreach (Consulta consulta in consultas)
                {
                    if (consulta.CodigoEmpleado == empleado.CodigoEmpleado)
                    {
                        consulta.Empleado = empleado;
                        break;
                    }
                }
            }

            foreach (Prescripcion prescripcion in prescripciones)
            {
                foreach (Empleado empleado in empleados)
                {
                    if (prescripcion.CodigoEmpleado == empleado.CodigoEmpleado)
                    {
                        prescripcion.Empleado = empleado;
                        empleado.Prescripciones.Add(prescripcion);
                    }
                }
            }

            foreach (Expediente expediente in expedientes)
            {
                foreach (Consulta consulta in consultas)
                {
                    if (consulta.NumeroExpediente == expediente.NumeroExpediente)
                    {
                        consulta.Expediente = expediente;
                        expediente.Consultas.Add(consulta);
                    }
                }
            }

            foreach (Consulta consulta in consultas)
            {
                foreach (Prescripcion prescripcion in prescripciones)
                {
                    if (consulta.Fecha.Equals(prescripcion.Fecha) && consulta.NumeroExpediente == prescripcion.NumeroExpediente)
                    {
                        consulta.Prescipciones.Add(prescripcion);
                        prescripcion.Expediente = consulta.Expediente;
                        break;
                    }
                }
            }
        }

    }
}
