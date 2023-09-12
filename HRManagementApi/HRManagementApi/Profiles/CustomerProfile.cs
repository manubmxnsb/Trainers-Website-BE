using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
using HRManagementApi.Models;

namespace HRManagementApi.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel,CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}
