using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DataAccess.Repositories
{
    public class DBRepository : IDBRepository
    {
        private readonly HRManagementDBContext _context;

        public DBRepository(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Customer?> GetCustomerAsync(long customerId, bool includeDocuments)
        {
            if (includeDocuments)
            {
                return await _context.Customers.Include(customer => customer.Documents)
                    .Where(customer => customer.Id == customerId).FirstOrDefaultAsync();
            }
            return await _context.Customers
                .Where(customer => customer.Id == customerId).FirstOrDefaultAsync();
        }


        public async Task<Customer> EditCustomer(Customer customerToUpdate)
        {
            var customer = await CustomerExists(customerToUpdate.Id);

            customer.Id = customerToUpdate.Id;
            customer.Name = customerToUpdate.Name;
            customer.Email = customerToUpdate.Email;
            customer.Address = customerToUpdate.Address;
            customer.PhoneNumber = customerToUpdate.PhoneNumber;
            customer.Country = customerToUpdate.Country;
            customer.VAT = customerToUpdate.VAT;
            customer.BillingType = customerToUpdate.BillingType;
            customer.Details = customerToUpdate.Details;
            customer.IsActive = customerToUpdate.IsActive;
            customer.DateCreated = customerToUpdate.DateCreated;
            customer.Documents = customerToUpdate.Documents;

            _context.Customers.Update(customer);
            await(_context.SaveChangesAsync());
            return customer;
        }

        public async Task<Customer> CustomerExists(long? customerId)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
            if (customer == null)
                return null;
            else
                return customer;

        }

        
    }
}
