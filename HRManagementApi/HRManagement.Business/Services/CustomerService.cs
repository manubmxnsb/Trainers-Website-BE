using HRManagement.DataAccess.Repositories;

namespace HRManagement.Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }

        public async Task DeleteCustomers(List<long> customerIds)
        {
            if (customerIds != null && customerIds.Count > 0)
            {
                await _customerRepository.Delete(customerIds);
            }
            else
            {
                throw new InvalidOperationException("No customers were found!");
            }
        }

    }
}
