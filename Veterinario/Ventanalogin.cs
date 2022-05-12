using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class Ventanalogin : Form
    {
        Conexion conexion = new Conexion();
        public Ventanalogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipal v = new VentanaPrincipal();
            v.Show();
            if (conexion.loginVeterinario(textBox1.Text, textBox2.Text))
            {
            //    this.Hide();
            //    VentanaPrincipal v = new VentanaPrincipal();
            //    v.Show();
            }
            else
            {
                MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS ");
            }

            
        }
    }
}