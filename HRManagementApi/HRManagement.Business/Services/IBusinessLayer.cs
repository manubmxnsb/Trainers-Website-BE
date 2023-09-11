using HRManagement.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRManagement.Business.Services
{
    public interface IBusinessLayer
    {
        Task<UserDto> GetUser(long userID);
        Task<UserWithEventsDto> GetUserWithEvents(long userID, bool includeEvents );

        // Task<ActionResult<IEnumerable<EventsDto>>> GetEvents(long userId);
        Task<IEnumerable<EventsDto>> GetEvents(long userId);

    }
}
