using AutoMapper;

namespace HRManagement.Business.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() 
        {
            CreateMap<DataAccess.Entities.Customer, Models.CustomerDto>();
        }
    }
}
