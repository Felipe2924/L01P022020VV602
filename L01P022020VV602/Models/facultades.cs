using System.ComponentModel.DataAnnotations;

namespace L01P022020VV602.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID de la Facultad")]
        public int id { get; set; }
        [Display(Name = "Facultad")]
        public string? facultad { get; set; }
    }
}
