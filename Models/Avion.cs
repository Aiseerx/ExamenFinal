using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Avion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string NumeroAvion { get; set; }

        [Required]
        [MaxLength(50)]
        public string Modelo { get; set; }

        [Required]
        public decimal Peso { get; set; }

        [Required]
        public int Capacidad { get; set; }

    }
}
