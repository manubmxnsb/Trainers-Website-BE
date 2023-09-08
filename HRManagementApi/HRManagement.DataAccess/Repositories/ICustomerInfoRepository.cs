using HRManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DataAccess.Repositories
{
    public interface ICustomerInfoRepository
    {
        Task<Customer?> GetCustomerAsync(long customerId, bool includeDocuments);
        Task<IEnumerable<Document>> GetDocumentsForCustomerAsync(long customerId);
        Task<Document> GetDocumentForCustomerAsync(long customerId, long documentId);
        Task<bool> CustomerExistsAsync(long cityId);
    }
}
