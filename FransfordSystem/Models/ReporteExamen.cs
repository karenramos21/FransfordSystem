using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FransfordSystem.Models
{
    public class ReporteExamen
    {

        [Display(Name = "idReporteExamen")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Key]
        public int IdReporteExamen { get; set; }

        [Display(Name = "Fecha de Reporte")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime fechaNacimiento { get; set; }



        public ICollection<Examen>? examenes { get; set; }
    }
}
