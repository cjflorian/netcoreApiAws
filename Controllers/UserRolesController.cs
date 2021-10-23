using AutoMapper;
using Commander.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuesApi.Data;
using ValuesApi.Models;

namespace Commander.Controllers
{
    [Route("api/user_roles")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRoleRepo _repository;
        private readonly IMapper _mapper;

        public UserRolesController(IUserRoleRepo repository, IMapper mapper)//inyeccion de mockup
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserRoleReadDto>> GetAllCommands()
        {
            var Items = _repository.GetAllUserRoles();
            return Ok(_mapper.Map<IEnumerable<UserRoleReadDto>>(Items));
        }

        [HttpGet("{id}")]
        public ActionResult<UserRoleReadDto> GetCommandByID(int id)
        {
            var Item = _repository.GetUserRoleById(id);
            if (Item != null)
                return Ok(_mapper.Map<UserRoleReadDto>(Item));
            else
                return NotFound();

        }
        //POST api/command
        [HttpPost]
        public ActionResult<UserRoleReadDto> CreateCommand(UserRoleCreateDto userRoleCreateDto)
        {
            //var find = _repository.GetCommandLast();

            //commandCreateDto.Id = find.Id+1;
            var userRoleModel = _mapper.Map<UserRole>(userRoleCreateDto);
            _repository.CreateUserRole(userRoleModel);

            return Ok(userRoleModel);
        }
        //UPDATE api/command
        [HttpPut]
        public ActionResult<UserRoleReadDto> UpdateCommand(UserRoleUpdateDto userRoleUpdateDto)
        {
            //var find = _repository.GetCommandLast();

            //commandCreateDto.Id = find.Id+1;
            var userRoledModel = _mapper.Map<UserRole>(userRoleUpdateDto);
            _repository.UpdateUserRole(userRoledModel);

            return Ok(userRoleUpdateDto);
        }
    }
}
