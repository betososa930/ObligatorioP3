using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Obligatorio

{
    class Empleado : Persistente, IActiveRecord<Empleado>
    {
        private string nombre;
        private int idEmpleado;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string contrasenia;

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        private string mail;        

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        
        public Empleado(string nombre, string contrasenia,string mail)
        {
            this.nombre = nombre;
            this.contrasenia = contrasenia;
            this.mail = mail;
        }
        public Empleado()
        {
            this.nombre = null;
            this.contrasenia = null;
            this.mail = null;
        }

        public void Alta(string nombre, string mail, string contrasenia)
        {
            Empleado emp = new Empleado(nombre, contrasenia,mail);
            emp.Guardar();
        }

        public void Modificar(string nombre, string mail, string contrasenia)
        {
            Empleado emp = new Empleado(nombre, contrasenia, mail);
            emp.Actualizar();
        }

        public bool Leer()
        {
            bool ret = false;

            SqlConnection con = ObtenerConexion();
            string sql = "select * from Persona where Email = @mail;";
            SqlParameter par = new SqlParameter("@mail", this.mail);
            SqlDataReader reader = null;
            try
            {
                reader = EjecutarConsulta(con, sql, new List<SqlParameter>() { par }, CommandType.Text);
                
                if (reader.Read())
                {
                    this.nombre = reader["Nombre"].ToString();
                    this.contrasenia = reader["contrasenia"].ToString();
                    ret = true;
                }                
            }
            catch
            {
                throw;
            }
            finally
            {
                if (reader != null) reader.Close();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();
                }
            }

            return ret;
        }

        public bool Guardar()
        {
            bool ret = false;
            SqlConnection con = ObtenerConexion();
            try
            {
                string sql = "insert into Persona(Nombre, Contrasenia, Email) values(@nom, @cont, @mail)";
                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter parNom = new SqlParameter("@nom", this.nombre);
                SqlParameter parCont = new SqlParameter("@cont", this.contrasenia);
                SqlParameter parMail = new SqlParameter("@mail", this.mail);
                parametros.Add(parNom);
                parametros.Add(parCont);
                parametros.Add(parMail);
                con.Open(); //opcional, si no lo hago, EjecutarConsulta la abre
                int afectadas = EjecutarNoConsulta(con, sql,parametros,CommandType.Text);
                if (afectadas > 0) ret = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();
                    Console.WriteLine("Cerrada");
                }
            }

            return ret;
        }

        public bool Actualizar()
        {
            bool ret = false;
            SqlConnection con = ObtenerConexion();
            try
            {
                string sql = "update Persona set Nombre=@nom, Contrasenia=@ape where Email=@mail;";
                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter parNom = new SqlParameter("@nom", this.nombre);
                SqlParameter parCont = new SqlParameter("@cont", this.contrasenia);
                SqlParameter parMail = new SqlParameter("@mail", this.mail);
                parametros.Add(parNom);
                parametros.Add(parCont);
                parametros.Add(parMail);
                con.Open(); //opcional, si no lo hago, EjecutarConsulta la abre
                int afectadas = EjecutarNoConsulta(con, sql, parametros, CommandType.Text);
                if (afectadas > 0) ret = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();
                    Console.WriteLine("Cerrada");
                }
            }

            return ret;
        }

        public List<Empleado> TraerTodo()
        {
            List<Empleado> personas = new List<Empleado>();

            SqlConnection con = ObtenerConexion();
            string sql = "select * from Persona;";            
            SqlDataReader reader = null;
            try
            {
                reader = EjecutarConsulta(con, sql, null, CommandType.Text);

                while (reader.Read())
                {
                    Empleado nueva = new Empleado()
                    {
                        Nombre = reader["Nombre"].ToString(),
                        Contrasenia = reader["Contrasenia"].ToString(),
                    };

                    personas.Add(nueva);                    
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (reader != null) reader.Close();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();
                }
            }

            return personas;
        }
    }
}
