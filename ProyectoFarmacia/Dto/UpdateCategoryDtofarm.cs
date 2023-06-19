using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacionIIAPI.Models.Dto
{
    public class UpdateCategoryDtoFarm
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string? CategoryName { get; set; }
    }
}
