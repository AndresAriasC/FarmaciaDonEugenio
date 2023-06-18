using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoProgramacionIIAPI.Models.Dto
{
    public class ProductDto
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        public string CategoryId { get; set; }
        public string ProviderId { get; set; }
        public DateTime DateOfCreation { get; set; }

    }
}
