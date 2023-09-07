using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public void Delete(long customerId)
        {
            var customerToBeDeleted = _context.Customers.Where(c => c.Id == customerId).FirstOrDefault();
            if (customerToBeDeleted != null)
            {
                _context.Customers.Remove(customerToBeDeleted);
                _context.SaveChanges();
            }
            else {
                throw new InvalidOperationException($"No Customer with customer Id: {customerId} was found!");
            }

        }
    }
}
