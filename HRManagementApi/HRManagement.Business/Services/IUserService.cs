using HRManagement.Business.Models;


namespace HRManagement.Business.Services
{
    public interface IUserService
    {
        Task<UserWithEventsDto> GetUserWithEvents(long userID, bool includeEvents);
        Task<IEnumerable<EventsDto>> GetEvents(long userId);
        Task<bool> UserExistsAsync(long userID);
    }
}
