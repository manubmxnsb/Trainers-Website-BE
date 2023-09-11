using HRManagement.DataAccess.Entities;



namespace HRManagement.DataAccess.Repositories
{

    public interface IDBRepository
    {

        Task<User?> GetUserAsync(long userID);
        //Task<User?> GetUserWithEventsAsync(long userID, bool includeEvents);
    
    }
}
