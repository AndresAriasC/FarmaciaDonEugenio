using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoProgramacionIIAPI.Models
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public string ClientLastName { get; set; }
        [Required]
        public string ClientEmail { get; set; }
        [Required]
        public int ClientPhone { get; set; }
        [Required]
        public string ClientAdress { get; set; }
        [Required]
        public DateTime ClientDate { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
