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
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryController(ILogger<CategoryController> logger, ICategoryRepository categoryRepo, IMapper mapper)
        {
            _logger = logger;
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategories()
        {
            _logger.LogInformation("Obtener las categorias");

            var Categorylist = await _categoryRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(Categorylist));
        }

        //Obtener uno de los registros de las categorias por id

        [HttpGet("{id:int}", Name = "GetCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoryDto>> GetCategory(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer la Categoria con Id {id}");
                return BadRequest();
            }
            var category = await _categoryRepo.Get(s => s.CategoryId == id);

            if (category == null)
            {
                _logger.LogError($"Error al traer la Categoria  con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<CategoryDto>(category));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<CategoryDto>> AddCategory([FromBody] CreateCategoryDto categoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _categoryRepo.Get(s => s.CategoryName.ToLower() == categoryDto.CategoryName.ToLower()) != null)
            {
                ModelState.AddModelError("El Nombre Existe", "¡La Categoria con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (categoryDto == null)
            {
                return BadRequest(categoryDto);
            }

            Category modelo = _mapper.Map<Category>(categoryDto);

            await _categoryRepo.Create(modelo);

            return CreatedAtRoute("GetCategory", new { id = modelo.CategoryId }, modelo);
        }

        //PARA ELIMINAR UN REGISTRO ANDRES

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var category = await _categoryRepo.Get(s => s.CategoryId == id);

            if (id == null)
            {
                return NotFound();
            }

            _categoryRepo.Remove(category);

            return NoContent();
        }

        //Para editar

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] UpdateCategoryDto categoryDTO)
        {
            if (categoryDTO == null || id != categoryDTO.CategoryId)
            {
                return BadRequest();
            }
            Category modelo = _mapper.Map<Category>(categoryDTO);

            await _categoryRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartiaCategory(int id, JsonPatchDocument<UpdateCategoryDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var category = await _categoryRepo.Get(s => s.CategoryId == id, tracked: false);

            UpdateCategoryDto categoryDto = _mapper.Map<UpdateCategoryDto>(category);

            if (category == null) return BadRequest();

            patchDto.ApplyTo(categoryDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Category modelo = _mapper.Map<Category>(categoryDto);

            _categoryRepo.Update(modelo);

            return NoContent();
        }

    }
}
