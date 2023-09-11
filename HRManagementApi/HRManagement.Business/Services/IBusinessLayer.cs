using HRManagement.Business.Models;
namespace HRManagement.Business.Services
{
    public interface IBusinessLayer
    {
        Task<UserDto> GetUser(long userID);
    }
}
