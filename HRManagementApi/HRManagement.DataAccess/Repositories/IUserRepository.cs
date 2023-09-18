using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{

    public interface IUserRepository
    {
        Task<User?> GetUserAsync(long userID);

       
    }
}
