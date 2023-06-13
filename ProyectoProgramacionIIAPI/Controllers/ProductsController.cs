using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProyectoProgramacionIIAPI.Models;
using ProyectoProgramacionIIAPI.Models.Dto;
using ProyectoProgramacionIIAPI.Repository.IRepository;

namespace ProyectoProgramacionIIAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
          private readonly IProductRepository _productRepo;
        private readonly IMapper _mapper;


        public ProductsController(ILogger<ProductsController> logger, IProductRepository productRepo, IMapper mapper)
        {
            _logger = logger;
            _productRepo = productRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            _logger.LogInformation("Obtener los productos");

            var Productlist = await _productRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(Productlist));
        }

    }

}
