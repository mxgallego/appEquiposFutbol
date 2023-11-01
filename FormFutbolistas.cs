using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appEquiposfutbol
{
    public partial class FormFutbolistas : Form
    {
        private SqlConnection conexion;
        public FormFutbolistas()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=DESKTOP-B55J3VM\\MSSQLSERVER1;Initial Catalog=TEMPORADA2022;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);
        }

        private void lbInformacion_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarFut_Click(object sender, EventArgs e)
        {
            int identificacion = Convert.ToInt32(txtIdentificacion.Text);
            string nombre = txtNombreFut.Text;
            string equipo = txtEquipoFut.Text;
            int edad = 0;
            if (int.Parse(txtEdad.Text) <= 0)
            {
                MessageBox.Show("Por favor, Ingrese una edad positiva");
            }
            else
            {
                edad = int.Parse(txtEdad.Text);
            }
            int golesAnotados = 0;
            if (int.Parse(txtGolesAnotados.Text) < 0)
            {
                MessageBox.Show("Por favor, Ingrese valores positivos para los goles anotados en la temporada");
            }
            else
            {
                golesAnotados = int.Parse(txtGolesAnotados.Text);
            }
            string nacionalidad = txtNacionalidad.Text;
            string posicion = "";
            if (cbxPosicion.SelectedItem != null)
            {
                posicion = cbxPosicion.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una Posición");
            }
            string lesiones = "";
            if (cbxLesiones.SelectedItem != null)
            {
                lesiones = cbxLesiones.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione si ha tenido Lesiones en la temporada");
            }
            try
            {                           

                conexion.Open();
                string consulta = "INSERT INTO Futbolistas (IdentificacionFutbolista, NombreFutbolista, EquipoFutbol, EdadFutbolista, GolesAnotadosTemporada, Nacionalidad, Posicion, LesionesEnTemporada) " +
                                     "VALUES (@identificacion, @nombre, @equipo, @edad, @golesAnotados, @nacionalidad, @posicion, @lesiones)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@identificacion", identificacion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@equipo", equipo);
                comando.Parameters.AddWithValue("@edad", edad);
                comando.Parameters.AddWithValue("@golesAnotados", golesAnotados);
                comando.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                comando.Parameters.AddWithValue("@posicion", posicion);
                comando.Parameters.AddWithValue("@lesiones", lesiones);

                comando.ExecuteNonQuery();
                MessageBox.Show("Futbolista guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Futbolista: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            limpiarFormulario();

        }

        private void limpiarFormulario()
        {
            txtIdentificacion.Text = string.Empty;
            txtNombreFut.Text = string.Empty;
            txtEquipoFut.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtGolesAnotados.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            cbxPosicion.Text = string.Empty;
            cbxLesiones.Text = string.Empty;
            txtIdentificacion.Focus();
        }

        private void FormFutbolistas_Load(object sender, EventArgs e)
        {

        }

        private void btnListadoFut_Click(object sender, EventArgs e)
        {
            FormListadoFutbolistas formularioListadoFub = new FormListadoFutbolistas();
            formularioListadoFub.Show();
        }
    }
}
