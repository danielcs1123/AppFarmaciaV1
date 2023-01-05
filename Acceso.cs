using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AppFarmaciaV1
{
    public class Acceso:Conexion
    {
        public int IdAcceso { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        public Acceso() : base() { }

        public int Login()
        {
            try
            {
                int opt = 0;
                SqlCommand comando = new SqlCommand();
                this.cnx.Open();
                comando.Connection = this.cnx;
                comando.CommandText = "SELECT COUNT(*) FROM Acceso WHERE Usuario=@Usuario AND Password=@Password";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Usuario", this.Usuario);
                comando.Parameters.AddWithValue("@Password", this.Password);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    opt = int.Parse(leer[0].ToString());
                }
                return opt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
