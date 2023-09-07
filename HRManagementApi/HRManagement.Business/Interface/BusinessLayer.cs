using HRManagement.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Business.Interface
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly HRManagementDBContext _context;

        public BusinessLayer(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
