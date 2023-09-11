using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;

namespace HRManagement.Business.Profiles
{
    internal class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto,User>();
            CreateMap<User, UserDto>();
        }
    }
}
