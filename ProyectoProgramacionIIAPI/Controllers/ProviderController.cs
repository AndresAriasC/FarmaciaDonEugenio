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
    public class ProviderController : ControllerBase
    {
        private readonly ILogger<ProviderController> _logger;
        private readonly IProviderRepository _providerRepo;
        private readonly IMapper _mapper;
        public ProviderController(ILogger<ProviderController> logger, IProviderRepository providerRepo, IMapper mapper)
        {
            _logger = logger;
            _providerRepo = providerRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProviderDto>>> GetProviders()
        {
            _logger.LogInformation("Obtener los proveedores");

            var Providerlist = await _providerRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProviderDto>>(Providerlist));
        }

        //Obtener uno de los registros de los proveedores por id

        [HttpGet("{id:int}", Name = "GetProvider")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProviderDto>> GetProvider(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer el Proveedor con Id {id}");
                return BadRequest();
            }
            var provider = await _providerRepo.Get(s => s.ProviderId == id);

            if (provider == null)
            {
                _logger.LogError($"Error al traer el Proveedor con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<ProviderDto>(provider));
        }

        //Crea un registro nuevo de proveedor

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ProviderDto>> AddProvider([FromBody] CreateProviderDto providerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _providerRepo.Get(s => s.RUTCode.ToLower() == providerDto.RUTCode.ToLower()) != null)
            {
                ModelState.AddModelError("El Codigo Existe", "¡El Proveedor con ese codigo ya existe!");
                return BadRequest(ModelState);
            }

            if (await _providerRepo.Get(s => s.ProviderName.ToLower() == providerDto.ProviderName.ToLower()) != null)
            {
                ModelState.AddModelError("El Nombre Existe", "¡El Proveedor con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (providerDto == null)
            {
                return BadRequest(providerDto);
            }

            Provider modelo = _mapper.Map<Provider>(providerDto);

            await _providerRepo.Create(modelo);

            return CreatedAtRoute("GetProvider", new { id = modelo.ProviderId }, modelo);
        }


        //PARA ELIMINAR UN REGISTRO ANDRES

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProvider(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var provider = await _providerRepo.Get(s => s.ProviderId == id);

            if (id == null)
            {
                return NotFound();
            }

            _providerRepo.Remove(provider);

            return NoContent();
        }


        //Para editar

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProvider(int id, [FromBody] UpdateProviderDto providerDto)
        {
            if (providerDto == null || id != providerDto.ProviderId)
            {
                return BadRequest();
            }

            Provider modelo = _mapper.Map<Provider>(providerDto);

            await _providerRepo.Update(modelo);

            return NoContent();
        }


        //este no se muy bien pa que es pero va y voy a preguntar luego


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartiaProvider(int id, JsonPatchDocument<UpdateProviderDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var provider = await _providerRepo.Get(s => s.ProviderId == id, tracked: false);

            UpdateProviderDto providerDto = _mapper.Map<UpdateProviderDto>(provider);

            if (provider == null) return BadRequest();

            patchDto.ApplyTo(providerDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Provider modelo = _mapper.Map<Provider>(providerDto);

            _providerRepo.Update(modelo);

            return NoContent();
        }

    }
}
