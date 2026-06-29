using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace FigurasFlow
{
    public partial class FormUsuarios : Form
    {
        //creamos instancia de la clase coneccion
        private DataAcces coneccion;
        public FormUsuarios()
        {
            InitializeComponent();
        }

        //creamos un metodo para cargar los datos de la base de datos en el datagridview
        private void cargaDatos()
        {
            coneccion = new DataAcces();
            MySqlConnection con = coneccion.getConection();

            //comprobamos la coneccion
            if (con != null)
            {
                //creamos la consulta
                string consulta = "SELECT * FROM tblusuarios";

                //creamos un adaptador para almacenar los resultados de la consulta
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //ahora creamos un data table
                DataTable dt = new DataTable();
                //vaciamos el adapter al tadatable
                adapter.Fill(dt);

                //asiganamos el datatable al datagridview
                dgvUsuarios.DataSource = dt;
                //ocultamos el id en el datagridview o cualquier campo que no nos interese mostrar
                dgvUsuarios.Columns["idUsuario"].Visible = false;
                dgvUsuarios.Columns["PASSWORD"].Visible=false;
            }
        }

        private void gbBotones_Enter(object sender, System.EventArgs e)
        {

        }

        private void FormUsuarios_Load(object sender, System.EventArgs e)
        {
            cargaDatos();
        }

        private void dgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //virificamos que este seleccionada una celda
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                txtId.Text=row.Cells[0].Value.ToString();
                txtNombreUsuario.Text = row.Cells[1].Value.ToString();
                //txtPassword.Text=row.Cells[2].Value.ToString();
                cboPerfil.Text=row.Cells[3].Value.ToString();
                cboEstado.Text=row.Cells[4].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            //rescatamos los datos del formulario
            int id = int.Parse(txtId.Text);
            string nombre = txtNombreUsuario.Text;
            string password=txtPassword.Text;
            string perfil=cboPerfil.Text;
            string estado=cboEstado.Text;

            string passhash = "";
            if (!string.IsNullOrEmpty(password)) {
                passhash=BCrypt.Net.BCrypt.HashPassword(password);
            }

            coneccion = new DataAcces();
            MySqlConnection con = coneccion.getConection();

            string consulta;
            MySqlCommand command;

            //verificamos si vamos a hacer la consulta con actualizacion de password o no
            if (!string.IsNullOrEmpty(passhash))
            {
                consulta = "UPDATE tblusuarios " +
                    "SET nombreUsuario = @nombre, PASSWORD = @pass ,perfil = @perfil, estado = @estado " +
                    "WHERE idUsuario = @id";
                command = new MySqlCommand(consulta, con);
                command.Parameters.AddWithValue("@pass",passhash);
            }
            else
            {
                consulta = "UPDATE tblusuarios " +
                    "SET nombreUsuario = @nombre, perfil = @perfil, estado = @estado " +
                    "WHERE idUsuario = @id";
                command = new MySqlCommand(consulta, con);
            }
            //pasamos el resto de los parametros al command
            command.Parameters.AddWithValue("@nombre",nombre);
            command.Parameters.AddWithValue("@perfil", perfil);
            command.Parameters.AddWithValue("@estado", estado);
            command.Parameters.AddWithValue("@id",id);

            int filasAfectadas=command.ExecuteNonQuery();
            con.Close();

            if (filasAfectadas>0)
            {
                MessageBox.Show("Edicion Exitosa...");
                cargaDatos();
            }
            else
            {
                MessageBox.Show("Error al editar...");
            }
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            //rescatamos los datos del formulario
            int id = int.Parse(txtId.Text);
            string nombre = txtNombreUsuario.Text;

            //preguntamos antes de eliminar
            DialogResult respuesta = MessageBox.Show("En verdad quieres eliminar a : "+nombre+"?","Eliminar",MessageBoxButtons.YesNo);

            if(respuesta == DialogResult.No) {
                return;
            }

            try
            {
                coneccion = new DataAcces();
                MySqlConnection con = coneccion.getConection();

                string consulta = "DELETE FROM tblusuarios WHERE idUsuario = @id";
                MySqlCommand command = new MySqlCommand(consulta,con);
                command.Parameters.AddWithValue("@id", id);

                int filasAfectadas= command.ExecuteNonQuery();
                con.Close();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Registro eliminado exitosamente...");
                    cargaDatos();
                }
                else
                {
                    MessageBox.Show("Fallo al eliminar el registro...");
                }

            }catch(MySqlException ex) { 
                MessageBox.Show("Error al eliminar el registro : "+ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            coneccion = new DataAcces();
            MySqlConnection con = coneccion.getConection();

            if (con != null)
            {
                TextBox txt = (TextBox)sender;
                string consulta = "SELECT * FROM tblusuarios WHERE nombreUsuario LIKE @busqueda";
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);
                adapter.SelectCommand.Parameters.AddWithValue("@busqueda", "%" + txt.Text + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvUsuarios.DataSource = dt;
                dgvUsuarios.Columns["idUsuario"].Visible = false;
                dgvUsuarios.Columns["PASSWORD"].Visible = false;
            }
        }
    }
}
