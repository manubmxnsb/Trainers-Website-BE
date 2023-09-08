using AutoMapper;
using HRManagement.Business.Models;
using HRManagementApi.Models;

namespace HRManagement.Business.AutoMapper
{
    public class CustomerMapper : Profile
    {
       public CustomerMapper()
        {
            MapCustomer();
        }
         
      public void MapCustomer()
        {
         CreateMap<CustomerDto, Customer>();
         CreateMap<DataAccess.Entities.Customer, CustomerDto>();
         }
        
    }
}
