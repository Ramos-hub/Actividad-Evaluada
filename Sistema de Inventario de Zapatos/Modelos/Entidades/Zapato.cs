using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Zapato
    {
        private int idZapato;
        private int idCateoria;
        private string nombre;
        private double precio;
        private string imagenURL;
        private DateTime fechaCreacion;

        public int IdZapato { get => idZapato; set => idZapato = value; }
        public int IdCateoria { get => idCateoria; set => idCateoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string ImagenURL { get => imagenURL; set => imagenURL = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

        public static DataTable CargarZapatos()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                string consultaQuery = "select *from vistaCategoria;";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable tablaCarga = new DataTable();
                add.Fill(tablaCarga);
                return tablaCarga;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos" + ex);
                return null;
                
            }
        }

        //Metodo praa insertarDatos
        public bool insertarZapatos()
        {
            try
            {
             //Siempre traer la conexion
             SqlConnection conexion = ConexionDB.Conectar();
                string consultaQueryInsert = "INSERTT INTO Zapatos (CategoriaId, Nombre, Precio, ImagenURL, FechaCreacion) values" +
                    "(@CategoriaId, @Nombre, @Precio, @ImagenURL, @FechaCreacion);";
                SqlCommand insertar = new SqlCommand(consultaQueryInsert, conexion);
                //Vamos a insertar o sustituir los @Nombre con los datos que se obtienen en los txt
                insertar.Parameters.AddWithValue("@CategoriaId", idCateoria);
                insertar.Parameters.AddWithValue("@Nombre", nombre);
                insertar.Parameters.AddWithValue("@Precio", precio);
                insertar.Parameters.AddWithValue("@ImagenURL", imagenURL);
                insertar.Parameters.AddWithValue("@FechaCreacion", fechaCreacion);
                insertar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verificar si la consulta de insertar esta correcta"+ex, "Error al insertar los datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
