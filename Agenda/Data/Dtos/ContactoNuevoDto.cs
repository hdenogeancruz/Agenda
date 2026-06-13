using System.ComponentModel.DataAnnotations;

namespace Agenda.Data.Dtos
{
    public class ContactoNuevoDto
    {
        
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, MinimumLength = 2,
        ErrorMessage = "El nombre debe tener entre 2 y 50 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(50, 
            ErrorMessage = "El apellido debe tener hasta 50 caracteres.")]
        public string Apellido { get; set; } = string.Empty;

        [MaxLength(20,
            ErrorMessage = "El teléfono no puede exceder 20 caracteres.")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo electrónico válido.")]
        [StringLength(255,
            ErrorMessage = "El correo electrónico no puede exceder 255 caracteres.")]
        public string CorreoElectronico { get; set; } = string.Empty;
    }
}
