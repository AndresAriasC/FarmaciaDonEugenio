using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoProgramacionIIAPI.Models
{
    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProviderId { get; set; }
        [Required]
        public string RUTCode { get; set; }
        [Required]
        public string ProviderName { get; set; }
        [Required]
        public string ProviderEmail { get; set; }
        [Required]
        public int ProviderPhone { get; set; }
        [Required]
        public DateTime ProviderDate { get; set; } 


    }
}
