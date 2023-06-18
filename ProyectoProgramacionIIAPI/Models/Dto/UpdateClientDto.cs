using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacionIIAPI.Models.Dto
{
    public class UpdateClientDto
    {

        [Required]
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
        
        public int ProductId { get; set; }
    }
}
