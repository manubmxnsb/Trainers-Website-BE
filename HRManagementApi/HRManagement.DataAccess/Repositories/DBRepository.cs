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
        public async Task Delete(long[] customerIds)
        {
           var customers =  await _context.Customers.Where(c => customerIds.Contains(c.Id)).ToListAsync();
            if (customers != null)
            {
                    _context.Customers.RemoveRange(customers);
                    await _context.SaveChangesAsync();
            }
            else {
                throw new InvalidOperationException($"No customers were found");
            }
           
        }
    }
}
