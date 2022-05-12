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
            MessageBox.Show(conexion.insertaUsuario(textBox1DNI.Text,
                textBoxNombre.Text, textBoxPassword.Text, textBoxApellido.Text, textBoxEmail.Text, textBoxMascota.Text, textBoxPerfil.Text)); 
        }
        private void InsertaUsuario_Click(object sender, EventArgs e)
        {

            String textoPassword = textBoxPassword.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());
            MessageBox.Show(conexion.insertaUsuario(textBox1DNI.Text, textBoxNombre.Text, myHash, textBoxApellido.Text, textBoxEmail.Text, textBoxMascota.Text, textBoxPerfil.Text));
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
            String Dni = textBox7.Text;
            DataTable misPokemons = new DataTable();
            misPokemons = conexion.getUsuarioPorDNI(Dni);
            labelNombre.Text = misPokemons.Rows[0]["Nombre"].ToString();
            labelApellido.Text = misPokemons.Rows[0]["Apellido"].ToString();
            labelEmail.Text = misPokemons.Rows[0]["email"].ToString();
            labelMascota.Text = misPokemons.Rows[0]["mascota"].ToString();
            labelPerfil.Text = misPokemons.Rows[0]["perfil"].ToString();
        }

    }
   
}
