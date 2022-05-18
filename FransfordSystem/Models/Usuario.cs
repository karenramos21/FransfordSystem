using System.ComponentModel.DataAnnotations;

namespace FransfordSystem.Models
{
    public class Usuario
    {
        [Display(Name = "idUsuario")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Key]
        public int IdUsuario { get; set; }

        [Display(Name = "Nombres del Usuario")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese nombres validos")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nombreUsuario { get; set; }

        [Display(Name = "Contrase;a")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "ingrese apellidos validos")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string contrasenia { get; set; }





    }
}
