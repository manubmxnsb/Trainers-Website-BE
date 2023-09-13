using AutoMapper;
using HRManagement.DataAccess.Entities;
using HRManagement.Business.Models;

namespace HRManagementBusiness.Profiles
{
    public class CustomerProfile: Profile
    {

        public CustomerProfile() {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
