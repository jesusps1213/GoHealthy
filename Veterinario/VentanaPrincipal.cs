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
       

       
    }
}
