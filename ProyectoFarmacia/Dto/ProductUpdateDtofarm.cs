using ProyectoProgramacionIIAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFarmacia.Dto
{
    public class ProductUpdateDtofarm
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
