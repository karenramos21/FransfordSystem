using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FransfordSystem.Models
{
    public class Descripcion
    {
        [Key]
        [Required]
        public int idDescripcion { get; set; }

        [Display(Name = "idExamen")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int idExamen { get; set; }
        public Examen? examen { get; set; }


        [Required(ErrorMessage = "Debe de ingresar la descripción del examen")]
        [StringLength(50, ErrorMessage = "No puede escribir más de 50 caracteres")]
        [Display(Name = "Descripcion del examen")]
        public string descripcionExamen { get; set; }

       
        [RegularExpression(@"^[0-9]{2}$", ErrorMessage = "Valor invalido, debe ser de 0 a 15")]
        public int? valorMinimo { get; set; }

        
        [RegularExpression(@"^[0-9]{2}$", ErrorMessage = "Valor invalido, debe ser de 0 a 15")]
        public int? valorMaximo { get; set; }
    }
}
