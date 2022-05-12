using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Veterinario
{
    internal class Conexion
    {
        public MySqlConnection conexion;
        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1;" +
                "Database = veterinario;Uid = root; Pwd =;Port = 3306");
        }
        public Boolean loginVeterinario(String DNI, String password)
        {

            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT* FROM usuarios WHERE DNI = @DNI ", conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);

                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    String passwordConHash = resultado.GetString("password");
                    if (BCrypt.Net.BCrypt.Verify(password, passwordConHash))
                    {
                        return true;
                    }
                    return false;
                }
                conexion.Close();
                return false;

            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se conecta la base de datos ");
                return false;

            }
        }
        public String insertaUsuario(String DNI, String Nombre, String password, String Apellido, String email, String mascota, String perfil)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO `usuarios` (`DNI`, `Nombre`, `Apellido`, `password`, `email`, `mascota`, `perfil`) " +
                    "VALUES(@DNI,@Nombre,@Apellido,@password,@email,@mascota,@perfil)", conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@password", password);
                consulta.Parameters.AddWithValue("@Apellido", Apellido);
                consulta.Parameters.AddWithValue("@email", email);
                consulta.Parameters.AddWithValue("@mascota", mascota);
                consulta.Parameters.AddWithValue("@perfil", perfil);

                consulta.ExecuteNonQuery();
                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }
    }


}
