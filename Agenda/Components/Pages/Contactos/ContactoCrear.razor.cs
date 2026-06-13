using Agenda.Data.Dtos;
using Agenda.Services;
using Microsoft.AspNetCore.Components;

namespace Agenda.Components.Pages.Contactos
{
    public partial class ContactoCrear
    {
        protected ContactoNuevoDto Contacto { get; set; } = new();

        [Inject] private ContactoService ContactoService { get; set; } = default!;

        protected string? Mensaje { get; set; }

        protected async Task GuardarAsync()
        {
            await ContactoService.AgregarContactoAsync(Contacto);

            Mensaje = $"Contacto {Contacto.Nombre} guardado correctamente.";

            // Limpiar formulario
            Contacto = new ContactoNuevoDto();

            await Task.CompletedTask;
        }
    }
}
