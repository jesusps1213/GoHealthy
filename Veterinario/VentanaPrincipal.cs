using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Veterinario
{
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion = new Conexion();
        public VentanaPrincipal()
        {
            
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                // Encriptar la contraseña
                string myHash = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);

                // Convertir peso y altura a decimal (si están vacíos, usar 0)
                decimal peso = string.IsNullOrWhiteSpace(textPeso.Text) ? 0 : Convert.ToDecimal(textPeso.Text);
                decimal altura = string.IsNullOrWhiteSpace(textAltura.Text) ? 0 : Convert.ToDecimal(textAltura.Text);

                // Llamar al método con todos los parámetros requeridos
                bool resultado = conexion.insertaUsuario(
                    textIdperfil.Text,        // DNI
                    textBoxNombre.Text,     // Nombre
                    textBoxApellido.Text,   // Apellidos
                    myHash,                 // Contraseña encriptada
                    textBoxGenero.Text,     // Género
                    peso,                   // Peso (decimal)
                    altura,                 // Altura (decimal)
                    textSituacion_Economica.Text,  // Situación económica
                    textPais.Text           // País
                );

                // Mostrar mensaje de éxito o error
                MessageBox.Show(resultado ? "✅ Usuario registrado correctamente." : "❌ Error al registrar usuario.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error inesperado: {ex.Message}");
            }
        }

        private void InsertaUsuario_Click(object sender, EventArgs e)
{
    try
    {
        // Obtener datos de los campos
        string textoPassword = textBoxPassword.Text;
        string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword);

        // Convertir peso y altura a decimal (si están vacíos, usar NULL)
        decimal peso = string.IsNullOrWhiteSpace(textPeso.Text) ? 0 : Convert.ToDecimal(textPeso.Text);
        decimal altura = string.IsNullOrWhiteSpace(textAltura.Text) ? 0 : Convert.ToDecimal(textAltura.Text);

                // Llamar a la función de inserción
                bool resultado = conexion.insertaUsuario(
              textIdperfil.Text,        // DNI
              textBoxNombre.Text,     // Nombre
              textBoxApellido.Text,   // Apellido
              myHash,                 // Hash de la contraseña
              textBoxGenero.Text,     // Género
              peso,                   // Peso
              altura,                 // Altura
              textSituacion_Economica.Text,  // Situación
              textPais.Text           // País
          );


                // Mostrar mensaje de éxito o error
                MessageBox.Show(resultado ? "✅ Usuario registrado correctamente." : "❌ Error al registrar usuario.");
    }
    catch (Exception ex)
    {
        MessageBox.Show($"❌ Error inesperado: {ex.Message}");
    }
}


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaMascota(textBoxNombrem.Text, TextBoxDNI.Text, textBoxEspecie.Text, textBoxChip.Text));
        }

       private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Datos_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el DNI ingresado
                string nombre_login = textBox7.Text;

                // Obtener datos del usuario
                DataTable usuario = conexion.getUsuarioPorDNI(nombre_login);

                // Verificar si hay datos antes de acceder a ellos
                if (usuario.Rows.Count > 0)
                {
                    labelNombre.Text = usuario.Rows[0]["nombre"].ToString();
                    labelApellido.Text = usuario.Rows[0]["apellidos"].ToString();
                    labelGenero.Text = usuario.Rows[0]["sexo"].ToString();
                    labelPeso.Text = usuario.Rows[0]["peso"].ToString();
                    labelAltura.Text = usuario.Rows[0]["altura"].ToString();
                    labelSituacion_Economica.Text = usuario.Rows[0]["situacion"].ToString();  // Situación económica
                    labelPais.Text = usuario.Rows[0]["pais"].ToString();            // País
                }
                else
                {
                    MessageBox.Show("❌ No se encontraron datos para este usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error inesperado: {ex.Message}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DNI_Dueno_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailmuestra_Click(object sender, EventArgs e)
        {

        }
    }
   
}
