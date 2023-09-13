using HRManagement.Business.Models;

namespace HRManagement.Business.Interface
{
    public interface ICustomerService
    {

        public Task EditCustomer(CustomerDto customerToUpdate);

    }
}
