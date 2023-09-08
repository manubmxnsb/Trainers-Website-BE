using AutoMapper;
using HRManagement.DataAccess.Entities;
using HRManagement.Business.Models;

using Microsoft.EntityFrameworkCore.Infrastructure;

namespace HRManagementBusiness.Profiles
{
    public class CustomerProfile: Profile
    {

        public CustomerProfile() {
            CreateMap<Customer, CustomerWithoutDocumentDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Customer, CustomerForEditDto>();
            CreateMap<CustomerForEditDto, Customer>();
        }
    }
}
