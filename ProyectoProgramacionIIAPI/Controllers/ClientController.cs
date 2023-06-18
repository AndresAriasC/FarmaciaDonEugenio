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
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IClientRepository _clientRepo;
        private readonly IMapper _mapper;

        public ClientController(ILogger<ClientController> logger, IClientRepository clientRepo, IMapper mapper)
        {
            _logger = logger;
            _clientRepo = clientRepo;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<ClientDto>>> GetClients()
        {
            _logger.LogInformation("Obtener los clientes");

            var Clientlist = await _clientRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(Clientlist));
        }

        //Obtener uno de los registros de los clientes por id

        [HttpGet("{id:int}", Name = "GetClient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]


        public async Task<ActionResult<ClientDto>> GetClient(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer el Cliente con Id {id}");
                return BadRequest();
            }
            var client = await _clientRepo.Get(s => s.ClientId == id);

            if (client == null)
            {
                _logger.LogError($"Error al traer el Cliente con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<ClientDto>(client));
        }

        //Crea un registro nuevo de cliente

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public async Task<ActionResult<ClientDto>> AddClient([FromBody] CreateClientDto clientDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _clientRepo.Get(s => s.ClientName.ToLower() == clientDto.ClientName.ToLower()) != null)
            {
                ModelState.AddModelError("El Nombre Existe", "¡El Cliente con ese nombre ya existe!");
                return BadRequest(ModelState);
            }


            if (clientDto == null)
            {
                return BadRequest(clientDto);
            }

            Client modelo = _mapper.Map<Client>(clientDto);

            await _clientRepo.Create(modelo);

            return CreatedAtRoute("GetClient", new { id = modelo.ClientId }, modelo);
        }

        //PARA ELIMINAR UN REGISTRO ANDRES

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteClient(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var client = await _clientRepo.Get(s => s.ClientId == id);

            if (id == null)
            {
                return NotFound();
            }

            _clientRepo.Remove(client);

            return NoContent();
        }


        //Para editar

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateClient(int id, [FromBody] UpdateClientDto clientDto)
        {
            if (clientDto == null || id != clientDto.ClientId)
            {
                return BadRequest();
            }

            Client modelo = _mapper.Map<Client>(clientDto);

            await _clientRepo.Update(modelo);

            return NoContent();
        }

        //este no se muy bien pa que es pero va y voy a preguntar luego


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartiaClient(int id, JsonPatchDocument<UpdateClientDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var client = await _clientRepo.Get(s => s.ClientId == id, tracked: false);

            UpdateClientDto clientDto = _mapper.Map<UpdateClientDto>(client);

            if (client == null) return BadRequest();

            patchDto.ApplyTo(clientDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Client modelo = _mapper.Map<Client>(clientDto);

            _clientRepo.Update(modelo);

            return NoContent();
        }

        
    }
}
