using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacionIIAPI.Models.Dto
{
    public class CreateProductDto
    {
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int ProviderId { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
