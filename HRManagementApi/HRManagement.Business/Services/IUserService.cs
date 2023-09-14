using HRManagement.Business.Models;


namespace HRManagement.Business.Services
{
    public interface IUserService
    {
        Task<UserDto> GetUser(long userID);
        Task<IEnumerable<EventsDto>> GetEvents(long userId);
        Task<bool> UserExistsAsync(long userID);
    }
}
