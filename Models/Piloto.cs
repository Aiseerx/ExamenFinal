using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class Piloto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string NumeroLicencia { get; set; }

        [MaxLength(100)]
        public string Restricciones { get; set; }

        [Required]
        public decimal Salario { get; set; }

        [Required]
        [MaxLength(10)]
        public string Turno { get; set; }
    }
}
