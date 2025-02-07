using System.ComponentModel.DataAnnotations;

namespace WebAppFormMVC.Models
{
    public class ContactMessage
    {
        public int id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo no valido")]

        public string Correo { get; set; }

        [Required(ErrorMessage = "El mensaje es obligatorio")]
        [StringLength(500, ErrorMessage = "El mensaje no puede superar los  500 caracteres")]
        public string Mensaje { get; set; }
    }
}
