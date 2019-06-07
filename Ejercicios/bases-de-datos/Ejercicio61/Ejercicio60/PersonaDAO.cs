using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ejercicio61
{
    public class PersonaDAO
    {
        public static SqlConnection conexion;
        public static SqlCommand comando;

        static PersonaDAO()
        {
            string conexionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=Persona; Integrated Security = True";

            try
            {
                conexion = new SqlConnection(conexionStr);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            } catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Guardar(Persona persona)
        {
            bool respuesta = false;
            try
            {
                string consulta = String.Format("INSERT INTO Persona (nombre, apellido) VALUES ('{0}','{1}')", persona.Nombre, persona.Apellido);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return respuesta;
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            Persona persona;

            string consulta = String.Format("Select * from Persona");

            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int id = int.Parse(oDr["id"].ToString());
                    string nombre = oDr["nombre"].ToString();
                    string apellido = oDr["apellido"].ToString();
                    persona = new Persona(id, nombre, apellido);
                    personas.Add(persona);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return personas;
        }

        public static Persona LeerPorId(int id)
        {
            Persona persona = new Persona();
            string consulta = String.Format("Select * from Persona where id = {0}", id);

            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                if (oDr.Read())
                {
                    int idAux = int.Parse(oDr["id"].ToString());
                    string nombre = oDr["nombre"].ToString();
                    string apellido = oDr["apellido"].ToString();
                    persona = new Persona(id, nombre, apellido);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return persona;
        }

        public static void Modificar(int id)
        {
            //TODO
            Persona persona = LeerPorId(id);



        }

        public void Borrar()
        {

        }
    }
}
