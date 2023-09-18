using AutoMapper;
using HRManagement.Business.Models;

using HRManagement.DataAccess.Repositories;

namespace HRManagement.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        { 
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserDto> GetUser(long userID)
        {
            var user = await _userRepository.GetUserAsync(userID);
            return _mapper.Map<UserDto>(user);
        }

    }
}
