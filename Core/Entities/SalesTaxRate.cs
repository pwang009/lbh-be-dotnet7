using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public record SalesTaxRate
    {
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public string County { get; set; } = string.Empty;
        [Required]
        public decimal Rate { get; set; } = 0.0m;
        [Required]
        public bool isIncorporated { get; set; } = false;
    }
}
