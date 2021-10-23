using AutoMapper;
using Commander.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuesApi.Models;

namespace Commander.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            //Source -> Target
            CreateMap<User, UserReadDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
