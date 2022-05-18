using System.ComponentModel.DataAnnotations;


namespace FransfordSystem.Models
{
    public class Rol
    {


        [Display(Name = "idRol")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Key]
        public int IdCliente { get; set; }

        [Display(Name = "Nombres del Rol")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese nombres validos")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nombreRol { get; set; }

        [Display(Name = "Descripcion")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "ingrese apellidos validos")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string descripcionRol { get; set; }


    }
}
