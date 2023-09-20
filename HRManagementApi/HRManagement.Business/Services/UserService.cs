using AutoMapper;
using HRManagement.Business.Exceptions;
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
            if (user == null)
            {
                throw new NotFoundException();  
            }
            return _mapper.Map<UserDto>(user);
        }

    }
}
