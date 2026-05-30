using Microsoft.Data.SqlClient;
using System.Data;

namespace Agenda.Components.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            //cadena de conexion usando credenciales sql server
            //string connectionString = "Server=localhost;Database=AgendaDb;User Id=sa;Password=your_password;";
            //cadena de conexion usando autenticacion integrada de windows
            string connectionString = "Server=localhost;Database=AgendaDb;Trusted_Connection=True;TrustServerCertificate=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Contactos (Nombre, Apellido, Telefono, CorreoElectronico)" +
                " VALUES ('Hector','Denogean','6627200912','hdenogeancruz@gmail.com')";

            SqlCommand command = new SqlCommand(query, connection);

            command.CommandType = CommandType.Text;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
