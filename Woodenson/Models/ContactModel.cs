using System.ComponentModel.DataAnnotations;

namespace Woodenson.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Por favor ingresa el nombre")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "Por favor ingresa el correo")]
        public String Correo { get; set; }
        [Required(ErrorMessage = "Por favor ingresa el telefono")]
        public String Telefono { get; set; }
        [Required(ErrorMessage = "Por favor ingresa el Comentario")]
        public String Comentario { get; set; }

    }
}
