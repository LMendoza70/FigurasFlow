using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasFlow
{
    internal class DataAcces
    {
        private readonly string cadena;

        public DataAcces()
        {
            cadena = "Server=189.240.192.140; Database=bdescuelaterceros; Uid=grupo3a; Pwd=grupo3a; Port=3306";
        }

        public MySqlConnection getConection()
        {
            try
            {
                MySqlConnection con= new MySqlConnection(cadena);
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de coneccion : "+ex.Message);
                return null;
            }
    }
}
}
