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

        [Display(Name = "idCategoria")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int idCategoria { get; set; }
        public Categoria categoria { get; set; }

        public ICollection<Descripcion> descripcion { get; set; }


        [Display(Name = "Nombre de examen")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese un nombre valido")]
        public string nombreExamen { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{3}.[0-9]{2}$", ErrorMessage = "")]
        public float PrecioExamen { get; set; }
    }
}
