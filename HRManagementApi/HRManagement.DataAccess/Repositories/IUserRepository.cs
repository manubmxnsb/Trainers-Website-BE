using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{

    public interface IUserRepository
    {
        Task<bool> UserExistsAsync(long userID);

        Task<User?> GetUserAsync(long userID);

        Task<IEnumerable<Event>> GetEventsForUserAsync(long userID);
    }
}
