using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace appEquiposfutbol
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = "Data Source=DESKTOP-B55J3VM\\MSSQLSERVER1;Initial Catalog=master;Integrated Security=True";
            string createDatabaseQuery = "CREATE DATABASE TEMPORADA2022";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand createDatabaseCommand = new SqlCommand(createDatabaseQuery, connection);
               createDatabaseCommand.ExecuteNonQuery();
            }

            // Conectar a la base de datos creada
            connectionString = "Data Source=DESKTOP-B55J3VM\\MSSQLSERVER1;Initial Catalog=TEMPORADA2022;Integrated Security=True";

            
            // Creación de la tabla Equipos en la base de datos
            string createTableQuery = "CREATE TABLE equipos (ID int IDENTITY(1,1) PRIMARY KEY, CodigoEquipo nvarchar(3) UNIQUE, NombreEquipo nvarchar(100),Pais nvarchar(50), Categoria char(1), AnioFundacion int, Presupuesto decimal(10, 2))";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
            }

            // Creación de la tabla Futbolista en la base de datos
            string createAnotherTableQuery = "CREATE TABLE futbolistas (IdentificacionFutbolista int PRIMARY KEY, NombreFutbolista nvarchar(100), EquipoFutbol nvarchar(100), EdadFutbolista int, GolesAnotadosTemporada int, Nacionalidad nvarchar(50), Posicion nvarchar(50), LesionesEnTemporada char(2))";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand createAnotherTableCommand = new SqlCommand(createAnotherTableQuery, connection);
                createAnotherTableCommand.ExecuteNonQuery();
            }
                        
            // Crear una instancia del formulario principal y ejecutar la aplicación
            Application.Run(new formPrincipal());
        }
    }
}
