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
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public UsersController(ILogger<UsersController> logger, IUserRepository userRepo, IMapper mapper)
        {
            _logger = logger;
            _userRepo = userRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            _logger.LogInformation("Obtener los usuarios");

            var Userlist = await _userRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<UserDto>>(Userlist));
        }


        //Obtener uno de los registros de los usuarios por id

        [HttpGet("{id:int}", Name = "GetUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer el Usuario con Id {id}");
                return BadRequest();
            }
            var user = await _userRepo.Get(s => s.UserId == id);

            if (user == null)
            {
                _logger.LogError($"Error al traer el Usuario con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<UserDto>(user));
        }

        //Crea un registro nuevo de producto

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<UserDto>> AddUser([FromBody] UserCreateDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _userRepo.Get(s => s.EmployeeCode.ToLower() == userDto.EmployeeCode.ToLower()) != null)
            {
                ModelState.AddModelError("El Codigo Existe", "¡El empleado con ese codigo ya existe!");
                return BadRequest(ModelState);
            }

            if (await _userRepo.Get(s => s.UserName.ToLower() == userDto.UserName.ToLower()) != null)
            {
                ModelState.AddModelError("El Nombre Existe", "¡El empleado con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (userDto == null)
            {
                return BadRequest(userDto);
            }

            User modelo = _mapper.Map<User>(userDto);

            await _userRepo.Create(modelo);

            return CreatedAtRoute("GetUser", new { id = modelo.UserId }, modelo);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var user = await _userRepo.Get(s => s.UserId == id);

            if (id == null)
            {
                return NotFound();
            }

            _userRepo.Remove(user);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UserUpdateDto userDto)
        {
            if (userDto == null || id != userDto.UserId)
            {
                return BadRequest();
            }

            User modelo = _mapper.Map<User>(userDto);

            await _userRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialUser(int id, JsonPatchDocument<UserUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var product = await _userRepo.Get(s => s.UserId == id, tracked: false);

            UserUpdateDto userDto = _mapper.Map<UserUpdateDto>(product);

            if (product == null) return BadRequest();

            patchDto.ApplyTo(userDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            User modelo = _mapper.Map<User>(userDto);

            _userRepo.Update(modelo);

            return NoContent();
        }

    }
}
