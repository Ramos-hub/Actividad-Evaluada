using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmMantenimientoZapatos : Form
    {
        public frmMantenimientoZapatos()
        {
            InitializeComponent();
        }

        private void frmMantenimientoZapatos_Load(object sender, EventArgs e)
        {
            cargarEspecialidad();
            cargarZapatos();
        }
        private void cargarZapatos()
        {
            dgvAlmacen.DataSource = null;
            dgvAlmacen.DataSource = Zapato.CargarZapatos();
            //Cargar los daos en el otro DataGrid
            dgvEdit.DataSource = null;
            dgvEdit.DataSource = Zapato.CargarZapatos();
        }
        //Creando el metodo cargarEspecialidad o categoria
        private void cargarEspecialidad()
        {
            cbCategoria.DataSource = null;
            cbCategoria.DataSource = Categoria.cargarCategoria();
            //Ahora voy a usar el displayMember
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Id";
            //El -1 sirve para que no aparezca nada al momento de cargar la lista
            cbCategoria.SelectedIndex = -1;

            //----Tambien para el mismo pero para el form de actualizar
            cbActualizar.DataSource = null;
            cbActualizar.DataSource = Categoria.cargarCategoria();
            cbActualizar.DisplayMember = "Nombre";
            cbActualizar.ValueMember = "Id";
            cbActualizar.SelectedIndex = -1;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
            Zapato zap = new Zapato();
            zap.Nombre = txtNombreZapato.Text;
            zap.Precio = double.Parse(txtPrecio.Text);
            zap.FechaCreacion = dtpFechaRegistro.Value;
            zap.IdCateoria = Convert.ToInt32(cbCategoria.SelectedValue);
            zap.ImagenURL = "";
            zap.insertarZapatos();
            cargarZapatos();
            MessageBox.Show("Excelente datos registrados", "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error"+ ex, "Error de informacion",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Zapato zapatoEliminar = new Zapato();
            int id = int.Parse(dgvAlmacen.CurrentRow.Cells[0].Value.ToString());
            string registroAEliminar = dgvAlmacen.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este registro?\n" + registroAEliminar,
                "Advertencia eliminaras un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta==DialogResult.Yes)
            {
                if (zapatoEliminar.eliminarZapatos(id)== true)
                {
                    MessageBox.Show("Registro eliminado \n" + registroAEliminar, "Eliminado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarZapatos();
                }
            }
            else
            {
                MessageBox.Show("Registro no eliminado", "seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
