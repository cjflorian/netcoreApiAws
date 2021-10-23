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
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _repository;
        private readonly IMapper _mapper;

        UsersController(IUserRepo repository, IMapper mapper)//inyeccion de mockup
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<dynamic>> GetAllCommands()
        {
            var userItems = _repository.GetUsers();
            return Ok(_mapper.Map<IEnumerable<dynamic>>(userItems));
        }

        [HttpGet("{id}")]
        public ActionResult<UserReadDto> GetCommandByID(int id)
        {
            var userItem = _repository.GetUserById(id);
            if (userItem != null)
                return Ok(_mapper.Map<UserReadDto>(userItem));
            else
                return NotFound();

        }
        //POST api/command
        [HttpPost]
        public ActionResult<UserReadDto> CreateCommand(UserCreateDto userCreateDto)
        {
            //var find = _repository.GetCommandLast();

            //commandCreateDto.Id = find.Id+1;
            var userModel = _mapper.Map<User>(userCreateDto);
            _repository.CreateUser(userModel);

            return Ok(userModel);
        }
        //UPDATE api/command
        [HttpPut]
        public ActionResult<UserReadDto> UpdateCommand(UserUpdateDto userUpdateDto)
        {
            //var find = _repository.GetCommandLast();

            //commandCreateDto.Id = find.Id+1;
            var userModel = _mapper.Map<User>(userUpdateDto);
            _repository.UpdateUser(userModel);

            return Ok(userModel);
        }
    }
}
