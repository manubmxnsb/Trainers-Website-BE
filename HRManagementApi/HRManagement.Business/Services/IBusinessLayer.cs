using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface IBusinessLayer
    {
        Task AddNewCustomer(CustomerDto customer);

        Task DeleteDocuments(long customerId, long documentId);
    }
}