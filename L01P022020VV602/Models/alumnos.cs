using System.ComponentModel.DataAnnotations;

namespace L01P022020VV602.Models
{
    public class alumnos
    {
        [Key]
        [Display(Name = "ID del Alumno")]
        public int id { get; set; }
        [Display(Name = "Codigo del Alumno")]
        public string? codigo { get; set; }
        [Display(Name = "Nombre del Alumno")]
        public string? nombre { get; set; }
        [Display(Name = "Apellido del Alumno")]
        public string? apellidos { get; set; }
        [Display(Name = "DUI del Alumno")]
        public int? DUI { get; set; }
        [Display(Name = "Estado")]
        public int? estado { get; set; }
    }
}
