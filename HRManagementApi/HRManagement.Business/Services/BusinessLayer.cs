using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Business.Services
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IDBRepository _dBRepository;
        private readonly IMapper _mapper;

        public BusinessLayer(IDBRepository dbRepository, IMapper mapper)
        {
            //_dataService = dataService ?? throw new ArgumentNullException(nameof(dataService));
            _mapper = mapper;
            _dBRepository = dbRepository;
        }

        public async Task<UserDto> GetUser(long userID)
        {
            var user = await _dBRepository.GetUserAsync(userID);
            return (_mapper.Map<UserDto>(user));
        }
    }
}
