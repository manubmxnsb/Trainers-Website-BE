using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
using HRManagement.Business.Models;

namespace HRManagement.DataAccess.Profiles
{
    public class CustomerProfile : Profile
    {

        public CustomerProfile() 
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
