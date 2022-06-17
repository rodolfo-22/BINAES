using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Solucion_BINAES.Properties;

namespace Solucion_BINAES
{
    internal class AdminDAO
    {
        public static Usuario Existe(string usuario, string contraseña)
        {
            string cadena = Resources.cadena_conexion;
            Admin Adm = new Admin();

            using (SqlConnection connection= new SqlConnection(cadena))
            {
                string query = "SELECT usuario, contraseña FROM ADMINISTRADOR" +
                    "WHERE usuario like @usuario AND contraseña like @contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@contraseña", contraseña);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Adm.usuario = reader["usuario"].ToString();
                        Adm.contraseña = reader["contraeña"].ToString();
                       
                    }
                }
                connection.Close();
            }
            return Adm;
        }


        }
    }
