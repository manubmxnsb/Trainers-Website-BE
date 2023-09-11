using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;

namespace HRManagement.Business.Services
{
    public interface IBusinessService
    {
        public Task DeleteCustomer(CustomersForDeletionDto customerIdsDto);
    }
}
