using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacionIIAPI.Models.Dto
{
    public class ProviderDtofarm
    {
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
