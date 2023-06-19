using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacionIIAPI.Models.Dto
{
    public class CreateCategoryDtofarm
    {
        [Required]
        [StringLength(50)]
        public string? CategoryName { get; set; }
    }
}
