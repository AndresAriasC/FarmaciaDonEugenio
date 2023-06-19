using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
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


        //Obtener uno de los registros de los productos por id

        [HttpGet("{id:int}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer el Producto con Id {id}");
                return BadRequest();
            }
            var product = await _productRepo.Get(s => s.ProductId == id);

            if (product == null)
            {
                _logger.LogError($"Error al traer el Producto con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<ProductDto>(product));
        }


        //Crea un registro nuevo de producto

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ProductDto>> AddProduct([FromBody] CreateProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _productRepo.Get(s => s.ProductCode.ToLower() == productDto.ProductCode.ToLower()) != null)
            {
                ModelState.AddModelError("El Codigo Existe", "¡El Producto con ese codigo ya existe!");
                return BadRequest(ModelState);
            }

            if (await _productRepo.Get(s => s.ProductName.ToLower() == productDto.ProductName.ToLower()) != null)
            {
                ModelState.AddModelError("El Nombre Existe", "¡El Producto con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (productDto == null)
            {
                return BadRequest(productDto);
            }

            Product modelo = _mapper.Map<Product>(productDto);

            await _productRepo.Create(modelo);

            return CreatedAtRoute("GetProduct", new { id = modelo.ProductId }, modelo);
        }

        //PARA ELIMINAR UN REGISTRO ANDRES

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var product = await _productRepo.Get(s => s.ProductId == id);

            if (id == null)
            {
                return NotFound();
            }

            _productRepo.Remove(product);

            return NoContent();
        }

        //Para editar

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductDto productDto)
        {
            if (productDto == null || id != productDto.ProductId)
            {
                return BadRequest();
            }

            Product modelo = _mapper.Map<Product>(productDto);

            await _productRepo.Update(modelo);

            return NoContent();
        }

        //este no se muy bien pa que es pero va y voy a preguntar luego


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartiaProduct(int id, JsonPatchDocument<UpdateProductDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var product = await _productRepo.Get(s => s.ProductId == id, tracked: false);

            UpdateProductDto productDto = _mapper.Map<UpdateProductDto>(product);

            if (product == null) return BadRequest();

            patchDto.ApplyTo(productDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Product modelo = _mapper.Map<Product>(productDto);

            _productRepo.Update(modelo);

            return NoContent();
        }
    }

}
