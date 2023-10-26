using Proyecto_Medicos.Models;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Medicos.Data
{
    public class Logica
    {

        

        public Usuarios EncontrarUsuario(string correo, string clave)
        {

            Usuarios objeto = new Usuarios();


            using (SqlConnection conexion = new SqlConnection("Data Source=LUISRIMAC\\SQLEXPRESS ; Initial Catalog=Autenticacion; Integrated Security=true"))
            {

                string query = "select Nombres,Correo,Clave,idRol from Usuario where Correo = @pcorreo and Clave = @pclave";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@pcorreo", correo);
                cmd.Parameters.AddWithValue("@pclave", clave);
                cmd.CommandType = CommandType.Text;


                conexion.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        objeto = new Usuarios()
                        {
                            nombre = dr["Nombres"].ToString(),
                            correo = dr["Correo"].ToString(),
                            clave = dr["Clave"].ToString(),
                            idRol = (Rol)dr["idRol"],

                        };
                    }

                }
            }
            return objeto;

        }
    }

}
