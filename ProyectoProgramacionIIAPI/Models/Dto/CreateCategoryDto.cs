using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacionIIAPI.Models.Dto
{
    public class CreateCategoryDto
    {
        [Required]
        [StringLength(50)]
        public string? CategoryName { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
