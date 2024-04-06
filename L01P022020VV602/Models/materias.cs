using System.ComponentModel.DataAnnotations;
namespace L01P022020VV602.Models
{
    public class materias
    {
        [Key]
        [Display(Name = "ID del Alumno")]
        public int id { get; set; }
        [Display(Name = "Materia")]
        public string? materia { get; set; }
        [Display(Name = "Unidades valorativas")]
        public int? unidades_valorativas { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
