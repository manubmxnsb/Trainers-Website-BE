using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Repositories;

namespace HRManagement.Business.Interface
{
    public interface ICustomerService
    {
        Task<CustomerDTO> GetCustomer(long id, bool includeDocuments);
    }
}
