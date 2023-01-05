using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace AppFarmaciaV1
{
    public class Conexion
    {
        protected SqlConnection cnx = null;
        private string cadena_conexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\bdfarmacia.mdf;Integrated Security=True";

        public Conexion()
        {
            cnx = new SqlConnection(cadena_conexion);
        }
    }
}
