using AutoMapper;
using HRManagement.Business.Models;

namespace HRManagement.Business.Interface
{
    public class DBService : IDBService
    {
        private readonly DataAccess.Services.IDBRepository _dataService;
        private readonly IMapper _mapper;
        public DBService(DataAccess.Services.IDBRepository dataService,
             IMapper mapper)
        {
            _dataService = dataService ?? throw new ArgumentNullException(nameof(dataService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomers(
            int pageNumber, int pageSize)
        {
            var allCustomers = await _dataService.GetAllCustomersAsync(pageNumber, pageSize);
            var mappedAllCustomers = allCustomers.Select(_mapper.Map<CustomerDto>);
            return mappedAllCustomers;
        }
    }
}
