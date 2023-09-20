using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() 
        {
            CreateMap<CustomerDto, Customer>().ReverseMap();
        }
    }
}