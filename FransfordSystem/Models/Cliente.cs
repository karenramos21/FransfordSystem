using System.ComponentModel.DataAnnotations;

namespace FransfordSystem.Models
{
    public class Cliente
    {
        [Display(Name = "idCliente")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Key]
        public int IdCliente { get; set; }


        [Display(Name = "idUsuario")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int UserName { get; set; }
        public Usuario usuario { get; set; }



        [Display(Name = "Nombres del Cliente")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese un nombre válido")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nombreCliente { get; set; }

        [Display(Name = "Apellidos del cliente")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese un apellido válido")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string apellidoCliente { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime fechaNacimiento { get; set; }

        [Display(Name = "Genero")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese un genero valido")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string genero { get; set; }

        [Display(Name = "DUI")]
        [RegularExpression(@"^[0-9]{8}-[0-9]{1}$", ErrorMessage = "El formato de DUI no es correcto, asegurese de agregar el guion")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string dui { get; set; }






    }
}
