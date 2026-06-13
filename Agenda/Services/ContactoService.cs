using Agenda.Data.Commands;
using Agenda.Data.Dtos;
using Agenda.Data.Entities;

namespace Agenda.Services
{
    public class ContactoService
    {
        private readonly ContactoCommand _contactoCommand;
        public ContactoService(ContactoCommand contactoCommand)
        {
            _contactoCommand = contactoCommand;
        }

        public async Task AgregarContactoAsync(ContactoNuevoDto contactoNuevoDto)
        {
            try
            {
                var contacto = new Contacto
                {
                    Nombre = contactoNuevoDto.Nombre,
                    Apellido = contactoNuevoDto.Apellido,
                    Telefono = contactoNuevoDto.Telefono,
                    CorreoElectronico = contactoNuevoDto.CorreoElectronico
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
