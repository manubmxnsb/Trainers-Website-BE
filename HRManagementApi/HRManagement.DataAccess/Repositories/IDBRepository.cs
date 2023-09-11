using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{
    public interface IDBRepository
    {
        Task AddNewCustomerAsync(Customer newCustomer);

        Task<Document> GetDocumentForCustomerAsync(long customerId, long documentId);
        Task DeleteDocumentsAsync(long documentId);

    }
}
