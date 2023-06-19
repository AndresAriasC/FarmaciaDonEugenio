﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacionIIAPI.Models.Dto
{
    public class CategoryDtofarm
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string? CategoryName { get; set; }
    }
}
