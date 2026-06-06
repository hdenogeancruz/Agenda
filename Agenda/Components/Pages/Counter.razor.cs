using Agenda.Services;
using Microsoft.AspNetCore.Components;

namespace Agenda.Components.Pages
{
    public partial class Counter
    {
        [Inject] private ContactoService ContactoService { get; set; }

        private int currentCount = 0;

        private async Task IncrementCount()
        {
            currentCount++;
            await Ejecutacomando2();

        }



        private async Task Ejecutacomando2()
        {
            await ContactoService.AgregarContactoAsync("Hector", "Denogean", "6627200912", "g@gmail.com");
        }
    }
}