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
    public partial class FormEquipos : Form
    {
        private SqlConnection conexion;
        public FormEquipos()
        {
            InitializeComponent();            
            string cadenaConexion = "Data Source=DESKTOP-B55J3VM\\MSSQLSERVER1;Initial Catalog=TEMPORADA2022;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);          

        }

        private void btnGuardarEqui_Click(object sender, EventArgs e)
        {
            string codigoEquipo = txtCodigoEqui.Text;
            int longitudCodigo = codigoEquipo.Length;
            if (longitudCodigo > 3)
            {
                MessageBox.Show("Para el codigo máximo 3 letras, ejemplos BAR, AME, JUV");
            }
            string nombreEquipo = txtNombreEqui.Text;
            string pais = txtPais.Text;
            string categoria = "";
            if (cbxCategoria.SelectedItem != null)
            {
                categoria = cbxCategoria.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría");
            }
            int anioFundacion = Convert.ToInt32(txtAnioFundacion.Text);
            
            decimal presupuesto = Convert.ToDecimal(txtPresupuesto.Text);
            
            try
            {                          

                conexion.Open();
                string consulta = "INSERT INTO Equipos (CodigoEquipo, NombreEquipo, Pais, Categoria, AnioFundacion, Presupuesto) " +
                    "VALUES (@CodigoEquipo, @NombreEquipo, @Pais, @Categoria, @AnioFundacion, @Presupuesto)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodigoEquipo", codigoEquipo);
                comando.Parameters.AddWithValue("@NombreEquipo", nombreEquipo);
                comando.Parameters.AddWithValue("@Pais", pais);
                comando.Parameters.AddWithValue("@Categoria", categoria);
                comando.Parameters.AddWithValue("@AnioFundacion", anioFundacion);
                comando.Parameters.AddWithValue("@Presupuesto", presupuesto);
                comando.ExecuteNonQuery();
                MessageBox.Show("Equipo guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el equipo: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            limpiarFormulario();
            
        }

        private void limpiarFormulario() 
        {            
            txtCodigoEqui.Text = string.Empty;
            txtNombreEqui.Text = string.Empty;
            txtPais.Text= string.Empty;
            cbxCategoria.Text= string.Empty;
            txtAnioFundacion.Text = string.Empty;
            txtPresupuesto.Text = string.Empty;          
            txtCodigoEqui.Focus();
        }
        private void btnListadoEqui_Click(object sender, EventArgs e)
        {

            FormListadoEquipos formularioListadoEqui = new FormListadoEquipos();
            formularioListadoEqui.Show();
        }

        private void lbInformacion_Click(object sender, EventArgs e)
        {

        }
    }
}
