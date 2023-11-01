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
    public partial class FormListadoEquipos : Form
    {
        private SqlConnection conexion;
        public FormListadoEquipos()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=DESKTOP-B55J3VM\\MSSQLSERVER1;Initial Catalog=TEMPORADA2022;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);           
        }

        private void FormListadoEquipos_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT CodigoEquipo AS CODIGO_EQUIPO, NombreEquipo AS NOMBRE_EQUIPO, AnioFundacion AS AÑO_FUNDACION FROM equipos " +
                           "WHERE AnioFundacion >= 1900 AND AnioFundacion <= 1950";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtgvConsulta2.DataSource = dt;

            string consultaGoles = "SELECT e.NombreEquipo AS EQUIPO, f.NombreFutbolista AS JUGADOR, f.GolesAnotadosTemporada AS GOLES " +
                                   "FROM Futbolistas f JOIN Equipos e ON f.EquipoFutbol = e.NombreEquipo " +
                                   "WHERE f.GolesAnotadosTemporada > 10 AND e.Categoria = 'A'" +
                                   "ORDER BY f.GolesAnotadosTemporada DESC; ";
            adaptador = new SqlDataAdapter(consultaGoles, conexion);
            dt = new DataTable();
            adaptador.Fill(dt);
            dtgvConsulta3.DataSource = dt;
        }
    }
}
