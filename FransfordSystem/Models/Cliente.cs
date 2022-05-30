using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FransfordSystem.Models
{
    public class Cliente
    {
        [Display(Name = "idCliente")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Key]
        public int IdCliente { get; set; }


        [Display(Name = "idUsuario")]       
        public int? UserName { get; set; }
        public Usuario? usuario { get; set; }


        [Display(Name = "Nombres del Cliente")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese un nombre válido")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nombreCliente { get; set; }

        [Display(Name = "Apellidos del cliente")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese un apellido válido")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string apellidoCliente { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        //[RegularExpression(@"\b(?<day>\d{1,2})/(?<month>\d{1,2})/(?<year>\d{2,4})\b", ErrorMessage = "ingrese una fecha de nacimiento valida")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime fechaNacimiento { get; set; }

        [Display(Name = "Genero")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese un genero valido")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string genero { get; set; }

        [Display(Name = "Telefono")]
        [RegularExpression(@"^[2,6,7]\d{3}-?\d{4}$", ErrorMessage = "Ingrese un número telefónico válido")]
        public string? telefono { get; set; }

        [Display(Name = "DUI")]
        [RegularExpression(@"^[0-9]{8}-[0-9]{1}$", ErrorMessage = "El formato de DUI no es correcto, asegúrese de agregar el guión")]
        public string? dui { get; set; }




    }
}
