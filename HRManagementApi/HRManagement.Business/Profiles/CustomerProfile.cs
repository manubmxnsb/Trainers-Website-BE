using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;

namespace HRManagement.Business.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerSummaryDto>();
        }
    }
}
