using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;

namespace HRManagement.Business.Interface
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task EditCustomer(CustomerDto customerToUpdate)
        {
            var customerEdit = _mapper.Map<Customer>(customerToUpdate);
            await _repository.EditCustomer(customerEdit);
        }
    }
}
