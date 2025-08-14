using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Conexion
{
    public class ConexionDB
    {
        private static string servidor = "LAB03-DS-EQ08\\SQLEXPRESS";
        private static string dbdata = "ZapatosDB";

        public static SqlConnection Conectar()
        {
            try
            {
                string cadena = $"Data source= {servidor};Initial Catalog {dbdata};Integrated security=true;";
                SqlConnection Conexion = new SqlConnection(cadena);
                Conexion.Open();
                return Conexion;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo conectar al servidor"+ex,
                    "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
        }
    }
}
