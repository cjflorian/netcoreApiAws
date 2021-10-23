using AutoMapper;
using Commander.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuesApi.Models;

namespace Commander.Profiles
{
    public class UserRolesProfile : Profile
    {
        public UserRolesProfile()
        {
            CreateMap<UserRole, UserRoleReadDto>();
            CreateMap<UserRoleCreateDto, UserRole>();
            CreateMap<UserRoleUpdateDto, UserRole>();
        }
            
    }
}
