using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Hangar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string NumeroHangar { get; set; }

        [Required]
        public int Capacidad { get; set; }

        [Required]
        [MaxLength(100)]
        public string Localizacion { get; set; }
    }
}
