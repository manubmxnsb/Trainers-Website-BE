using HRManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DataAccess.Repositories
{
    public interface IDBRepository
    { 
        public Task<Customer> EditCustomer(Customer customer);

        public Task<Customer> CustomerExists(long? customerId);

        Task<Customer?> GetCustomerAsync(long customerId, bool includeDocuments);
    }
}
