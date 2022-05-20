using System.ComponentModel.DataAnnotations;
namespace FransfordSystem.Models
{
    public class Categoria
    {
        //ID de la categoría
        [Display(Name = "idCategoria")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Key]
        public int IdCategoria { get; set; }

        //Nombre de la categoría
        [Display(Name = "Nombres de las categorías")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese nombres con caracteres válidos")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nombreCategoria { get; set; }

        //Tipos de categoría
        [Display(Name = "Tipos de categorías")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese nombres con caracteres válidos")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string tipoCategoria { get; set; }
    }
}
