using Agenda.Data.Dtos;
using Microsoft.Data.SqlClient;

namespace Agenda.Data.Commands
{
    public class ContactoCommand
    {
        private readonly SQLServer _sqlServer;

        public ContactoCommand(SQLServer sqlServer)
        {
           _sqlServer = sqlServer;
        }

        public async Task<int> InsertarContactoAsync(ContactoNuevoDto contacto)
        {
            string query = "INSERT INTO Contactos (Nombre, Apellido, Telefono, CorreoElectronico) " +
                           "VALUES (@Nombre, @Apellido, @Telefono, @CorreoElectronico)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre", contacto.Nombre),
                new SqlParameter("@Apellido", contacto.Apellido),
                new SqlParameter("@Telefono", contacto.Telefono),
                new SqlParameter("@CorreoElectronico", contacto.CorreoElectronico)
            };
            return await _sqlServer.NonQueryAsync(query, parameters);
        }
    }
}
