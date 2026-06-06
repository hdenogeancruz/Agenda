using Agenda.Data.Commands;
using Agenda.Data.Dtos;

namespace Agenda.Services
{
    public class ContactoService
    {
        private readonly ContactoCommand _contactoCommand;
        public ContactoService(ContactoCommand contactoCommand)
        {
            _contactoCommand = contactoCommand;
        }

        public async Task AgregarContactoAsync(string nombre, string apellido, string telefono, string correoElectronico)
        {
            try
            {
                var contacto = new ContactoNuevoDto
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    CorreoElectronico = correoElectronico
                };
                int afectados = await _contactoCommand.InsertarContactoAsync(contacto);

                if (afectados == 0) 
                {
                    throw new Exception("No se pudo agregar el contacto.");
                } 
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
