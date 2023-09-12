using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;


namespace HRManagement.Business.Services
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IDBRepository _dataRepository;
        private readonly IMapper _mapper;

        public BusinessLayer(IDBRepository dataRepository, IMapper mapper)
        {
            _dataRepository = dataRepository ?? throw new ArgumentNullException(nameof(dataRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task AddNewCustomer(CustomerDto customer)
        {     
            var mappedCustomerBusiness = _mapper.Map<Customer>(customer);
            await _dataRepository.AddNewCustomerAsync(mappedCustomerBusiness);
        }

        public async Task DeleteDocuments (long customerId, long[] documentsId)
        {
            foreach ( var doc in documentsId )
            {
                await _dataRepository.GetDocumentForCustomerAsync(customerId, doc);
                await _dataRepository.DeleteDocumentsAsync(doc);
            }
            
        }
    }
}
