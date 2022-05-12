namespace Veterinario
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxMascota = new System.Windows.Forms.TextBox();
            this.mascota = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.textBoxPerfil = new System.Windows.Forms.TextBox();
            this.perfil = new System.Windows.Forms.Label();
            this.InsertaUsuario = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1DNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Especie = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chip = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.textBoxMascota);
            this.tabPage1.Controls.Add(this.mascota);
            this.tabPage1.Controls.Add(this.textBoxApellido);
            this.tabPage1.Controls.Add(this.Apellido);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.Email);
            this.tabPage1.Controls.Add(this.textBoxPerfil);
            this.tabPage1.Controls.Add(this.perfil);
            this.tabPage1.Controls.Add(this.InsertaUsuario);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxPassword);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox1DNI);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1192, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxMascota
            // 
            this.textBoxMascota.Location = new System.Drawing.Point(411, 309);
            this.textBoxMascota.Name = "textBoxMascota";
            this.textBoxMascota.Size = new System.Drawing.Size(242, 26);
            this.textBoxMascota.TabIndex = 14;
            // 
            // mascota
            // 
            this.mascota.AutoSize = true;
            this.mascota.Location = new System.Drawing.Point(285, 309);
            this.mascota.Name = "mascota";
            this.mascota.Size = new System.Drawing.Size(70, 20);
            this.mascota.TabIndex = 13;
            this.mascota.Text = "Mascota";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(616, 182);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(242, 26);
            this.textBoxApellido.TabIndex = 12;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(516, 182);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(65, 20);
            this.Apellido.TabIndex = 11;
            this.Apellido.Text = "Apellido";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(616, 239);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(242, 26);
            this.textBoxEmail.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(490, 239);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 9;
            this.Email.Text = "Email";
            // 
            // textBoxPerfil
            // 
            this.textBoxPerfil.Location = new System.Drawing.Point(616, 122);
            this.textBoxPerfil.Name = "textBoxPerfil";
            this.textBoxPerfil.Size = new System.Drawing.Size(242, 26);
            this.textBoxPerfil.TabIndex = 8;
            // 
            // perfil
            // 
            this.perfil.AutoSize = true;
            this.perfil.Location = new System.Drawing.Point(544, 122);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(44, 20);
            this.perfil.TabIndex = 7;
            this.perfil.Text = "Perfil";
            // 
            // InsertaUsuario
            // 
            this.InsertaUsuario.Location = new System.Drawing.Point(411, 412);
            this.InsertaUsuario.Name = "InsertaUsuario";
            this.InsertaUsuario.Size = new System.Drawing.Size(220, 88);
            this.InsertaUsuario.TabIndex = 6;
            this.InsertaUsuario.Text = "Inserta Usuario";
            this.InsertaUsuario.UseVisualStyleBackColor = true;
            this.InsertaUsuario.Click += new System.EventHandler(this.InsertaUsuario_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(218, 185);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(242, 26);
            this.textBoxNombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(218, 242);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(242, 26);
            this.textBoxPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // textBox1DNI
            // 
            this.textBox1DNI.Location = new System.Drawing.Point(218, 125);
            this.textBox1DNI.Name = "textBox1DNI";
            this.textBox1DNI.Size = new System.Drawing.Size(242, 26);
            this.textBox1DNI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.Especie);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.chip);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1192, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1192, 563);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 553);
            this.dataGridView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_user_48px.png");
            this.imageList1.Images.SetKeyName(1, "icons8_dog_paw_100px.png");
            this.imageList1.Images.SetKeyName(2, "icons8_folder_48px.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(634, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 26);
            this.textBox1.TabIndex = 20;
            // 
            // Especie
            // 
            this.Especie.AutoSize = true;
            this.Especie.Location = new System.Drawing.Point(534, 196);
            this.Especie.Name = "Especie";
            this.Especie.Size = new System.Drawing.Size(66, 20);
            this.Especie.TabIndex = 19;
            this.Especie.Text = "Especie";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(634, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 26);
            this.textBox2.TabIndex = 18;
            // 
            // chip
            // 
            this.chip.AutoSize = true;
            this.chip.Location = new System.Drawing.Point(562, 136);
            this.chip.Name = "chip";
            this.chip.Size = new System.Drawing.Size(38, 20);
            this.chip.TabIndex = 17;
            this.chip.Text = "chip";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(236, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 26);
            this.textBox3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(236, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(242, 26);
            this.textBox4.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "DNI_Dueño";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 609);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1DNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertaUsuario;
        private System.Windows.Forms.TextBox textBoxMascota;
        private System.Windows.Forms.Label mascota;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBoxPerfil;
        private System.Windows.Forms.Label perfil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Especie;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label chip;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
    }
}

