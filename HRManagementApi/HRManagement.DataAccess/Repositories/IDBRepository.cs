using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DataAccess.Repositories
{
    public interface IDBRepository
    { 

        Task<Customer?> GetCustomerAsync(long customerId, bool includeDocuments);

        public Task<bool> CustomerExistsAsync(long customerId);

        public Task<bool> SaveChangesAsync();
        
    }
}
