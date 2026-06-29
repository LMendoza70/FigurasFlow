using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FigurasFlow
{
    /*=============================================================================
     *  FormRegistro
     *  Formulario de registro de usuarios con proteccion de contrasenas
     *  utilizando BCrypt (algoritmo de hashing con sal automatica).
     *
     *  Importante:
     *  - BCrypt genera un hash diferente cada vez aunque la contrasena sea la misma
     *    (porque usa un "salt" aleatorio incorporado en el propio hash).
     *  - El hash generado incluye: version, costo, salt (22 chars) y hash (31 chars).
     *    Ejemplo: $2a$11$K7Q5pL9mGxP1z8R3T5V7OeH2J4N6Q8R0T2V4W6Y8A0C2E4G6I8K0M2O4
     *  - El metodo BCrypt.Verify() extrae el salt del hash existente y lo reusa
     *    para verificar la contrasena ingresada.
     *=============================================================================
     */

    public partial class FormRegistro : Form
    {
        // Constructor del formulario
        private DataAcces coneccion;
        public FormRegistro()
        {
            InitializeComponent();
        }

        /*=============================================================================
         *  Evento: btnRegistrar_Click
         *  Se ejecuta al hacer clic en el boton "Registrar".
         *  Valida los campos, hashea la contrasena con BCrypt y muestra
         *  el resultado (en un entorno real, aqui se guardaria en la base de datos).
         *=============================================================================
         */
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //-------------------------------------------------
            // 1. Validar que los campos obligatorios no esten vacios
            //-------------------------------------------------
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show(
                    "El nombre de usuario es obligatorio.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Enfocar el campo para que el usuario corrija
                txtNombreUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "La contrasena es obligatoria.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmarPassword.Text))
            {
                MessageBox.Show(
                    "Debe confirmar la contrasena.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmarPassword.Focus();
                return;
            }

            //-------------------------------------------------
            // 2. Validar que las contrasenas coincidan
            //-------------------------------------------------
            if (txtPassword.Text != txtConfirmarPassword.Text)
            {
                MessageBox.Show(
                    "Las contrasenas no coinciden. Verifique ambas.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Limpiar ambos campos para que el usuario reingrese
                txtPassword.Clear();
                txtConfirmarPassword.Clear();
                txtPassword.Focus();
                return;
            }

            //-------------------------------------------------
            // 3. Validar longitud minima de la contrasena
            //-------------------------------------------------
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show(
                    "La contrasena debe tener al menos 6 caracteres.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            //-------------------------------------------------
            // 4. Hashear la contrasena usando BCrypt
            //-------------------------------------------------
            // BCrypt.Net.BCrypt.HashPassword():
            //   - Genera automaticamente un "salt" criptografico aleatorio
            //   - Combina el salt con la contrasena y aplica el algoritmo
            //     Blowfish (20 rondas por defecto, costo 11 aprox).
            //   - Retorna un string de 60 caracteres que contiene todo
            //     lo necesario para verificar la contrasena en el futuro.
            //
            //  Parametros:
            //    - input: la contrasena en texto plano
            //    - workFactor (opcional): numero de rondas (mayor = mas seguro pero mas lento)
            //      Por defecto es 11 (2^11 = 2048 iteraciones del Blowfish).
            //
            //  Nunca guardamos la contrasena original en texto plano.
            //-------------------------------------------------
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

            //aqui se insertaria el registro en la BD.
            //-------------------------------------------------

            //conectamos
            coneccion = new DataAcces();
            MySqlConnection con = coneccion.getConection();

            //creamos la consulta
            string consulta = "INSERT INTO tblusuarios (nombreUsuario, PASSWORD, perfil, estado)" +
                " VALUES (@nombre, @pwd, @perfil, @estado)";

            //creamos el command
            MySqlCommand command = new MySqlCommand(consulta, con);
            //pasamos los parametros 
            command.Parameters.AddWithValue("@nombre", txtNombreUsuario.Text);
            command.Parameters.AddWithValue("@pwd",passwordHash);
            command.Parameters.AddWithValue("@perfil",cboPerfil.Text);
            command.Parameters.AddWithValue("@estado",cboEstado.Text);
            //ejecutamos el command pero guardamos el numero de lineas afectadas
            //en una variable para saber si se hizo o no la insercion
            int filasAfectadas = command.ExecuteNonQuery();
            //crerramos la coneccion
            con.Close();

            //verificamos registro
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Registro exitoso");
            }
            else{
                MessageBox.Show("Algo falló");
            }
        
            //-------------------------------------------------
            // 6. Limpiar el formulario para un nuevo registro
            //-------------------------------------------------
            LimpiarFormulario();
        }

        /*=============================================================================
         *  Evento: btnCancelar_Click
         *  Cierra el formulario sin registrar nada.
         *=============================================================================
         */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*=============================================================================
         *  Metodo: LimpiarFormulario
         *  Restablece todos los campos a su valor inicial.
         *=============================================================================
         */
        private void LimpiarFormulario()
        {
            txtNombreUsuario.Clear();
            txtPassword.Clear();
            txtConfirmarPassword.Clear();
            cboPerfil.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
            txtNombreUsuario.Focus();
        }
    }
}
