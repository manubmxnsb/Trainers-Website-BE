using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Models;

namespace HRManagement.Business.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() 
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<Customer, CustomerSummaryDto>();
            CreateMap<PaginationItems, PaginationItemsDto>().ReverseMap();
        }
    }
}
