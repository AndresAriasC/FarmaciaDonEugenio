using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacionIIAPI.Models.Dto
{
    public class UpdateProductDto
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        //public int ProviderId { get; set; }
    }
}
