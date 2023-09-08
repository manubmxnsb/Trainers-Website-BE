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
            CreateMap<CustomerDtoApi,CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<DocumentDtoApi, DocumentDto>();
            CreateMap<DocumentDto, Document>();
        }
    }
}
