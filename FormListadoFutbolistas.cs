using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEquiposfutbol
{
    public partial class FormListadoFutbolistas : Form
    {
        private SqlConnection conexion;
        public FormListadoFutbolistas()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=DESKTOP-B55J3VM\\MSSQLSERVER1;Initial Catalog=TEMPORADA2022;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);
        }

        private void FormListadoFutbolistas_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT nombreFutbolista AS FUTBOLISTA, " +
                              "LEN(nombreFutbolista) - LEN(REPLACE(nombreFutbolista, 'a', '')) AS REPETICIONES_A, " +
                              "LEN(nombreFutbolista) - LEN(REPLACE(nombreFutbolista, ' ', '')) + 1 AS NUMERO_PALABRAS " +
                              "FROM futbolistas";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtgvConsulta1.DataSource = dt;

            string consultaArqueros = "SELECT e.NombreEquipo AS EQUIPO, f.NombreFutbolista AS ARQUERO " +
                                      "FROM Futbolistas f " +
                                      "JOIN Equipos e ON f.EquipoFutbol = e.NombreEquipo " +
                                      "WHERE f.LesionesEnTemporada = 'SI' AND e.Categoria = 'C' " +
                                      "ORDER BY e.NombreEquipo; ";
            adaptador = new SqlDataAdapter(consultaArqueros, conexion);
            dt = new DataTable();
            adaptador.Fill(dt);
            dtgvConsulta4.DataSource = dt;
        }
    }
}
