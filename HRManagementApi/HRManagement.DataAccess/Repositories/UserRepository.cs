using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.DataAccess.Repositories
{
    public class UserRepository : IUserRepository

    {
        private readonly HRManagementDBContext _context;
        public UserRepository(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public async Task<User?> GetUserWithEventsAsync(long userId, bool includeEvents)
        {
            if (includeEvents)
            {
                return await _context.Users.Include(u => u.Events).Where(u => u.Id == userId).FirstOrDefaultAsync();
            }
            return await _context.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }

        public async Task<bool> UserExistsAsync(long userId)
        {
            return await _context.Users.AnyAsync(u => u.Id == userId);
        }

        public async Task<IEnumerable<Event>> GetEventsForCityAsync(long userId)
        {

            return await _context.Events.Where(e => e.UserId == userId).ToListAsync();
        }



    }
}
