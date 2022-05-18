using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System;



namespace FransfordSystem.Models

{
    public class Trabajador
    {
        [Display(Name = "idTrabajador")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Key]
        public int IdTrabajador { get; set; }

        [Display(Name = "Nombres del Trabajador")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+", ErrorMessage = "Ingrese nombres validos")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nombreTrabajador { get; set; }

        [Display(Name = "Apellidos del trabajador")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+" ,ErrorMessage = "ingrese apellidos validos")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string apellidoTrabajador { get; set; }

        //[Display(Name = "Fecha de nacimiento")]
        //[RegularExpression( ,ErrorMessage = "ingrese una fecha de nacimiento valida")]
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public DateTime fechaNacimiento { get; set; }

        [Display(Name = "Genero")]
        [RegularExpression(@"[ A-Za-zäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙÑñ.-]+" ,ErrorMessage = "Ingrese un genero valido")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string genero { get; set; }

        [Display(Name = "DUI")]
        [RegularExpression(@"^[0-9]{8}-[0-9]{1}$", ErrorMessage = "El formato de DUI no es correcto, asegurese de agregar el guion")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string dui { get; set; }

        [Display(Name = "Correo")]
        [RegularExpression(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$", ErrorMessage = "Ingrese un correo válido")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string correo { get; set; }

        [Display(Name = "Cuenta Bancaria")]
        [RegularExpression(@"^[0-9]{10}$",ErrorMessage = "ingrese una cuenta bancaria valida")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string cuentaBancaria { get; set; }

    }
}