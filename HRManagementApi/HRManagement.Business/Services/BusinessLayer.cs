using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;



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

        //public async Task<ActionResult<IEnumerable<EventsDto>>> GetEvents(long userId)
        //{
        //  var events = await _dBRepository.GetEventsForCityAsync(userId);
        // // return (_mapper.Map<IEnumerable<EventsDto>>(events));

        //}
        public async Task<IEnumerable<EventsDto>> GetEvents(long userId)
        {
            var events = await _dBRepository.GetEventsForCityAsync(userId);
             return (_mapper.Map<IEnumerable<EventsDto>>(events));

        }

        public async Task<UserWithEventsDto> GetUserWithEvents(long userID, bool includeEvents)
        {
            var user = await _dBRepository.GetUserWithEventsAsync(userID, includeEvents);
            return (_mapper.Map<UserWithEventsDto>(user));
            //if(user == null) {
            //    return NotFound();
            //}

            //return (_mapper.Map<UserDto>(user));

        }
    }
}
