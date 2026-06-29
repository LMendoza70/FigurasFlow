namespace FigurasFlow
{
    partial class FormRegistro
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>Limpiar los recursos que se esten usando.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Metodo necesario para admitir el Disenador. No se puede modificar
        /// el contenido de este metodo con el editor de codigo.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblConfirmarPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbRegistro.SuspendLayout();
            this.SuspendLayout();

            //=====================================================================
            //  gbRegistro - GroupBox que agrupa todos los campos de entrada
            //=====================================================================
            this.gbRegistro.Controls.Add(this.cboEstado);
            this.gbRegistro.Controls.Add(this.cboPerfil);
            this.gbRegistro.Controls.Add(this.txtConfirmarPassword);
            this.gbRegistro.Controls.Add(this.txtPassword);
            this.gbRegistro.Controls.Add(this.txtNombreUsuario);
            this.gbRegistro.Controls.Add(this.lblEstado);
            this.gbRegistro.Controls.Add(this.lblPerfil);
            this.gbRegistro.Controls.Add(this.lblConfirmarPassword);
            this.gbRegistro.Controls.Add(this.lblPassword);
            this.gbRegistro.Controls.Add(this.lblNombreUsuario);
            this.gbRegistro.Controls.Add(this.btnCancelar);
            this.gbRegistro.Controls.Add(this.btnRegistrar);
            this.gbRegistro.Location = new System.Drawing.Point(12, 12);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(400, 260);
            this.gbRegistro.TabIndex = 0;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro de Nuevo Usuario";

            //=====================================================================
            //  lblNombreUsuario / txtNombreUsuario
            //  Campo para el nombre unico del usuario (max 50 caracteres, segun BD)
            //=====================================================================
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(20, 30);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(101, 13);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario:";

            this.txtNombreUsuario.Location = new System.Drawing.Point(140, 27);
            this.txtNombreUsuario.MaxLength = 50;   // Coincide con varchar(50) de la BD
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(240, 20);
            this.txtNombreUsuario.TabIndex = 1;

            //=====================================================================
            //  lblPassword / txtPassword
            //  Contrasena que se ocultara con caracteres '*' y se hasheara con BCrypt
            //=====================================================================
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contrasena:";

            this.txtPassword.Location = new System.Drawing.Point(140, 62);
            this.txtPassword.MaxLength = 100;        // Coincide con varchar(100) de la BD
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';     // Oculta el texto mientras se escribe
            this.txtPassword.Size = new System.Drawing.Size(240, 20);
            this.txtPassword.TabIndex = 3;

            //=====================================================================
            //  lblConfirmarPassword / txtConfirmarPassword
            //  Confirmacion para evitar errores de tipeo en la contrasena
            //=====================================================================
            this.lblConfirmarPassword.AutoSize = true;
            this.lblConfirmarPassword.Location = new System.Drawing.Point(20, 100);
            this.lblConfirmarPassword.Name = "lblConfirmarPassword";
            this.lblConfirmarPassword.Size = new System.Drawing.Size(111, 13);
            this.lblConfirmarPassword.TabIndex = 4;
            this.lblConfirmarPassword.Text = "Confirmar contrasena:";

            this.txtConfirmarPassword.Location = new System.Drawing.Point(140, 97);
            this.txtConfirmarPassword.MaxLength = 100;
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.PasswordChar = '*';
            this.txtConfirmarPassword.Size = new System.Drawing.Size(240, 20);
            this.txtConfirmarPassword.TabIndex = 5;

            //=====================================================================
            //  lblPerfil / cboPerfil
            //  Nivel de acceso del usuario en el sistema
            //=====================================================================
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(20, 135);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(33, 13);
            this.lblPerfil.TabIndex = 6;
            this.lblPerfil.Text = "Perfil:";

            this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfil.Items.AddRange(new object[] {
                "Administrador",
                "Usuario",
                "Invitado"
            });
            this.cboPerfil.Location = new System.Drawing.Point(140, 132);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(240, 21);
            this.cboPerfil.TabIndex = 7;

            //=====================================================================
            //  lblEstado / cboEstado
            //  Define si el usuario puede iniciar sesion o no
            //=====================================================================
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(20, 170);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";

            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Items.AddRange(new object[] {
                "Activo",
                "Inactivo"
            });
            this.cboEstado.Location = new System.Drawing.Point(140, 167);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(240, 21);
            this.cboEstado.TabIndex = 9;

            //=====================================================================
            //  btnRegistrar
            //  Ejecuta la validacion, hashea la contrasena con BCrypt y muestra
            //  el resultado. En produccion hariamos INSERT en la BD.
            //=====================================================================
            this.btnRegistrar.Location = new System.Drawing.Point(140, 210);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 30);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            //=====================================================================
            //  btnCancelar
            //  Cierra el formulario sin realizar ninguna accion
            //=====================================================================
            this.btnCancelar.Location = new System.Drawing.Point(270, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            //=====================================================================
            //  FormRegistro
            //=====================================================================
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 284);
            this.Controls.Add(this.gbRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Usuario";
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.ResumeLayout(false);
        }

        // Declaracion de los controles del formulario
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmarPassword;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
