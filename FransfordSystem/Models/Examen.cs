using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FransfordSystem.Models
{
    public class Examen
    {
        [Key]
        [Required]
        public int idExamen { get; set; }

        [Required]
        public string idCategoria { get; set; }
        public virtual Categoria categoria { get; set; }

        [Display(Name = "Nombre de examen")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese un nombre valido")]
        public string nombreExamen { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{3}.[0-9]{2}$", ErrorMessage = "")]
        public float PrecioExamen { get; set; }
    }
}
