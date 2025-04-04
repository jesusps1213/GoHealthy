using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Veterinario
{
    internal class Conexion
    {
        public MySqlConnection conexion;
        public Conexion()
        {
            conexion = new MySqlConnection("server=127.0.0.1;port=3306;database=gohealthy;user=root;password=");
        }
        public Boolean login(String nombre_login, String password)
        {

            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT* FROM usuario WHERE nombre_login = @nombre_login ", conexion);
                consulta.Parameters.AddWithValue("@nombre_login", nombre_login);

                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    String passwordConHash = resultado.GetString("passwd");
                    if (BCrypt.Net.BCrypt.Verify(password, passwordConHash))
                    {
                        return true;
                    }
                    return false;
                }
                conexion.Close();
                return false;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se conecta la base de datos ");
                return false;

            }
        }
        public bool insertaUsuario(string nombre_login, string nombre, string apellidos, string passwd, string sexo, decimal peso, decimal altura, string situacion, string pais)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO usuario (nombre_login, nombre, apellidos, passwd, sexo, peso, altura, situacion, pais) " +
                    "VALUES (@nombre_login, @nombre, @apellidos, @passwd, @sexo, @peso, @altura, @situacion, @pais)", conexion);

                consulta.Parameters.AddWithValue("@nombre_login", nombre_login);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellidos", apellidos);
                consulta.Parameters.AddWithValue("@passwd", passwd);
                consulta.Parameters.AddWithValue("@sexo", sexo);
                consulta.Parameters.AddWithValue("@peso", peso);
                consulta.Parameters.AddWithValue("@altura", altura);
                consulta.Parameters.AddWithValue("@situacion", situacion);
                consulta.Parameters.AddWithValue("@pais", pais);

                int filasAfectadas = consulta.ExecuteNonQuery();
                conexion.Close();

                return filasAfectadas > 0; // Retorna true si se insertó al menos un registro
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        public String insertaMascota(String DNI_Dueno, String NombreM, String Especie, String chip)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO `mascota` (`Nombre`,`DNI_dueño`,`especie`,`chip`) " +
                    "VALUES(@NombreM,@DNI_Dueno,@especie,@chip)", conexion);
                consulta.Parameters.AddWithValue("@NombreM", NombreM);
                consulta.Parameters.AddWithValue("@DNI_Dueno", DNI_Dueno);
                consulta.Parameters.AddWithValue("@especie", Especie);
                consulta.Parameters.AddWithValue("@chip", chip);
                
               

                consulta.ExecuteNonQuery();
                conexion.Close();
                return "ok";
            }
            catch (MySqlException ex)
            {
                return "error";
            }
        }
         public DataTable getUsuarioPorDNI(String nombre_login)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuario WHERE nombre_login = @nombre_login", conexion);
                consulta.Parameters.AddWithValue("@nombre_login", nombre_login);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable usuario = new DataTable();
                usuario.Load(resultado);
                return usuario;
            }
            catch (MySqlException ex)
            {
                throw ex; // o manejar mejor el error según sea necesario
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close(); // Garantiza que siempre se cierre
                }
            }

        }


    }


}
